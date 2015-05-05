namespace 网络随意换
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtSubMark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNS1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGateWay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNS2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbProxy = new System.Windows.Forms.CheckBox();
            this.txtProxyServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProxyServerPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnApplyProject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbEnableProxy = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbIpDhcpNo = new System.Windows.Forms.RadioButton();
            this.rdbIpDhcpYes = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbDnsDhcpNo = new System.Windows.Forms.RadioButton();
            this.rdbDnsDhcpYes = new System.Windows.Forms.RadioButton();
            this.网卡参数 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNetworkCard = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbProjectList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.网卡参数.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP地址：";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(78, 69);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(173, 21);
            this.txtIP.TabIndex = 7;
            // 
            // txtSubMark
            // 
            this.txtSubMark.Location = new System.Drawing.Point(78, 95);
            this.txtSubMark.Name = "txtSubMark";
            this.txtSubMark.Size = new System.Drawing.Size(173, 21);
            this.txtSubMark.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "子网掩码：";
            // 
            // txtDNS1
            // 
            this.txtDNS1.Location = new System.Drawing.Point(62, 72);
            this.txtDNS1.Name = "txtDNS1";
            this.txtDNS1.Size = new System.Drawing.Size(173, 21);
            this.txtDNS1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "首选DNS：";
            // 
            // txtGateWay
            // 
            this.txtGateWay.Location = new System.Drawing.Point(78, 125);
            this.txtGateWay.Name = "txtGateWay";
            this.txtGateWay.Size = new System.Drawing.Size(173, 21);
            this.txtGateWay.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "默认网关：";
            // 
            // txtDNS2
            // 
            this.txtDNS2.Location = new System.Drawing.Point(62, 98);
            this.txtDNS2.Name = "txtDNS2";
            this.txtDNS2.Size = new System.Drawing.Size(173, 21);
            this.txtDNS2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "备用DNS：";
            // 
            // ckbProxy
            // 
            this.ckbProxy.AutoSize = true;
            this.ckbProxy.Location = new System.Drawing.Point(7, 40);
            this.ckbProxy.Name = "ckbProxy";
            this.ckbProxy.Size = new System.Drawing.Size(132, 16);
            this.ckbProxy.TabIndex = 16;
            this.ckbProxy.Text = "是否启用代理服务器";
            this.ckbProxy.UseVisualStyleBackColor = true;
            // 
            // txtProxyServer
            // 
            this.txtProxyServer.Location = new System.Drawing.Point(79, 61);
            this.txtProxyServer.Name = "txtProxyServer";
            this.txtProxyServer.Size = new System.Drawing.Size(153, 21);
            this.txtProxyServer.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "代理地址：";
            // 
            // txtProxyServerPort
            // 
            this.txtProxyServerPort.Location = new System.Drawing.Point(79, 87);
            this.txtProxyServerPort.Name = "txtProxyServerPort";
            this.txtProxyServerPort.Size = new System.Drawing.Size(153, 21);
            this.txtProxyServerPort.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "代理端口：";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(291, 400);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 21;
            this.btnAddProject.Text = "新增方案";
            this.btnAddProject.UseVisualStyleBackColor = true;
            // 
            // btnApplyProject
            // 
            this.btnApplyProject.Location = new System.Drawing.Point(291, 445);
            this.btnApplyProject.Name = "btnApplyProject";
            this.btnApplyProject.Size = new System.Drawing.Size(75, 23);
            this.btnApplyProject.TabIndex = 22;
            this.btnApplyProject.Text = "应用该方案";
            this.btnApplyProject.UseVisualStyleBackColor = true;
            this.btnApplyProject.Click += new System.EventHandler(this.btnApplyProject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbEnableProxy);
            this.groupBox1.Controls.Add(this.ckbProxy);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtProxyServer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtProxyServerPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 121);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IE代理服务器设置";
            // 
            // ckbEnableProxy
            // 
            this.ckbEnableProxy.AutoSize = true;
            this.ckbEnableProxy.Location = new System.Drawing.Point(8, 20);
            this.ckbEnableProxy.Name = "ckbEnableProxy";
            this.ckbEnableProxy.Size = new System.Drawing.Size(120, 16);
            this.ckbEnableProxy.TabIndex = 21;
            this.ckbEnableProxy.Text = "是否启用代理设置";
            this.ckbEnableProxy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbIpDhcpNo);
            this.groupBox2.Controls.Add(this.rdbIpDhcpYes);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSubMark);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtGateWay);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 155);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TCP/IP";
            // 
            // rdbIpDhcpNo
            // 
            this.rdbIpDhcpNo.AutoSize = true;
            this.rdbIpDhcpNo.Location = new System.Drawing.Point(12, 43);
            this.rdbIpDhcpNo.Name = "rdbIpDhcpNo";
            this.rdbIpDhcpNo.Size = new System.Drawing.Size(83, 16);
            this.rdbIpDhcpNo.TabIndex = 13;
            this.rdbIpDhcpNo.TabStop = true;
            this.rdbIpDhcpNo.Text = "手动设置IP";
            this.rdbIpDhcpNo.UseVisualStyleBackColor = true;
            // 
            // rdbIpDhcpYes
            // 
            this.rdbIpDhcpYes.AutoSize = true;
            this.rdbIpDhcpYes.Location = new System.Drawing.Point(12, 21);
            this.rdbIpDhcpYes.Name = "rdbIpDhcpYes";
            this.rdbIpDhcpYes.Size = new System.Drawing.Size(83, 16);
            this.rdbIpDhcpYes.TabIndex = 12;
            this.rdbIpDhcpYes.TabStop = true;
            this.rdbIpDhcpYes.Text = "自动获取IP";
            this.rdbIpDhcpYes.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDnsDhcpNo);
            this.groupBox3.Controls.Add(this.rdbDnsDhcpYes);
            this.groupBox3.Controls.Add(this.txtDNS2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDNS1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(291, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 134);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DNS设置";
            // 
            // rdbDnsDhcpNo
            // 
            this.rdbDnsDhcpNo.AutoSize = true;
            this.rdbDnsDhcpNo.Location = new System.Drawing.Point(9, 42);
            this.rdbDnsDhcpNo.Name = "rdbDnsDhcpNo";
            this.rdbDnsDhcpNo.Size = new System.Drawing.Size(89, 16);
            this.rdbDnsDhcpNo.TabIndex = 17;
            this.rdbDnsDhcpNo.TabStop = true;
            this.rdbDnsDhcpNo.Text = "手动设置DNS";
            this.rdbDnsDhcpNo.UseVisualStyleBackColor = true;
            // 
            // rdbDnsDhcpYes
            // 
            this.rdbDnsDhcpYes.AutoSize = true;
            this.rdbDnsDhcpYes.Location = new System.Drawing.Point(9, 20);
            this.rdbDnsDhcpYes.Name = "rdbDnsDhcpYes";
            this.rdbDnsDhcpYes.Size = new System.Drawing.Size(89, 16);
            this.rdbDnsDhcpYes.TabIndex = 16;
            this.rdbDnsDhcpYes.TabStop = true;
            this.rdbDnsDhcpYes.Text = "自动获取DNS";
            this.rdbDnsDhcpYes.UseVisualStyleBackColor = true;
            // 
            // 网卡参数
            // 
            this.网卡参数.Controls.Add(this.label1);
            this.网卡参数.Controls.Add(this.cmbNetworkCard);
            this.网卡参数.Controls.Add(this.textBox8);
            this.网卡参数.Controls.Add(this.label2);
            this.网卡参数.Controls.Add(this.lsbProjectList);
            this.网卡参数.Location = new System.Drawing.Point(12, 12);
            this.网卡参数.Name = "网卡参数";
            this.网卡参数.Size = new System.Drawing.Size(524, 188);
            this.网卡参数.TabIndex = 27;
            this.网卡参数.TabStop = false;
            this.网卡参数.Text = "网卡参数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择网卡：";
            // 
            // cmbNetworkCard
            // 
            this.cmbNetworkCard.FormattingEnabled = true;
            this.cmbNetworkCard.Location = new System.Drawing.Point(82, 25);
            this.cmbNetworkCard.Name = "cmbNetworkCard";
            this.cmbNetworkCard.Size = new System.Drawing.Size(432, 20);
            this.cmbNetworkCard.TabIndex = 3;
            this.cmbNetworkCard.SelectedIndexChanged += new System.EventHandler(this.cmbNetworkCard_SelectedIndexChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(82, 65);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(432, 21);
            this.textBox8.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "请选择方案：";
            // 
            // lsbProjectList
            // 
            this.lsbProjectList.FormattingEnabled = true;
            this.lsbProjectList.ItemHeight = 12;
            this.lsbProjectList.Location = new System.Drawing.Point(82, 95);
            this.lsbProjectList.Name = "lsbProjectList";
            this.lsbProjectList.Size = new System.Drawing.Size(432, 76);
            this.lsbProjectList.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 528);
            this.Controls.Add(this.网卡参数);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnApplyProject);
            this.Controls.Add(this.btnAddProject);
            this.Name = "Main";
            this.Text = "网络随意换V1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.网卡参数.ResumeLayout(false);
            this.网卡参数.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtSubMark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDNS1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGateWay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNS2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbProxy;
        private System.Windows.Forms.TextBox txtProxyServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProxyServerPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnApplyProject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbIpDhcpYes;
        private System.Windows.Forms.RadioButton rdbIpDhcpNo;
        private System.Windows.Forms.RadioButton rdbDnsDhcpNo;
        private System.Windows.Forms.RadioButton rdbDnsDhcpYes;
        private System.Windows.Forms.GroupBox 网卡参数;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNetworkCard;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbProjectList;
        private System.Windows.Forms.CheckBox ckbEnableProxy;
    }
}

