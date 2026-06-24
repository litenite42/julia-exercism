// TODO: define the 'LogLevel' enum

enum LogLevel {
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        var x = logLine.Split(']')[0];
        LogLevel result;

        switch (x.Substring(1)) {
            case "INF": 
                result = LogLevel.Info;
                break;
            case "TRC":
                result = LogLevel.Trace;
                break;
            case "DBG":
                result = LogLevel.Debug;
                break;
            case "WRN":
                result = LogLevel.Warning;
                break;
            case "ERR":
                result = LogLevel.Error;
                break;
            case "FTL":
                result = LogLevel.Fatal;
                break;
            default:
                result = LogLevel.Unknown;
                break;
        }

        return result;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
