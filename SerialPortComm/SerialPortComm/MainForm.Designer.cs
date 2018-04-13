namespace SerialPortComm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.lblPorts = new System.Windows.Forms.Label();
            this.lblBaudRates = new System.Windows.Forms.Label();
            this.cboBaudRates = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDataBit = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnPortSwitch = new System.Windows.Forms.Button();
            this.txtDataView = new System.Windows.Forms.TextBox();
            this.groupDataView = new System.Windows.Forms.GroupBox();
            this.groupDataSend = new System.Windows.Forms.GroupBox();
            this.txtDataSend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.timSend = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.txtSimData = new System.Windows.Forms.TextBox();
            this.groupSettings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupDataView.SuspendLayout();
            this.groupDataSend.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(116, 32);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(89, 23);
            this.cboPorts.TabIndex = 0;
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(37, 36);
            this.lblPorts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(67, 15);
            this.lblPorts.TabIndex = 1;
            this.lblPorts.Text = "串口号：";
            // 
            // lblBaudRates
            // 
            this.lblBaudRates.AutoSize = true;
            this.lblBaudRates.Location = new System.Drawing.Point(37, 71);
            this.lblBaudRates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudRates.Name = "lblBaudRates";
            this.lblBaudRates.Size = new System.Drawing.Size(67, 15);
            this.lblBaudRates.TabIndex = 1;
            this.lblBaudRates.Text = "波特率：";
            // 
            // cboBaudRates
            // 
            this.cboBaudRates.FormattingEnabled = true;
            this.cboBaudRates.Location = new System.Drawing.Point(116, 68);
            this.cboBaudRates.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudRates.Name = "cboBaudRates";
            this.cboBaudRates.Size = new System.Drawing.Size(123, 23);
            this.cboBaudRates.TabIndex = 0;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(37, 108);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(67, 15);
            this.lblDataBits.TabIndex = 1;
            this.lblDataBits.Text = "数据位：";
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(116, 104);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(123, 23);
            this.cboDataBits.TabIndex = 0;
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.lblPorts);
            this.groupSettings.Controls.Add(this.lblDataBits);
            this.groupSettings.Controls.Add(this.cboPorts);
            this.groupSettings.Controls.Add(this.lblBaudRates);
            this.groupSettings.Controls.Add(this.cboBaudRates);
            this.groupSettings.Controls.Add(this.cboDataBits);
            this.groupSettings.Location = new System.Drawing.Point(35, 30);
            this.groupSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupSettings.Size = new System.Drawing.Size(303, 156);
            this.groupSettings.TabIndex = 2;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "设置";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPort,
            this.statusBaudRate,
            this.statusDataBit});
            this.statusStrip1.Location = new System.Drawing.Point(0, 735);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(856, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPort
            // 
            this.statusPort.Name = "statusPort";
            this.statusPort.Size = new System.Drawing.Size(167, 20);
            this.statusPort.Text = "toolStripStatusLabel1";
            // 
            // statusBaudRate
            // 
            this.statusBaudRate.Name = "statusBaudRate";
            this.statusBaudRate.Size = new System.Drawing.Size(167, 20);
            this.statusBaudRate.Text = "toolStripStatusLabel2";
            // 
            // statusDataBit
            // 
            this.statusDataBit.Name = "statusDataBit";
            this.statusDataBit.Size = new System.Drawing.Size(167, 20);
            this.statusDataBit.Text = "toolStripStatusLabel1";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(214, 120);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 29);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnPortSwitch
            // 
            this.btnPortSwitch.Location = new System.Drawing.Point(728, 158);
            this.btnPortSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.btnPortSwitch.Name = "btnPortSwitch";
            this.btnPortSwitch.Size = new System.Drawing.Size(100, 29);
            this.btnPortSwitch.TabIndex = 5;
            this.btnPortSwitch.Text = "打开串口";
            this.btnPortSwitch.UseVisualStyleBackColor = true;
            this.btnPortSwitch.Click += new System.EventHandler(this.btnPortSwitch_Click);
            // 
            // txtDataView
            // 
            this.txtDataView.Location = new System.Drawing.Point(41, 38);
            this.txtDataView.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataView.Multiline = true;
            this.txtDataView.Name = "txtDataView";
            this.txtDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataView.Size = new System.Drawing.Size(268, 246);
            this.txtDataView.TabIndex = 6;
            // 
            // groupDataView
            // 
            this.groupDataView.Controls.Add(this.txtDataView);
            this.groupDataView.Location = new System.Drawing.Point(47, 194);
            this.groupDataView.Margin = new System.Windows.Forms.Padding(4);
            this.groupDataView.Name = "groupDataView";
            this.groupDataView.Padding = new System.Windows.Forms.Padding(4);
            this.groupDataView.Size = new System.Drawing.Size(344, 321);
            this.groupDataView.TabIndex = 7;
            this.groupDataView.TabStop = false;
            this.groupDataView.Text = "通讯数据";
            // 
            // groupDataSend
            // 
            this.groupDataSend.Controls.Add(this.txtDataSend);
            this.groupDataSend.Controls.Add(this.btnSend);
            this.groupDataSend.Location = new System.Drawing.Point(47, 523);
            this.groupDataSend.Margin = new System.Windows.Forms.Padding(4);
            this.groupDataSend.Name = "groupDataSend";
            this.groupDataSend.Padding = new System.Windows.Forms.Padding(4);
            this.groupDataSend.Size = new System.Drawing.Size(344, 178);
            this.groupDataSend.TabIndex = 7;
            this.groupDataSend.TabStop = false;
            this.groupDataSend.Text = "发送数据";
            // 
            // txtDataSend
            // 
            this.txtDataSend.Location = new System.Drawing.Point(36, 36);
            this.txtDataSend.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataSend.Multiline = true;
            this.txtDataSend.Name = "txtDataSend";
            this.txtDataSend.Size = new System.Drawing.Size(273, 76);
            this.txtDataSend.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "临界值警报";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(418, 66);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(45, 38);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(556, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(41, 38);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "设备实时数据";
            // 
            // timSend
            // 
            this.timSend.Interval = 1000;
            this.timSend.Tick += new System.EventHandler(this.timSend_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateData);
            this.groupBox1.Controls.Add(this.txtSimData);
            this.groupBox1.Location = new System.Drawing.Point(483, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 321);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仿真数据";
            // 
            // btnCreateData
            // 
            this.btnCreateData.Location = new System.Drawing.Point(20, 283);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(85, 23);
            this.btnCreateData.TabIndex = 1;
            this.btnCreateData.Text = "开始生成";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // txtSimData
            // 
            this.txtSimData.Location = new System.Drawing.Point(20, 38);
            this.txtSimData.Multiline = true;
            this.txtSimData.Name = "txtSimData";
            this.txtSimData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSimData.Size = new System.Drawing.Size(239, 228);
            this.txtSimData.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 760);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.groupDataSend);
            this.Controls.Add(this.groupDataView);
            this.Controls.Add(this.btnPortSwitch);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupSettings);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "串口通讯";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupDataView.ResumeLayout(false);
            this.groupDataView.PerformLayout();
            this.groupDataSend.ResumeLayout(false);
            this.groupDataSend.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.Label lblBaudRates;
        private System.Windows.Forms.ComboBox cboBaudRates;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPort;
        private System.Windows.Forms.ToolStripStatusLabel statusBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel statusDataBit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnPortSwitch;
        private System.Windows.Forms.TextBox txtDataView;
        private System.Windows.Forms.GroupBox groupDataView;
        private System.Windows.Forms.GroupBox groupDataSend;
        private System.Windows.Forms.TextBox txtDataSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSimData;
        private System.Windows.Forms.Button btnCreateData;
    }
}