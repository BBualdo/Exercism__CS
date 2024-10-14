using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        if (sequence.Any(c => c != 'A' && c != 'G' && c != 'C' && c != 'T')) throw new ArgumentException();
        var result = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (var c in sequence)
        {
            result[c]++;
        }

        return result;
    }
}