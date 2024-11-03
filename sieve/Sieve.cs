using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(limit);
        
        var numbers = new List<int>();

        for (var i = 2; i <= limit; i++)
        {
            numbers.Add(i);
        }

        foreach (var num in numbers.ToList())
        {
            for (var i = num + num; i <= limit; i += num)
            {
                numbers.Remove(i);
            }
        }

        return numbers.ToArray();
    }
}