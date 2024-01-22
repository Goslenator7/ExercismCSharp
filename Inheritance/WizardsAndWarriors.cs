using System;

abstract class Character
{
    protected string characterType;
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public abstract string ToString();
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable() == true)
        {
            return 10;
        }
        return 6;
    }

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}

class Wizard : Character
{
    private bool spellPrepared;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (spellPrepared == true)
        {
            return 12;
        }
        return 3;
    }

    public void PrepareSpell()
    {
        spellPrepared = true;
    }

    public override bool Vulnerable()
    {
        if (spellPrepared == false)
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}
