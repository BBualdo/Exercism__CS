using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        var verses = new StringBuilder();
        var currentBottles = startBottles;
        while (currentBottles > startBottles - takeDown)
        {
            var noun = currentBottles == 1 ? "bottle" : "bottles";
            
            verses.Append($"{(currentBottles > 0 ? currentBottles : "No more")} {noun} of beer on the wall, {(currentBottles > 0 ? currentBottles : "no more")} {noun} of beer.\n");
            
            currentBottles--;
            
            noun = currentBottles == 1 ? "bottle" : "bottles";
            
            if (currentBottles < 0) verses.Append("Go to the store and buy some more, 99 bottles of beer on the wall.\n");
            else verses.Append($"Take {(currentBottles == 0 ? "it" : "one")} down and pass it around, {(currentBottles == 0 ? "no more" : currentBottles)} {noun} of beer on the wall.\n\n");
        }

        return verses.ToString().TrimEnd();
    }
}