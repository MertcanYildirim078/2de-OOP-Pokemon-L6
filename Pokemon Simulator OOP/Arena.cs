
using Pokemon_Simulator_OOP;

class Arena
{
    private Trainer trainer1;
    private Trainer trainer2;

    private int currentPokemon1 = 0;
    private int currentPokemon2 = 0;

    private Gamestate Result = Gamestate.Draw;
    public Arena(Trainer trainer1, Trainer trainer2)
    {
        this.trainer1 = trainer1;
        this.trainer2 = trainer2;
    }

    public void arenaBattle()
    {
        int stopBattle = 0;
        while (stopBattle == 0)
        {
            Battle battle = new Battle();
            Result = battle.battle(trainer1.belt[currentPokemon1].pokemon, trainer2.belt[currentPokemon2].pokemon);
            Thread.Sleep(2000);
            if (Result == Gamestate.Draw)
            {
                currentPokemon1++;
                currentPokemon2++;
            }

            else if (Result == Gamestate.Trainer2)
            {
                currentPokemon2++;
            }

            else
            {
                currentPokemon1++;
            }

            if (trainer1.belt.Count <= currentPokemon1)
            {
                stopBattle = 1;
            }
            
            else if (trainer2.belt.Count <= currentPokemon2)
            {
                stopBattle = 1;
            }

        }
    }
}

