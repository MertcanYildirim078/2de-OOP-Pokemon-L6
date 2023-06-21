
public class Squirtle : Pokemon
{
    public Squirtle() : base("Squirtle", PokemonType.Water, PokemonType.Grass)
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Squirtle!");
    }
}