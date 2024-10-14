using System.Collections.Generic;
using System.Linq;

public class HighScores(List<int> list)
{
    private List<int> ScoresList { get; set; } = list;

    public List<int> Scores() => ScoresList;
    public int Latest() => ScoresList.Last();
    public int PersonalBest() => ScoresList.Max();
    public List<int> PersonalTopThree() => ScoresList.OrderDescending().Take(3).ToList();
}