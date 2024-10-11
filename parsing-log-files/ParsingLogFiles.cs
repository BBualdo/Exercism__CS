using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string text) => Regex.IsMatch(text, @"^\[(TRC|DBG|INF|WRN|FTL)\] ");

    public string[] SplitLogLine(string text) => Regex.Split(text, @"<[\^*=\-]+>");
    
    public int CountQuotedPasswords(string lines) => Regex.Count(lines, @""".*?password.*?""", RegexOptions.IgnoreCase);
    
    public string RemoveEndOfLineText(string line) => Regex.Replace(line, @"end-of-line\d+", "");

    public string[] ListLinesWithPasswords(string[] lines)
    {
        var result = new List<string>();
        var regex = new Regex(@"\bpassword(\S+)", RegexOptions.IgnoreCase);

        foreach (var line in lines)
        {
            var match = regex.Match(line);

            if (match.Success) result.Add($"{match.Value}: {line}");
            else result.Add($"--------: {line}");
        }

        return result.ToArray();
    }
}
