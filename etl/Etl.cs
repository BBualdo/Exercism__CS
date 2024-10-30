using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var newDict = new Dictionary<string, int>();

        foreach (var kvp in old)
        {
            foreach (var str in kvp.Value)
            {
                newDict.Add(str.ToLower(), kvp.Key);
            }    
        }

        return newDict;
    }
}