using System;
using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        string result = $"{studentA} \u2661 {studentB}";
        var remainingSpaces = 61 - result.Length;
        return result.PadLeft(result.Length + remainingSpaces / 2 - 1).PadRight(61);
    }

    public static string DisplayBanner(string studentA, string studentB) =>
        $"""
             
                  ******       ******
                **      **   **      **
              **         ** **         **
             **            *            **
             **                         **
             **     {studentA} +  {studentB}    **
              **                       **
                **                   **
                  **               **
                    **           **
                      **       **
                        **   **
                          ***
                           *

             """;


    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours) =>
        $"{studentA} and {studentB} have been dating since {start:dd.MM.yyyy} - that's {hours.ToString("N2", new CultureInfo("de-DE") )} hours";
}
