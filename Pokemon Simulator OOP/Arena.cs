using Pokemon_Simulator_OOP;
using System.ComponentModel;
using System.Threading;

class Arena
{
    private Trainer trainer1;
    private Trainer trainer2;

    private int currentPokemon1 = 0;
    private int currentPokemon2 = 0;

    private Gamestate result = Gamestate.Draw;

/*    Propertys zijn ook getters en setters en gebruikt het automatische manual is 
        
    private string name

    public string name {
    
    return this.name;
}
 
 */
    public Trainer Trainer1
    {
        get { return trainer1; }
        set { trainer1 = value; }
    }

    public Trainer Trainer2
    {
        get { return trainer2; }
        set { trainer2 = value; }
    }

    public int CurrentPokemon1
    {
        get { return currentPokemon1; }
        set { currentPokemon1 = value; }
    }

    public int CurrentPokemon2
    {
        get { return currentPokemon2; }
        set { currentPokemon2 = value; }
    }

    public Gamestate Result
    {
        get { return result; }
        set { result = value; }
    }

    public Arena(Trainer trainer1, Trainer trainer2)
    {
        this.trainer1 = trainer1;
        this.trainer2 = trainer2;
    }

    public void ArenaBattle()
    {
        Trainer.Shuffle(trainer1.belt);
        Trainer.Shuffle(trainer2.belt);

        int stopBattle = 0;
        while (stopBattle == 0)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"{trainer1.name}'s pokemon: {trainer1.belt[CurrentPokemon1].Pokemon}");
            Console.WriteLine("");
            Console.WriteLine($"{trainer2.name}'s pokemon: {trainer2.belt[CurrentPokemon2].Pokemon}");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------");

            Battle battle = new Battle();
            Result = battle.battle(trainer1.belt[CurrentPokemon1].Pokemon, trainer2.belt[CurrentPokemon2].Pokemon);
            Thread.Sleep(2000);

            if (Result == Gamestate.Draw)
            {
                CurrentPokemon1++;
                CurrentPokemon2++;
            }
            else if (Result == Gamestate.Trainer2)
            {
                CurrentPokemon2++;
            }
            else
            {
                CurrentPokemon1++;
            }

            if (Trainer1.belt.Count <= CurrentPokemon1 || trainer2.belt.Count <= CurrentPokemon2)
            {
                stopBattle = 1;
            }
        }
    }
}
