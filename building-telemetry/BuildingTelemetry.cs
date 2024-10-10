public class RemoteControlCar
{
    private int batteryPercentage = 100;
    private int distanceDrivenInMeters;
    private string[] sponsors = new string[0];
    private int latestSerialNum;

    public void Drive()
    {
        if (batteryPercentage <= 0) return;
        batteryPercentage -= 10;
        distanceDrivenInMeters += 2;
    }

    public void SetSponsors(params string[] sponsors) => this.sponsors = sponsors;

    public string DisplaySponsor(int sponsorNum) => sponsors[sponsorNum];

    public bool GetTelemetryData(ref int serialNum,
        out int batteryPercentage, out int distanceDrivenInMeters)
    {
        if (serialNum < latestSerialNum)
        {
            batteryPercentage = -1;
            distanceDrivenInMeters = - 1;
            serialNum = latestSerialNum;
            return false;
        }

        latestSerialNum = serialNum;
        batteryPercentage = this.batteryPercentage;
        distanceDrivenInMeters = this.distanceDrivenInMeters;
        return true;
    }

    public static RemoteControlCar Buy() => new();
    
}

public class TelemetryClient(RemoteControlCar car)
{
    public string GetBatteryUsagePerMeter(int serialNum)
    {
        if (!car.GetTelemetryData(ref serialNum, out int batteryPercentage, out int distanceDrivenInMeters) || distanceDrivenInMeters == 0)
            return "no data";
        
        return $"usage-per-meter={(100 - batteryPercentage) / distanceDrivenInMeters}";
    }
}
