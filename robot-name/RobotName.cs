using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    public string Name { get; set; }
    
    private static Random _random = new();
    private static List<string> UsedNames { get; set; } = [];

    public Robot() => Name = GenerateName();
    
    public void Reset() => Name = GenerateName();

    private string GenerateName()
    {
        string result;
        
        do
        {
            var builder = new StringBuilder();

            for (var i = 0; i < 2; i++)
            {
                builder.Append(Convert.ToChar(_random.Next(65, 91)));
            }

            for (var i = 0; i < 3; i++)
            {
                builder.Append(_random.Next(0, 10));
            }

            result = builder.ToString();
        } while (UsedNames.Contains(result));
        
        
        UsedNames.Add(result);
        return result;
    }
}