public class Charmander : Pokemon
{
    public Charmander() : base("Charmander", PokemonType.Fire, PokemonType.Water)
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Charmander!");
    }
}