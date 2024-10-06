class RemoteControlCar
{
    private int _distanceDriven { get; set; }
    private int _batteryLeft { get; set; } = 100;
    public static RemoteControlCar Buy() => new();
    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";
    public string BatteryDisplay() => _batteryLeft == 0 ? "Battery empty" : $"Battery at {_batteryLeft}%";
    public void Drive()
    {
        if (_batteryLeft == 0) return;
        
        _distanceDriven += 20;
        _batteryLeft--;
    }
}
