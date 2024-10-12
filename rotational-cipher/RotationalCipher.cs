using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey) => text.Aggregate("", (current, c) => current + ShiftChar(c, shiftKey));
    
    private static char ShiftChar(char c, int shiftKey)
    {
        if (!char.IsLetter(c)) return c;
        
        var initial = char.IsUpper(c) ? 65 : 97;
            
        var charCode = initial + (c - initial + shiftKey) % 26;
        return (char)charCode;
    }
}