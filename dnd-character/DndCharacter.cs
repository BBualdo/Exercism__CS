using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class DndCharacter
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int Hitpoints { get; private set; }

    public static int Modifier(int score) => (int)Math.Floor((decimal)(score - 10) / 2);

    public static int Ability()
    {
        Random rng = new();
        var character = Generate();
        PropertyInfo[] properties = typeof(DndCharacter).GetProperties();
        return Convert.ToInt32(properties[rng.Next(0, 7)].GetValue(character));
    }

    public static DndCharacter Generate()
    {
        Random rng = new();
        DndCharacter character = new()
        {
            Strength = RollAndSum(rng),
            Dexterity = RollAndSum(rng),
            Constitution = RollAndSum(rng),
            Intelligence = RollAndSum(rng),
            Wisdom = RollAndSum(rng),
            Charisma = RollAndSum(rng),
        };
        character.Hitpoints = 10 + Modifier(character.Constitution);
        
        return character;
    }

    private static int RollAndSum(Random rng)
    {
        List<int> results = [rng.Next(1, 7), rng.Next(1, 7), rng.Next(1, 7), rng.Next(1, 7)];
        return results.OrderDescending().Take(3).Sum();
    }
}
