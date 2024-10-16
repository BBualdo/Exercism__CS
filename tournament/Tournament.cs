using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public static class Tournament
{
    public static void Tally(Stream inStream, Stream outStream)
    {
        List<Team> teams = [];
        
        var builder = new StringBuilder();
        builder.Append("Team                           | MP |  W |  D |  L |  P");
        StreamReader reader = new StreamReader(inStream);
        var rows = reader.ReadToEnd().Split('\n');

        foreach (var row in rows.Where(row => !string.IsNullOrEmpty(row)))
        {
            var teamsAndResult = row.Split(';');

            Team team1 = GetOrCreateTeam(teams, teamsAndResult[0]);
            Team team2 = GetOrCreateTeam(teams, teamsAndResult[1]);
            
            var result = teamsAndResult[2];

            if (result == "win")
            {
                team1.WonMatch();
                team2.LostMatch();
            }
            else if (result == "loss")
            {
                team1.LostMatch();
                team2.WonMatch();
            }
            else
            {
                team1.DrawnMatch();
                team2.DrawnMatch();
            }
        }

        if (teams.Count > 0)
        {
            teams = teams.OrderByDescending(t => t.Points).ThenBy(t => t.Name).ToList();

            foreach (var team in teams)
            {
                builder.Append($"\n{team}");
            }
        }
        
        outStream.Write(Encoding.UTF8.GetBytes(builder.ToString()), 0, builder.ToString().Length);
    }

    private static Team GetOrCreateTeam(List<Team> teams, string name)
    {
        var team = teams.FirstOrDefault(t => t.Name == name) ?? new Team(name);
        if (!teams.Contains(team)) teams.Add(team);

        return team;
    }
}

public class Team(string name)
{
    public string Name { get; set; } = name;
    public int MatchesPlayed { get; set; }
    public int Wins { get; set; }
    public int Draws { get; set; }
    public int Losses { get; set; }
    public int Points { get; set; }

    public void WonMatch()
    {
        MatchesPlayed++;
        Wins++;
        Points += 3;
    }

    public void DrawnMatch()
    {
        MatchesPlayed++;
        Draws++;
        Points++;
    }

    public void LostMatch()
    {
        MatchesPlayed++;
        Losses++;
    }

    public override string ToString() => $"{Name,-30} |  {MatchesPlayed} |  {Wins} |  {Draws} |  {Losses} |{Points, 3}";
}
