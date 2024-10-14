using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(1, 2)) return 10;
        if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(5, 2)) return 5;
        if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(10, 2)) return 1;
        return 0;
    }
}
