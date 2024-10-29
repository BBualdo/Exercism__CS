using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var versesList = new List<string>();
        
        if (subjects.Length == 0) return versesList.ToArray();

        for (var i = 0; i <= subjects.Length - 2; i++)
        {
            versesList.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        }

        versesList.Add($"And all for the want of a {subjects[0]}.");

        return versesList.ToArray();
    }
}