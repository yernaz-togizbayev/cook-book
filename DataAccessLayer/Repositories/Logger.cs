using System;
using System.IO;

public static class Logger
{
    private static readonly object _lock = new object();
    private static readonly string _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    private static readonly string _logFilePath = Path.Combine(_desktopPath, "CookBookLogs.txt");

    public static void Initialize()
    {
        lock (_lock)
        {
            // Overwrite (create new or clear existing file)
            File.WriteAllText(_logFilePath, $"Log started at {DateTime.Now:yyyy-MM-dd HH:mm:ss}{Environment.NewLine}");
        }
    }
    public static void LogError(string message, DateTime time)
    {
        Log("ERROR", message, time);
    }

    public static void LogWarning(string message, DateTime time)
    {
        Log("WARNING", message, time);
    }

    public static void LogInfo(string message, DateTime time)
    {
        Log("INFO", message, time);
    }

    private static void Log(string level, string message, DateTime time)
    {
        string logEntry = $"{time:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
        lock (_lock)
        {
            File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
        }
    }
}
