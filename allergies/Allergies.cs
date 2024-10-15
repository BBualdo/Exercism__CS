using System;
using System.Collections.Generic;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate =  32,
    Pollen = 64,
    Cats = 128
}

public class Allergies(int mask)
{
    private int Mask { get; set; } = mask;

    public bool IsAllergicTo(Allergen allergen) => (Mask & (int)allergen) != 0;

    public Allergen[] List()
    {
        var list = new List<Allergen>();

        foreach (var allergen in Enum.GetValues<Allergen>())
        {
            if (IsAllergicTo(allergen)) list.Add(allergen);
        }

        return list.ToArray();
    }
}