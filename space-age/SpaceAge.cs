public class SpaceAge(int seconds)
{
    private double _days { get; set; } = (double)seconds / 60 / 60 / 24;
    private const double _earthYear = 365.25;

    public double OnEarth() => _days / _earthYear;
    public double OnMercury() => _days / (_earthYear * 0.2408467);
    public double OnVenus() => _days / (_earthYear * 0.61519726);
    public double OnMars() => _days / (_earthYear * 1.8808158);
    public double OnJupiter() => _days / (_earthYear * 11.862615);
    public double OnSaturn() => _days / (_earthYear * 29.447498);
    public double OnUranus() => _days / (_earthYear * 84.016846);
    public double OnNeptune() => _days / (_earthYear * 164.79132);
}