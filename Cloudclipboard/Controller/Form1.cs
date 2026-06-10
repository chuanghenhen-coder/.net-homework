using System.Threading.Tasks;

namespace Controller
{
    public partial class Form1 : Form
    {
        NetworkClient networkClient = new NetworkClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                    txtOutput.Text = message; // 收到資料後顯示在畫面上
                });
            });

        }
        private async void btnSendClipboard_Click(object sender, EventArgs e)
        {
            // 傳送剪貼簿指令給 Agent
            await networkClient.SendCommandAsync("clipboard", txtClipboard.Text);
            lblStatus.Text = "已傳送！";
        }

        private async void btnSysInfo_Click(object sender, EventArgs e)
        {
            // 查詢系統狀態
            await networkClient.SendCommandAsync("sysinfo", "");
            lblStatus.Text = "已查詢（等待回傳）";
        }


    }
}
