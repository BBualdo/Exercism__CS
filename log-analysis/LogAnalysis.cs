public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string delimiter) => str.Split(delimiter)[1];
    public static string SubstringBetween(this string str, string delimiter1, string delimiter2) => str.Split(delimiter1)[1].Split(delimiter2)[0];
    public static string Message(this string str) => str.SubstringAfter(": ");
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}