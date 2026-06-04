using System.Diagnostics;

public class SystemInfo
{
    public static string GetAll()
    {
        DriveInfo drive = new DriveInfo("C");
        long freeGB = drive.AvailableFreeSpace / 1024 / 1024 / 1024;

        var processes = Process.GetProcesses()
                               .Select(p => p.ProcessName)
                               .Distinct()
                               .OrderBy(n => n)
                               .Take(10)
                               .ToList();

        return $"電腦名稱：{Environment.MachineName}\n" +
               $"硬碟剩餘：{freeGB} GB\n" +
               $"執行中程式：{string.Join(", ", processes)}";
    }
}