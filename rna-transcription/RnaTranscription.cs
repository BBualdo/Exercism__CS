using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string strand) => string.Concat(strand.Select(Convert));
    
    private static char Convert(char c) => c switch
    {
        'G' => 'C',
        'C' => 'G',
        'T' => 'A',
        'A' => 'U'
    };
}