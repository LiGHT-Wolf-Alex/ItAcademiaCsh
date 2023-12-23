namespace Test;

public static class Program
{
    static void Main()
    {
        List<LogEntry> logs = GenerateLogs();
        LogProcessor logProcessor = new LogProcessor();
        logProcessor.ErrorOccurred += HandleErrorOccurred;

        var errorLogs = logProcessor.FilterByLevel(logs, LogLevel.Error);
        Console.WriteLine($"Количество ошибок: {logProcessor.CountErrors(logs)}");

        var recentLogs = logProcessor.FindRecentLogs(logs, DateTime.Now.AddHours(-1));
        foreach (var log in recentLogs)
        {
            Console.WriteLine($"Recent log: {log.Timestamp} - {log.Level} - {log.Message}");
        }

        var groupedLogs = logProcessor.GroupByLevel(logs);
        foreach (var group in groupedLogs)
        {
            Console.WriteLine($"{group.Key} count: {group.Value}");
        }

        var topLogs = logProcessor.FindTopLogs(logs, "ключевое слово", 5);
        foreach (var log in topLogs)
        {
            Console.WriteLine($"Top log: {log.Timestamp} - {log.Level} - {log.Message}");
        }

        logProcessor.CheckErrors(logs);
    }

    static List<LogEntry> GenerateLogs()
    {
        return
        [
            new LogEntry { Timestamp = DateTime.Now, Level = LogLevel.Info, Message = "Информационное сообщение 1" },
            new LogEntry
                { Timestamp = DateTime.Now, Level = LogLevel.Warning, Message = "Предупреждающее сообщение 1" },
            new LogEntry { Timestamp = DateTime.Now, Level = LogLevel.Error, Message = "Сообщение об ошибкe 1" }
        ];
    }

    static void HandleErrorOccurred(object sender, EventArgs e)
    {
        Console.WriteLine("Возникла ошибка!");
    }
}