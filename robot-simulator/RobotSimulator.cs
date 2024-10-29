public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator(Direction direction, int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public Direction Direction
    {
        get => direction;
        private set =>
            direction = (int)value switch
            {
                > 3 => Direction.North,
                < 0 => Direction.West,
                _ => value
            };
    }

    public void Move(string instructions)
    {
        foreach (var cmd in instructions)
        {
            if (cmd == 'R')
            {
                Direction++;
            }
            else if (cmd == 'L') Direction--;
            else Advance();
        }
    }

    private void Advance()
    {
        switch (Direction)
        {
            case Direction.North:
                Y++;
                break;
            case Direction.South:
                Y--;
                break;
            case Direction.East:
                X++;
                break;
            case Direction.West:
                X--;
                break;
        }
    }
}