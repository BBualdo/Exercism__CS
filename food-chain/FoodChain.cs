using System.Collections.Generic;
using System.Text;

public static class FoodChain
{
    private static readonly Dictionary<int, string> _verses = new()
    {
        [1] = "I know an old lady who swallowed a fly.\nI don't know why she swallowed the fly. Perhaps she'll die.",
        [2] =
            "I know an old lady who swallowed a spider.\nIt wriggled and jiggled and tickled inside her.\nShe swallowed the spider to catch the fly.\nI don't know why she swallowed the fly. Perhaps she'll die.",
        [3] =
            "I know an old lady who swallowed a bird.\nHow absurd to swallow a bird!\nShe swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\nShe swallowed the spider to catch the fly.\nI don't know why she swallowed the fly. Perhaps she'll die.",
        [4] =
            "I know an old lady who swallowed a cat.\nImagine that, to swallow a cat!\nShe swallowed the cat to catch the bird.\nShe swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\nShe swallowed the spider to catch the fly.\nI don't know why she swallowed the fly. Perhaps she'll die.",
        [5] =
            "I know an old lady who swallowed a dog.\nWhat a hog, to swallow a dog!\nShe swallowed the dog to catch the cat.\nShe swallowed the cat to catch the bird.\nShe swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\nShe swallowed the spider to catch the fly.\nI don't know why she swallowed the fly. Perhaps she'll die.",
        [6] =
            "I know an old lady who swallowed a goat.\nJust opened her throat and swallowed a goat!\nShe swallowed the goat to catch the dog.\nShe swallowed the dog to catch the cat.\nShe swallowed the cat to catch the bird.\nShe swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\nShe swallowed the spider to catch the fly.\nI don't know why she swallowed the fly. Perhaps she'll die.",
        [7] =
            "I know an old lady who swallowed a cow.\nI don't know how she swallowed a cow!\nShe swallowed the cow to catch the goat.\nShe swallowed the goat to catch the dog.\nShe swallowed the dog to catch the cat.\nShe swallowed the cat to catch the bird.\nShe swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\nShe swallowed the spider to catch the fly.\nI don't know why she swallowed the fly. Perhaps she'll die.",
        [8] = "I know an old lady who swallowed a horse.\nShe's dead, of course!"
    };

    public static string Recite(int verseNumber) => _verses[verseNumber];

    public static string Recite(int startVerse, int endVerse)
    {
        var result = new StringBuilder();

        for (var i = startVerse; i <= endVerse; i++)
        {
            result.Append(_verses[i]);
            result.Append('\n');
            result.Append('\n');
        }

        return result.ToString().Trim();
    }
}