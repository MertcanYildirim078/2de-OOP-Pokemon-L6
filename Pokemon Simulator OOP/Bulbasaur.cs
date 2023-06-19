using System.Xml.Linq;

public class Bulbasaur : Pokemon
{
    public Bulbasaur() : base("Bulbasaur", "Grass", "Fire")
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Bulbasaur!");
    }
}                                                                                                                                                                                               