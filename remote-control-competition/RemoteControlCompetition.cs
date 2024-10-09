using System;
using System.Collections.Generic;
using System.Linq;

public interface IRemoteControlCar
{
    public int DistanceTravelled { get; set; }
    void Drive();
}

public class ProductionRemoteControlCar: IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; set; }
    public int NumberOfVictories { get; set; }

    public void Drive() => DistanceTravelled += 10;
    
    public int CompareTo(ProductionRemoteControlCar other) =>
        NumberOfVictories > other.NumberOfVictories ? 1 :
        NumberOfVictories < other.NumberOfVictories ? -1 : 0;
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; set; }

    public void Drive() => DistanceTravelled += 20;
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car) => car.Drive();
    
    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var list = new List<ProductionRemoteControlCar> { prc1, prc2 };
        return list.OrderBy(c => c.NumberOfVictories).ToList();
    }
}
