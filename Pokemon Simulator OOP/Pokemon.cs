/*abstract om het alleen te kunnen gebruiken met sub classes*/
public abstract class Pokemon
{
    public enum PokemonType
    {
       Fire,
       Water,
       Grass
    }

    private readonly string name;
    private readonly PokemonType strength;
    private readonly PokemonType weakness;
    public string Name
    {
        get { return name; }
    }

    public PokemonType Strength
    {
        get { return strength; }
    }

    public PokemonType Weakness
    {
        get { return weakness; }
    }

    public Pokemon(string name, PokemonType strength, PokemonType weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }

    public abstract void BattleCry();
}


/*  abstract  om bij de subclasses te kunnen gebruiken soort van functie*/