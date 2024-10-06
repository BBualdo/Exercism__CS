using System;
using System.Linq;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        (bool isNewYork, bool isFake, string localNumber) results = (false, false, "");

        if (phoneNumber[..3].Contains("212")) results.isNewYork = true;
        if (phoneNumber.Substring(4, 3).Contains("555")) results.isFake = true;
        results.localNumber = phoneNumber[8..];
        return results;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumber) => phoneNumber.IsFake;
}
