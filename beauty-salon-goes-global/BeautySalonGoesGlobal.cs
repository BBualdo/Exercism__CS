using System;
using System.Globalization;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location) =>
        TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription),
            TimeZoneInfo.FindSystemTimeZoneById(GetTimeZoneId(location)));
   

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => alertLevel switch
    {
        AlertLevel.Early => appointment.AddDays(-1),
        AlertLevel.Standard => appointment.AddHours(-1).AddMinutes(-45),
        AlertLevel.Late => appointment.AddMinutes(-30),
        _ => throw new ArgumentOutOfRangeException()
    };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timezone = TimeZoneInfo.FindSystemTimeZoneById(GetTimeZoneId(location));
        
        for (int i = 0; i < 7; i++)
        {
            if (timezone.IsDaylightSavingTime(dt.AddDays(-i))) return true;
        }

        return false;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        var culture = location switch
        {
            Location.NewYork => new CultureInfo("en-US"),
            Location.London => new CultureInfo("en-GB"),
            Location.Paris => new CultureInfo("fr-FR"),
            _ => throw new ArgumentOutOfRangeException()
        };

        return DateTime.TryParse(dtStr, culture, DateTimeStyles.None, out var result) 
            ? result 
            : new DateTime(1, 1, 1, 0, 0, 0);
    }

    private static string GetTimeZoneId(Location location) => location switch
    {
        Location.NewYork => OperatingSystem.IsWindows() ? "Eastern Standard Time" : "America/New_York",
        Location.London => OperatingSystem.IsWindows() ? "GMT Standard Time" : "Europe/London",
        Location.Paris => OperatingSystem.IsWindows() ? "W. Europe Standard Time" : "Europe/Paris",
        _ => throw new ArgumentOutOfRangeException()
    };
}
