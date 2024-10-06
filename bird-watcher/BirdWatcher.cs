using System;
using System.Linq;

class BirdCount
{
    private int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        _birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];
    public int Today() => _birdsPerDay[^1];
    public void IncrementTodaysCount() => _birdsPerDay[^1]++;
    public bool HasDayWithoutBirds() => _birdsPerDay.Any(birds => birds == 0);
    public int CountForFirstDays(int numberOfDays)
    {
        var sum = 0;
        for (var i = 0; i < numberOfDays; i++)
        {
            sum += _birdsPerDay[i];
        }
        return sum;
    }
    public int BusyDays() => _birdsPerDay.Count(birds => birds >= 5);
}
