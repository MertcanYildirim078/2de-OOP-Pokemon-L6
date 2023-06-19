﻿
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
                Console.WriteLine("");
                Console.WriteLine(pokemon2 + " wins! (Trainer 2)");
                Console.WriteLine("");
                return Gamestate.Trainer2;
            }

            else if (pokemon2.weakness == pokemon1.strength)
            {
                Console.WriteLine("");
                Console.WriteLine(pokemon1 + " wins! (Trainer 1)");
                Console.WriteLine("");
                return Gamestate.Trainer1;
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Draw!");
                Console.WriteLine("");
                return Gamestate.Draw;
            }
        }
    }
}
