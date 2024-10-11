using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var filteredPhrase = string.Join("", phrase.Where(c => !char.IsSymbol(c)));
        var separatedWords = filteredPhrase.Split([' ', '-']);
        var result = "";
        foreach (var word in separatedWords)
        {
            if (word == "") continue;
            if (!char.IsLetter(word[0]))
            {
                result += word[1];
                continue;
            }
           
            result += word[0];
        }

        return result.ToUpper();
    }
}