using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    private static Dictionary<string, string[]> _proteins = new()
    {
        ["Methionine"] = ["AUG"],
        ["Phenylalanine"] = ["UUU", "UUC"],
        ["Leucine"] = ["UUA", "UUG"],
        ["Serine"] = ["UCU", "UCC", "UCA", "UCG"],
        ["Tyrosine"] = ["UAU", "UAC"],
        ["Cysteine"] = ["UGU", "UGC"],
        ["Tryptophan"] = ["UGG"],
    };
    
    public static string[] Proteins(string strand)
    {
        var isolatedProteins = new List<string>();
        var isolatedCodons = IsolateCodons(strand);
        foreach (var codon in isolatedCodons)
        {
            if (codon is "UAA" or "UAG" or "UGA") break;
            var isolatedProtein = _proteins.FirstOrDefault(kvp => kvp.Value.Contains(codon)).Key;
            if (isolatedProtein is null) continue;
            isolatedProteins.Add(isolatedProtein);
        }

        return isolatedProteins.ToArray();
    }

    private static IEnumerable<string> IsolateCodons(string strand)
    {
        for (var i = 0; i < strand.Length; i += 3)
        {
            yield return strand.Substring(i, 3);
        }
    } 
}