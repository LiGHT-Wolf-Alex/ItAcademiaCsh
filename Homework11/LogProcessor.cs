namespace Test;

public class LogProcessor
{
    public event EventHandler? ErrorOccurred;

    public List<LogEntry> FilterByLevel(List<LogEntry> logs, LogLevel level)
    {
        return logs.Where(log => log.Level == level).ToList();
    }

    public int CountErrors(List<LogEntry> logs)
    {
        return logs.Count(log => log.Level == LogLevel.Error);
    }

    public List<LogEntry> FindRecentLogs(List<LogEntry> logs, DateTime since)
    {
        return logs.Where(log => log.Timestamp > since).ToList();
    }

    public Dictionary<LogLevel, int> GroupByLevel(List<LogEntry> logs)
    {
        return logs
            .GroupBy(log => log.Level)
            .ToDictionary(group => group.Key, group => group.Count());
    }

    public List<LogEntry> FindTopLogs(List<LogEntry> logs, string keyword, int count)
    {
        return logs
            .Where(log => log.Message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(log => log.Timestamp)
            .Take(count)
            .ToList();
    }

    public void CheckErrors(List<LogEntry> logs)
    {
        if (logs.Any(log => log.Level == LogLevel.Error))
        {
            OnErrorOccurred();
        }
    }

    protected virtual void OnErrorOccurred()
    {
        ErrorOccurred?.Invoke(this, EventArgs.Empty);
    }
}