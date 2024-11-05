using System;
using System.Collections.Generic;

public class Matrix
{
    private readonly List<List<int>> _matrix;
    public Matrix(string input)
    {
        var matrix = new List<List<int>>();
        var rows = input.Split('\n');

        for (var i = 0; i < rows.Length; i++)
        {
            var numsInRow = rows[i].Split(' ');
            matrix.Add(new List<int>());
            
            foreach (var t in numsInRow)
                matrix[i].Add(int.Parse(t));
        }

        _matrix = matrix;
    }

    public int[] Row(int row) => _matrix[row - 1].ToArray();
    
    public IEnumerable<int> Column(int col)
    {
        foreach (var rowList in _matrix)
            yield return rowList[col - 1];
    }
}