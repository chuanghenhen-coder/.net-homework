using System.Drawing;
using System.Windows.Forms;

namespace Controller
{
    public partial class Form1 : Form
    {
        NetworkClient networkClient = new NetworkClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            await networkClient.ConnectAsync(txtIP.Text);
            lblStatus.Text = "已連線";
            lblStatus.ForeColor = Color.Green;

            // 連線後開始在背景接收資料
            _ = networkClient.StartReceivingAsync(message =>
            {
                this.Invoke(() =>
                {
                    txtOutput.Text = message;
                });
            });
        }

        private async void btnSendClipboard_Click(object sender, EventArgs e)
        {
            await networkClient.SendCommandAsync("clipboard", txtClipboard.Text);
            lblStatus.Text = "已傳送！";
        }

        private async void btnSysInfo_Click(object sender, EventArgs e)
        {
            await networkClient.SendCommandAsync("sysinfo", "");
            lblStatus.Text = "已查詢（等待回傳）";
        }
    }
}

