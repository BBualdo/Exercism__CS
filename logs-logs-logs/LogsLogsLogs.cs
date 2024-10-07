enum LogLevel
{
    Unknown = 0,
    Trace = 1, 
    Debug = 2, 
    Info = 4, 
    Warning = 5, 
    Error = 6, 
    Fatal = 42, 
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        if (logLine.Contains("TRC")) return LogLevel.Trace;
        if (logLine.Contains("DBG")) return LogLevel.Debug;
        if (logLine.Contains("INF")) return LogLevel.Info;
        if (logLine.Contains("WRN")) return LogLevel.Warning;
        if (logLine.Contains("ERR")) return LogLevel.Error;
        if (logLine.Contains("FTL")) return LogLevel.Fatal;
        return LogLevel.Unknown;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message) => $"{(int)logLevel}:{message}";
}
