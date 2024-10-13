using System;

public class Clock
{
    private int _hours { get; }
    private int _minutes { get; }
    public Clock(int hours, int minutes)
    {
        _minutes = (minutes % 60 + 60) % 60;
        var additionalHours = (int)Math.Floor((double)minutes / 60);
        _hours = ((hours + additionalHours) % 24 + 24) % 24;
    }

    public Clock Add(int minutesToAdd) => new(_hours, _minutes + minutesToAdd);
    public Clock Subtract(int minutesToSubtract) => new(_hours, _minutes - minutesToSubtract);
    
    public override string ToString() => $"{_hours:D2}:{_minutes:D2}";

    public override bool Equals(object obj)
    {
        if (obj is not Clock) return false;
        return GetHashCode() == obj.GetHashCode();
    }
    
    public override int GetHashCode() => (_hours, _minutes).GetHashCode();
}
