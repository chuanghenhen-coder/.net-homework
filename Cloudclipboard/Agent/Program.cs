using System.Net;
using System.Net.Sockets;
using System.Text;

TcpListener listener = new TcpListener(IPAddress.Any, 9000);
listener.Start();
Console.WriteLine("等待指令中...");

while (true)
{
    TcpClient client = await listener.AcceptTcpClientAsync();
    _ = HandleClientAsync(client);
}

async Task HandleClientAsync(TcpClient client)
{
    NetworkStream stream = client.GetStream();
    byte[] buffer = new byte[4096];

    while (true)
    {
        int bytesRead = await stream.ReadAsync(buffer);
        if (bytesRead == 0) break;

        string json = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] 收到指令：{json}");

        var handler = new CommandHandler(stream);
        handler.Execute(json);
      
    }
}
