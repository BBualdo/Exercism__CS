using System;

class WeighingMachine
{
    public int Precision { get; private set; }
    
    private double _weight;
    public double Weight
    {
        get => _weight;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _weight = value;
        }
    }
    
    public string DisplayWeight => $"{(_weight - TareAdjustment).ToString($"F{Precision}")} kg";
    
    public double TareAdjustment { get; set; } = 5;

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
}
