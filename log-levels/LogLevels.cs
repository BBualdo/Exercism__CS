using System;
using System.Linq;

static class LogLine
{
    public static string Message(string logLine)
    {
        var indexOfColon = logLine.IndexOf(':');
        return logLine.Substring(indexOfColon + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        var indexOfColon = logLine.IndexOf(':');
        var logLevel = logLine.Remove(indexOfColon);
        return string.Join("", logLevel.Where(c => c != '[' && c != ']')).ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
    
}
