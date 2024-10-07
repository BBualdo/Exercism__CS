using System;
using System.Linq;
using System.Text;

public static class Identifier
{
    public static char[] GreekLetters =
    [
        'α', 'β', 'γ', 'δ', 'ε', 'ζ', 'η', 'θ', 'ι', 'κ', 'λ', 'μ', 'ν', 'ξ', 'ο', 'π', 'ρ', 'ς', 'σ', 'τ', 'υ',
        'φ', 'χ', 'ψ', 'ω'
    ];
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier)) return "";
        var builder = new StringBuilder();
        var capitalizeNext = false;
        
        foreach (var c in identifier)
        {
            if (IsLowerCaseGreek(c)) continue;
            if (c == '-')
            {
                capitalizeNext = true;
                continue;
            }
            
            if (!char.IsSymbol(c) && !char.IsLetter(c) && !char.IsWhiteSpace(c) && !char.IsControl(c)) continue;
            
            builder.Append(capitalizeNext ? char.ToUpperInvariant(c) : c);
            capitalizeNext = false;
        }

        builder.Replace(' ', '_');
        builder.Replace("\0", "CTRL");

        return builder.ToString();
    }
    
    private static bool IsLowerCaseGreek(char ch) => GreekLetters.Any(letter => ch == letter);
}


    
