using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        var matrix = new int[size, size];

        var top = 0;
        var left = 0;
        var right = size - 1;
        var bottom = size - 1;

        var currentNumber = 1;

        while (currentNumber <= size * size)
        {
            for (var i = left; i <= right; i++)
            {
                matrix[top, i] = currentNumber++;
            }
            top++;

            for (var i = top; i <= bottom; i++)
            {
                matrix[i, right] = currentNumber++;
            }
            right--;

            for (var i = right; i >= left; i--)
            {
                matrix[bottom, i] = currentNumber++;
            }
            bottom--;

            for (var i = bottom; i >= top; i--)
            {
                matrix[i, left] = currentNumber++;
            }
            left++;
        }
        
        return matrix;
    }
}
