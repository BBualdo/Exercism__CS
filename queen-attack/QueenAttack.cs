using System;

public class Queen(int row, int column)
{
    public int Row { get; } = row;
    public int Column { get; } = column;
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        if (white.Column == black.Column || white.Row == black.Row) return true;
        if (Math.Abs(white.Column - black.Column) == Math.Abs(white.Row - black.Row)) return true;
        return false;
    }

    public static Queen Create(int row, int column) => row is >= 0 and <= 7 && column is >= 0 and <= 7 ? new Queen(row, column) : throw new ArgumentOutOfRangeException();
}