
public class Squirtle : Pokemon
{
    public Squirtle() : base("Squirtle", "Water", "Grass")
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Squirtle!");
    }
}