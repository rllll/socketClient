namespace socketClient
{
    partial class socketClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recevMsg = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.choose = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Send = new System.Windows.Forms.Button();
            this.sendMsg = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IPaddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.recevMsg);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提示信息";
            // 
            // recevMsg
            // 
            this.recevMsg.FormattingEnabled = true;
            this.recevMsg.ItemHeight = 12;
            this.recevMsg.Location = new System.Drawing.Point(17, 29);
            this.recevMsg.Name = "recevMsg";
            this.recevMsg.Size = new System.Drawing.Size(411, 400);
            this.recevMsg.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.choose);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.connect);
            this.groupBox2.Controls.Add(this.Port);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IPaddr);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(506, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 471);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "连接服务器";
            // 
            // choose
            // 
            this.choose.FormattingEnabled = true;
            this.choose.Location = new System.Drawing.Point(23, 205);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(120, 20);
            this.choose.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Send);
            this.groupBox3.Controls.Add(this.sendMsg);
            this.groupBox3.Location = new System.Drawing.Point(15, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 148);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送信息";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(261, 64);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 1;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // sendMsg
            // 
            this.sendMsg.Location = new System.Drawing.Point(8, 64);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(247, 21);
            this.sendMsg.TabIndex = 0;
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.connect.Location = new System.Drawing.Point(274, 205);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 4;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(150, 139);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(199, 21);
            this.Port.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务器端口";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPaddr
            // 
            this.IPaddr.Location = new System.Drawing.Point(150, 70);
            this.IPaddr.Name = "IPaddr";
            this.IPaddr.Size = new System.Drawing.Size(199, 21);
            this.IPaddr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP地址";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.status.Location = new System.Drawing.Point(24, 523);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(450, 23);
            this.status.TabIndex = 2;
            this.status.Text = "当前状态未连接";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(793, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "退出程序";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "清空信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // socketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 564);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "socketClient";
            this.Text = "socketClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IPaddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox sendMsg;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ListBox recevMsg;
        private System.Windows.Forms.ComboBox choose;
        private System.Windows.Forms.Button button1;
    }
}

