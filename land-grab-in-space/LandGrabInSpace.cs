using System;
using System.Collections.Generic;

public struct Coord(ushort x, ushort y)
{
    public ushort X { get; } = x;
    public ushort Y { get; } = y;
}

public struct Plot(Coord a, Coord b, Coord c, Coord d)
{
    public Coord A { get; set; } = a;
    public Coord B { get; set; } = b;
    public Coord C { get; set; } = c;
    public Coord D { get; set; } = d;

    public double CalculateDistance(Coord a, Coord b) => Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    
    public double GetLongestSide()
    {
        double side1 = CalculateDistance(A, B);
        double side2 = CalculateDistance(A, C);
        double side3 = CalculateDistance(C, D);
        double side4 = CalculateDistance(B, D);

        return Math.Max(Math.Max(side1, side2), Math.Max(side3, side4));
    }
}


public class ClaimsHandler
{
    private List<Plot> StakeClaims = [];
    public void StakeClaim(Plot plot) => StakeClaims.Add(plot);

    public bool IsClaimStaked(Plot plot) => StakeClaims.Contains(plot);

    public bool IsLastClaim(Plot plot) => plot.Equals(StakeClaims[^1]);

    public Plot GetClaimWithLongestSide()
    {
        Plot maxPlot = StakeClaims[0];
        double maxSideLength = maxPlot.GetLongestSide();

        foreach (var plot in StakeClaims)
        {
            double plotMaxSide = plot.GetLongestSide();
            if (!(plotMaxSide > maxSideLength)) continue;
            maxSideLength = plotMaxSide;
            maxPlot = plot;
        }

        return maxPlot;
    }
}
