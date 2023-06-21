using System.Xml.Linq;

public class Bulbasaur : Pokemon
{
    public Bulbasaur() : base("Bulbasaur", PokemonType.Grass, PokemonType.Fire)
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Bulbasaur!");
    }
}                                                                                                                                                                                               