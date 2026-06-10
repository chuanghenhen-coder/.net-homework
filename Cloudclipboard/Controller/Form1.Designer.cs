namespace Controller
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtIP = new TextBox();
            btnConnect = new Button();
            txtClipboard = new TextBox();
            btnSendClipboard = new Button();
            btnSysInfo = new Button();
            txtOutput = new TextBox();
            lblStatus = new Label();
            SuspendLayout();

            txtIP.Location = new Point(50, 30);
            txtIP.Size = new Size(200, 23);
            txtIP.PlaceholderText = "輸入電腦IP";

            btnConnect.Location = new Point(270, 30);
            btnConnect.Size = new Size(80, 23);
            btnConnect.Text = "連線";
            btnConnect.Click += btnConnect_Click;

            txtClipboard.Location = new Point(50, 70);
            txtClipboard.Size = new Size(200, 23);
            txtClipboard.PlaceholderText = "輸入文字";

            btnSendClipboard.Location = new Point(270, 70);
            btnSendClipboard.Size = new Size(80, 23);
            btnSendClipboard.Text = "傳送";
            btnSendClipboard.Click += btnSendClipboard_Click;

            btnSysInfo.Location = new Point(150, 110);
            btnSysInfo.Size = new Size(120, 23);
            btnSysInfo.Text = "查詢系統狀態";
            btnSysInfo.Click += btnSysInfo_Click;

            txtOutput.Location = new Point(50, 150);
            txtOutput.Size = new Size(500, 200);
            txtOutput.Multiline = true;
            txtOutput.ReadOnly = true;

            lblStatus.Location = new Point(370, 30);
            lblStatus.Size = new Size(100, 23);
            lblStatus.Text = "未連線";
            lblStatus.ForeColor = Color.Red;

            Controls.AddRange(new Control[] { txtIP, btnConnect, txtClipboard, btnSendClipboard, btnSysInfo, txtOutput, lblStatus });
            ClientSize = new Size(620, 400);
            Text = "雲端剪貼簿控制器";
            ResumeLayout(false);

            this.txtIP = txtIP;
            this.btnConnect = btnConnect;
            this.txtClipboard = txtClipboard;
            this.btnSendClipboard = btnSendClipboard;
            this.btnSysInfo = btnSysInfo;
            this.txtOutput = txtOutput;
            this.lblStatus = lblStatus;
        }

        private TextBox txtIP;
        private Button btnConnect;
        private TextBox txtClipboard;
        private Button btnSendClipboard;
        private Button btnSysInfo;
        private TextBox txtOutput;
        private Label lblStatus;
    }
}

