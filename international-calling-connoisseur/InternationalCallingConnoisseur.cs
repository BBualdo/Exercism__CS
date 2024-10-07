using System.Collections.Generic;
using System.Linq;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => [];
    public static Dictionary<int, string> GetExistingDictionary() => new()
    {
        { 1, "United States of America" },
        { 55, "Brazil" },
        { 91, "India" }
    };
    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName) => new()
    {
        {countryCode, countryName}
    };
    
    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }
    
    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (!CheckCodeExists(existingDictionary, countryCode)) return string.Empty;
        return existingDictionary[countryCode];
    }
    
    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) =>
        existingDictionary.ContainsKey(countryCode);
    
    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (!CheckCodeExists(existingDictionary, countryCode)) return existingDictionary;
        existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }
    
    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        if (existingDictionary.Count == 0) return string.Empty;
        int count = 0;
        foreach (var kvp in existingDictionary)
        {
            if (kvp.Value.Length > count)
                count = kvp.Value.Length;
        }

        return existingDictionary.First(kvp => kvp.Value.Length == count).Value;
    }
}