abstract class Character
{
    protected string CharacterType {get;set;}
    protected Character(string characterType)
    {
        CharacterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {CharacterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard : Character
{
    private bool SpellPrepared {get;set;}
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        return SpellPrepared ? 12 : 3;
    }

    public override bool Vulnerable() {
        return !SpellPrepared;
    }
    
    public void PrepareSpell()
    {
        SpellPrepared = true;
    }
}
