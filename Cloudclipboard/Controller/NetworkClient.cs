using System.Net.Sockets;
using System.Text;
using System.Text.Json;

public class NetworkClient
{
    // 負責建立與 Agent 的連線
    private TcpClient? client;

    // 負責實際傳送和接收資料的通道
    private NetworkStream? stream;

    // 連線到指定 IP 的方法
    public async Task ConnectAsync(string ip)
    {
        client = new TcpClient();
        await client.ConnectAsync(ip, 9000); // 連線到對方 IP，port 用 9000
        stream = client.GetStream();          // 連線成功後取得傳輸通道
    }

    // 傳送指令給 Agent 的方法
    public async Task SendCommandAsync(string type, string data)
    {
        var cmd = new Command { Type = type, Data = data }; // 包成 Command 物件
        string json = JsonSerializer.Serialize(cmd);         // 轉成 JSON 字串
        byte[] bytes = Encoding.UTF8.GetBytes(json);         // 轉成 byte 陣列
        await stream!.WriteAsync(bytes);                     // 傳出去
    }

    // 持續接收 Agent 回傳資料的方法
    public async Task StartReceivingAsync(Action<string> onMessageReceived)
    {
        byte[] buffer = new byte[4096];
        while (true)
        {
            int bytesRead = await stream!.ReadAsync(buffer); // 等待收到資料
            if (bytesRead == 0) break;                        // 對方斷線就停止

            // 把收到的 byte 轉回字串，傳給呼叫者處理
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            onMessageReceived(message);
        }
    }
}
