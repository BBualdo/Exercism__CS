using System;
using System.Linq;

public enum Classification { Perfect,Abundant, Deficient }

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(number, 1);

        var sum = Enumerable.Range(1, number - 1).Where(x => number % x == 0).Sum();
        return sum == number ? Classification.Perfect :
            sum > number ? Classification.Abundant : Classification.Deficient;
    }
}