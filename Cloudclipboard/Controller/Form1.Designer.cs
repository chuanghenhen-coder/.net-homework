namespace Controller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnect = new Button();
            txtIP = new TextBox();
            txtClipboard = new TextBox();
            btnSendClipboard = new Button();
            btnSysInfo = new Button();
            txtOutput = new TextBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(226, 42);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(112, 34);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "連線";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(56, 45);
            txtIP.Name = "txtIP";
            txtIP.PlaceholderText = "輸入電腦IP";
            txtIP.Size = new Size(150, 30);
            txtIP.TabIndex = 1;
            // 
            // txtClipboard
            // 
            txtClipboard.Location = new Point(56, 100);
            txtClipboard.Name = "txtClipboard";
            txtClipboard.PlaceholderText = "輸入文字";
            txtClipboard.Size = new Size(150, 30);
            txtClipboard.TabIndex = 2;
            // 
            // btnSendClipboard
            // 
            btnSendClipboard.Location = new Point(226, 97);
            btnSendClipboard.Name = "btnSendClipboard";
            btnSendClipboard.Size = new Size(112, 34);
            btnSendClipboard.TabIndex = 3;
            btnSendClipboard.Text = "傳送";
            btnSendClipboard.UseVisualStyleBackColor = true;
            btnSendClipboard.Click+=btnSendClipboard_Click;
            // 
            // btnSysInfo
            // 
            btnSysInfo.Location = new Point(189, 157);
            btnSysInfo.Name = "btnSysInfo";
            btnSysInfo.Size = new Size(140, 34);
            btnSysInfo.TabIndex = 4;
            btnSysInfo.Text = "查詢系統狀態";
            btnSysInfo.UseVisualStyleBackColor = true;
            btnSysInfo.Click+=btnSysInfo_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(56, 206);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(414, 200);
            txtOutput.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(361, 48);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 23);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "未連線";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(552, 450);
            Controls.Add(lblStatus);
            Controls.Add(txtOutput);
            Controls.Add(btnSysInfo);
            Controls.Add(btnSendClipboard);
            Controls.Add(txtClipboard);
            Controls.Add(txtIP);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private TextBox txtIP;
        private TextBox txtClipboard;
        private Button btnSendClipboard;
        private Button btnSysInfo;
        private TextBox txtOutput;
        private Label lblStatus;
    }
}
