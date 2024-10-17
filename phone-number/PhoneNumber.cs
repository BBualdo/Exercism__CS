using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var result = new StringBuilder();

        foreach (var c in phoneNumber.Where(char.IsDigit))
        {
            if (c == '1') continue;
            result.Append(c);
        }
        
        var regex = new Regex(@"^(\+?1)?([2-9][0-9]{2})[2-9][0-9]{6}$");
        if (!regex.IsMatch(result.ToString())) throw new ArgumentException();

        return result.ToString();
    }
}