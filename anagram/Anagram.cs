using System.Linq;

public class Anagram(string baseWord)
{
    private string _baseWord { get; set; } = baseWord;

    public string[] FindAnagrams(string[] potentialMatches)
    {
        var sortedBaseWord = SortLetters(_baseWord);

        return potentialMatches
            .Where(str => str.ToLower() != _baseWord.ToLower() && SortLetters(str) == sortedBaseWord).ToArray();
    }

    private string SortLetters(string input) => string.Concat(input.ToLower().OrderBy(c => c));
}