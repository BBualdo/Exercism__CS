using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class ResistorColorDuo
{
    private static readonly Dictionary<string, int> _colors = new()
    {
        ["black"] = 0,
        ["brown"] = 1,
        ["red"] = 2,
        ["orange"] = 3,
        ["yellow"] = 4,
        ["green"] = 5,
        ["blue"] = 6,
        ["violet"] = 7,
        ["grey"] = 8,
        ["white"] = 9
    };
    
    public static int Value(string[] colors)
    {
        var result = new StringBuilder();

        foreach (var color in colors.Take(2))
        {
            if (_colors.ContainsKey(color)) result.Append(_colors[color]);
        }

        return int.Parse(result.ToString());
    }
}
