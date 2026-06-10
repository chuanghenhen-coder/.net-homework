using System;
using System.Text.Json;

public class CommandHandler
{
    public void Execute(string json)
    {
        var cmd = JsonSerializer.Deserialize<Command>(json);

        if (cmd == null)
        {
            Console.WriteLine("指令解析失敗");
            return;
        }

        switch (cmd.Type)
        {
            case "clipboard":
                Console.WriteLine($"收到剪貼簿內容：{cmd.Data}");
                break;

            case "sysinfo":
                Console.WriteLine("收到系統資訊請求");
                Console.WriteLine(SystemInfo.GetAll());
                break;

            default:
                Console.WriteLine($"未知指令：{cmd.Type}");
                break;
        }
    }
}
