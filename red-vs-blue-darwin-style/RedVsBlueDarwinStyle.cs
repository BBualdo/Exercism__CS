using BlueRemoteControlCarTeam;

namespace RedRemoteControlCarTeam
{
    public class RemoteControlCar
    {
        public RemoteControlCar(Motor motor, Chassis chassis, Telemetry telemetry, RunningGear runningGear)
        {
        }
        // red members and API
    }

    public class RunningGear
    {
        // red members and API
    }

    public class Telemetry
    {
        // red members and API
    }

    public class Chassis
    {
        // red members and API
    }

    public class Motor
    {
        // red members and API
    }
}

namespace BlueRemoteControlCarTeam
{
    public class RemoteControlCar
    {
        public RemoteControlCar(Motor motor, Chassis chassis, Telemetry telemetry)
        {
        }
        // blue members and API
    }

    public class Telemetry
    {
        // blue members and API
    }

    public class Chassis
    {
        // blue members and API
    }

    public class Motor
    {
        // blue members and API
    }
}

namespace Combined
{
    using Red = RedRemoteControlCarTeam;

    public static class CarBuilder
    {
        public static Red.RemoteControlCar BuildRed() => new(
                new Red.Motor(),
                new Red.Chassis(),
                new Red.Telemetry(),
                new Red.RunningGear()
            );
        

        public static RemoteControlCar BuildBlue() => new(
                new Motor(),
                new Chassis(),
                new Telemetry()
            );
    }
}