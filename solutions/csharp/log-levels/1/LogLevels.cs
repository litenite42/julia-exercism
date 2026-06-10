static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(':').Last().Trim();
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Split(':').First().Replace("[", "").Replace("]", "").ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
