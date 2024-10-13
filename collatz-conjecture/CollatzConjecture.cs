using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(number, 1);
        var steps = 0;
        while (number != 1)
        {
            steps++;
            if (number % 2 == 0) number /= 2;
            else number = number * 3 + 1;
        } 
        
        return steps;
    }
}