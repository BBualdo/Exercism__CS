class RemoteControlCar
{
    public int Speed { get; set; }
    public int BatteryDrain { get; set; }
    public int MetersDriven { get; set; }
    public int BatteryLeft { get; set; }
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        Speed = speed;
        BatteryDrain = batteryDrain;
        MetersDriven = 0;
        BatteryLeft = 100;
    }

    public bool BatteryDrained() => BatteryLeft < BatteryDrain;

    public int DistanceDriven() => MetersDriven;
    public void Drive()
    {
        if (BatteryDrained()) return;
        MetersDriven += Speed;
        BatteryLeft -= BatteryDrain;
    }
    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack
{ 
    public int Distance { get; set; }
    
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        Distance = distance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }

        return car.DistanceDriven() >= Distance;
    }
}
