using Pokemon_Simulator_OOP;
using System;
using System.Collections.Generic;


/*
6 nieuwe pokemon
6 nieuwe pokeball
add to belt*/
/*   for Pokeball pokeball : trainer.getBelt())*/
/*    Dit al in je class zetten en aanroepen is innheritannce en de relatie tussen bijde is polyforphisme e en via superclass suclass te kunnnen gebruiken*/

int stop = 0;

while (stop == 0)
{
    Console.WriteLine("Choose a name for your first trainer: ");
    string askTrainerName = Console.ReadLine();

    Console.WriteLine("Choose a name for your second trainer: ");
    string askSecondTrainerName = Console.ReadLine();
    Console.WriteLine("");

    Trainer trainer = new Trainer(askTrainerName);
    Trainer trainer2 = new Trainer(askSecondTrainerName);

    Pokemon charMander1 = new Charmander();
    Pokemon Squirtle1 = new Squirtle();
    Pokemon Bulbasaur1 = new Bulbasaur();
    Pokemon charMander2 = new Charmander();
    Pokemon Squirtle2 = new Squirtle();
    Pokemon Bulbasaur2 = new Bulbasaur();

    Pokeball pokeball1 = new Pokeball(charMander1);
    Pokeball pokeball2 = new Pokeball(Squirtle1);
    Pokeball pokeball3 = new Pokeball(Bulbasaur1);
    Pokeball pokeball4 = new Pokeball(charMander2);
    Pokeball pokeball5 = new Pokeball(Squirtle2);
    Pokeball pokeball6 = new Pokeball(Bulbasaur2);

    trainer.addPokeball(pokeball1);
    trainer.addPokeball(pokeball2);
    trainer.addPokeball(pokeball3);
    trainer.addPokeball(pokeball4);
    trainer.addPokeball(pokeball5);
    trainer.addPokeball(pokeball6);

    trainer2.addPokeball(pokeball1);
    trainer2.addPokeball(pokeball2);
    trainer2.addPokeball(pokeball3);
    trainer2.addPokeball(pokeball4);
    trainer2.addPokeball(pokeball5);
    trainer2.addPokeball(pokeball6);

    Arena arena = new Arena(trainer, trainer2);

    arena.ArenaBattle();

    int stop2 = 0;

    while (stop2 == 0)
    {
        Console.WriteLine("Continue? (y/n)");
        string askToContinue = Console.ReadLine();

        if (askToContinue == "n")
        {
            stop = 1;
            stop2 = 1;
        }

        else if (askToContinue == "y")
        {
            stop2 = 1;
        }
        else
        {
            stop2 = 0;
        }
    }
}
