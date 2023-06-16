
namespace Pokemon_Simulator_OOP
{
    class Battle 
    {
        public Battle() 
        {
        }

        public Gamestate battle(Pokemon pokemon1, Pokemon pokemon2)
        {
            if (pokemon1.weakness == pokemon2.strength)
            {
                Console.WriteLine(pokemon2 + " wins!");
                return Gamestate.Trainer2;
            }

            else if (pokemon2.weakness == pokemon1.strength)
            {
                Console.WriteLine(pokemon1 + " wins!");
                return Gamestate.Trainer1;
            }

            else
            {
                Console.WriteLine("Draw!");
                return Gamestate.Draw;
            }
        }
    }
}
