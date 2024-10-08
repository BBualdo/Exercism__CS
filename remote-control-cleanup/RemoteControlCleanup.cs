public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }

    private Speed currentSpeed;
    
    public TelemetryClass Telemetry { get; }

    public RemoteControlCar() => Telemetry = new TelemetryClass(this);
    
    public class TelemetryClass
    {
        private readonly RemoteControlCar _car;

        internal TelemetryClass(RemoteControlCar car) => _car = car;
        
        public void Calibrate(){}

        public bool SelfTest() => true;

        public void ShowSponsor(string sponsorName) => _car.SetSponsor(sponsorName);
        
        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps")
                speedUnits = SpeedUnits.CentimetersPerSecond;
            
            _car.SetSpeed(new Speed(amount, speedUnits));
        }
    }
    
    private struct Speed(decimal amount, SpeedUnits speedUnits)
    {
        public decimal Amount { get; } = amount;
        public SpeedUnits SpeedUnits { get; } = speedUnits;

        public override string ToString()
        {
            string unitsString = "meters per second";
            if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
            {
                unitsString = "centimeters per second";
            }

            return $"{Amount} {unitsString}";
        }
    }
    
    private enum SpeedUnits { MetersPerSecond, CentimetersPerSecond }
    
    public string GetSpeed() => currentSpeed.ToString();
    
    private void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;

    private void SetSpeed(Speed speed) => currentSpeed = speed;
}