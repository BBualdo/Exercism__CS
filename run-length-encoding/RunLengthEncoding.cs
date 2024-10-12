using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        var result = "";
        if (string.IsNullOrEmpty(input)) return result;
        
        int count = 1;

        for (var i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1]) count++;
            else
            {
                result += count > 1 ? $"{count}{input[i - 1]}" : input[i - 1];
                count = 1;
            }
        }

        result += count > 1 ? $"{count}{input[^1]}" : input[^1];

        return result;
    }

    public static string Decode(string input)
    {
        var result = new StringBuilder();
        string count = "";

        foreach (var c in input)
        {
            if (char.IsDigit(c)) count += c;
            else
            {
                if (string.IsNullOrEmpty(count)) count = "1";
                int.TryParse(count, out int repeatCount);
                
                result.Append(c, repeatCount);
                count = "";
            }
        }

        return result.ToString();
    }
}
