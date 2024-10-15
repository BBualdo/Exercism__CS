using System.Collections.Generic;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        var stack = new Stack<char>();

        foreach (var c in input)
        {
            if (IsOpenBracket(c)) stack.Push(c);
            else if (IsCloseBracket(c))
            {
                if (stack.Count == 0) return false;
                var openBracket = stack.Pop();
                if (!BracketsMatch(openBracket, c)) return false;
            }
        }

        return stack.Count == 0;
    }
    
    private static bool IsOpenBracket(char c) => c is '(' or '{' or '[';
    private static bool IsCloseBracket(char c) => c is ')' or '}' or ']';
    private static bool BracketsMatch(char open, char close) => (open, close) switch
    {
        ('(', ')') => true,
        ('[', ']') => true,
        ('{', '}') => true,
        _ => false
    };
}
