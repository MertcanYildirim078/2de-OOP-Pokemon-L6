
public class Charmander : Pokemon
{
    public Charmander() : base("Charmander", "Fire", "Water")
    {
    }
    public override void BattleCry()
    {
        Console.WriteLine("Charmander!");
    }

}
