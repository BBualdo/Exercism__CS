using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var sum = 0;
        for (var i = 1; i <= max; i++)
        {
            sum += i;
        }

        return (int)Math.Pow(sum, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        var sum = 0;
        for (var i = 1; i <= max; i++)
        {
            sum += (int)Math.Pow(i, 2);
        }

        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max) => Math.Abs(CalculateSumOfSquares(max) - CalculateSquareOfSum(max));
}