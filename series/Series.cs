using System;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength < 1 || numbers.Length < sliceLength) throw new ArgumentException();

        return numbers.Length == sliceLength
            ? [numbers]
            : numbers.TakeWhile((_, i) => i + sliceLength <= numbers.Length)
                .Select((_, i) => numbers.Substring(i, sliceLength)).ToArray();
    }
}