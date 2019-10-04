using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace socketClient
{
    public partial class socketClient : Form
    {
        Thread clientThread;//开启服务
        Thread clientThreadSub;//接收数据
        Socket clientSocketMain = null;
        Socket clientSocketSub = null;
        static string hostName = Dns.GetHostName();//本机名   
        IPEndPoint ipep;
        IPAddress[] addressList;
        IPAddress ip;

        public socketClient()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            string[] chooseList = new string[2];
            chooseList[0] = "TCP连接";
            chooseList[1] = "UDP连接";
            choose.Items.AddRange(chooseList);
            choose.SelectedIndex = 0;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (IPaddr.Text == "")
            {
                MessageBox.Show("服务器IP地址没填！","提醒");
                return;
            }
            if (Port.Text == "")
            {
                MessageBox.Show("服务器端口没填！","提醒");
                return;
            }
            ipep = new IPEndPoint(IPAddress.Parse(IPaddr.Text), int.Parse(Port.Text));
            if (choose.SelectedIndex == 0)
            {
                clientSocketMain = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                
            }
            else
            {
                clientSocketMain = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                
            }
            try
            {
                clientSocketMain.Connect(ipep);
                status.Text = "已成功连接到服务器！";
                Thread thread = new Thread(new ThreadStart(receive));
                thread.Start();
            }
            catch
            {
                status.Text = "服务器连接失败！";
                return;
            }


        }

        public void receiveMsgShow(string Msg)
        {
            recevMsg.Items.Add(Msg);
            recevMsg.SetSelected(recevMsg.Items.Count - 1, true);
        }

        public void receive()
        {
            receiveMsgShow("等待服务器发送消息！");

            if (choose.SelectedIndex == 0)
            {
                while (true)
                {
                    byte[] bytes = new byte[1024 * 1024];
                    try
                    {
                        int size = clientSocketMain.Receive(bytes);
                        if (size == 0)
                        {
                            receiveMsgShow("#没有接收到服务器消息#");
                            continue;
                        }
                    }
                    catch (Exception ex)
                    {
                        receiveMsgShow("与服务器断开连接！");
                        receiveMsgShow("错误信息：" + ex.Message);
                        return;
                    }
                    string Msg = Encoding.UTF8.GetString(bytes);
                    receiveMsgShow("接收消息：" + Msg);
                }
            }
            else
            {
                EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                while(true)
                {
                    byte[] bytes = new byte[1024 * 1024];
                    try
                    {
                        int len = clientSocketMain.ReceiveFrom(bytes, ref endPoint);
                        if (len == 0)
                        {
                            continue;
                        }
                        receiveMsgShow("接收到服务器[ " + endPoint.ToString() + " ]的消息");
                    }
                    catch
                    {
                        receiveMsgShow("接收失败！");
                        return;
                    }
                    string serverMsg = Encoding.UTF8.GetString(bytes);
                    receiveMsgShow("接收信息：" + serverMsg);
                }
            }
            
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string Msg = sendMsg.Text;
            if (sendMsg.Text == "")
            {
                MessageBox.Show("发送信息不能为空！","提醒");
                return;
            }
            if (choose.SelectedIndex == 0)
            {
                if (clientSocketMain == null)
                {
                    MessageBox.Show("未与服务器连接...", "提示");
                    return;
                }
                else
                {
                    clientSocketMain.Send(Encoding.UTF8.GetBytes(Msg));
                    receiveMsgShow("<" + Msg + ">已成功发送！");
                }
            }
            else
            {
                EndPoint endPoint = new IPEndPoint(IPAddress.Parse(IPaddr.Text), int.Parse(Port.Text));
                clientSocketMain.SendTo(Encoding.UTF8.GetBytes(Msg),endPoint);
                receiveMsgShow("<" + Msg + ">已成功发送！");
            }
            sendMsg.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            recevMsg.Items.Clear();
        }
    }
}
