using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 10) return 0.77;
        if (speed == 9) return 0.8;
        if (speed is >= 5 and <= 8) return 0.9;
        if (speed is >= 1 and <= 4) return 1;
        return 0;
    }
    
    public static double ProductionRatePerHour(int speed) => 221 * speed * SuccessRate(speed);
    

    public static int WorkingItemsPerMinute(int speed) => (int)Math.Floor(ProductionRatePerHour(speed) / 60);
    
}
