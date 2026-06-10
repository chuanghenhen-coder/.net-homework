using System.Net.Sockets;
using System.Text;
using System.Text.Json;

public class NetworkClient
{
    private TcpClient? client;
    private NetworkStream? stream;

    public async Task ConnectAsync(string ip)
    {
        client = new TcpClient();
        await client.ConnectAsync(ip, 9000);
        stream = client.GetStream();
    }

    public async Task SendCommandAsync(string type, string data)
    {
        var cmd = new Command { Type = type, Data = data };
        string json = JsonSerializer.Serialize(cmd);
        byte[] bytes = Encoding.UTF8.GetBytes(json);
        await stream!.WriteAsync(bytes);
    }

    public async Task StartReceivingAsync(Action<string> onMessageReceived)
    {
        byte[] buffer = new byte[4096];
        while (true)
        {
            int bytesRead = await stream!.ReadAsync(buffer);
            if (bytesRead == 0) break;
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            onMessageReceived(message);
        }
    }
}
