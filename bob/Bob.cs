using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        return statement switch
        {
            _ when IsYelling(statement) && IsAsking(statement) => "Calm down, I know what I'm doing!",
            _ when IsYelling(statement) => "Whoa, chill out!",
            _ when IsAsking(statement) => "Sure.",
            "" => "Fine. Be that way!",
            _ => "Whatever."
        };
    }

    private static bool IsYelling(string statement) =>
        statement.Any(char.IsLetter) && statement.Equals(statement.ToUpper());

    private static bool IsAsking(string statement) =>
        statement.EndsWith('?');
}