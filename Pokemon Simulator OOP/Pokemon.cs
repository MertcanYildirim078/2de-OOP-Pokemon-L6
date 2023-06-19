/*abstract om het alleen te kunnen gebruiken met sub classes*/
public abstract class Pokemon
{
    private readonly string name;
    private readonly string strength;
    private readonly string weakness;

    public string Name
    {
        get { return name; }
    }

    public string Strength
    {
        get { return strength; }
    }

    public string Weakness
    {
        get { return weakness; }
    }

    public Pokemon(string name, string strength, string weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }

    public abstract void BattleCry();
}


/*  abstract  om bij de subclasses te kunnen gebruiken soort van functie*/