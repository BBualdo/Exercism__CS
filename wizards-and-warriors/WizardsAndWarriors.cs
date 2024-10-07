using System;

abstract class Character
{
    public string CharacterType { get; set; }
    protected Character(string characterType)
    {
        CharacterType = characterType;
    }

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {CharacterType}";
}

class Warrior() : Character("Warrior")
{
    public virtual int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard() : Character("Wizard")
{
    public bool HasPreparedSpell { get; set; }
    public virtual int DamagePoints(Character target) => HasPreparedSpell ? 12 : 3;
    public override bool Vulnerable() => !HasPreparedSpell;
    public void PrepareSpell() => HasPreparedSpell = true;
}
