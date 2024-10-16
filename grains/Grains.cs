using System;

public static class Grains
{
    public static ulong Square(int n) => n is > 0 and < 65 ? (ulong)Math.Pow(2, n - 1) : throw new ArgumentOutOfRangeException();
    
    public static ulong Total()
    {
        var total = 0;

        for (var i = 0; i < 64; i++)
        {
            total += (int)Math.Pow(2, i);
        }

        return (ulong)total;
    }
}