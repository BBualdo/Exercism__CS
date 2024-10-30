using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    private IList<string> _students =
        ["Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"];
    public string FirstRow { get; set; }
    public string SecondRow { get; set; }
    public KindergartenGarden(string diagram)
    {
        var rows = diagram.Split('\n');
        FirstRow = rows[0];
        SecondRow = rows[1];
    }

    public IEnumerable<Plant> Plants(string student)
    {
        var plants = new List<char>();
        int plantsToSkip = 0;
        foreach (var s in _students)
        {
            if (s == student) break;
            plantsToSkip += 2;
        }

        plants.AddRange([
            FirstRow[0 + plantsToSkip], FirstRow[1 + plantsToSkip], SecondRow[0 + plantsToSkip],
            SecondRow[1 + plantsToSkip]
        ]);

        foreach (var plant in plants)
        {
            yield return plant switch
            {
                'V' => Plant.Violets,
                'G' => Plant.Grass,
                'C' => Plant.Clover,
                _ => Plant.Radishes
            };
        }
    }
}