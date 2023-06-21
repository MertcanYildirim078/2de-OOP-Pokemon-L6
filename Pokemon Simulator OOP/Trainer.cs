using System;
using System.Collections.Generic;

class Trainer
{
    private string name;
    private List<Pokeball> belt = new List<Pokeball>();

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Pokeball> Belt
    {
        get { return belt; }
    }

    public Trainer(string name)
    {
        this.name = name;
    }

    public void addPokeball(Pokeball pokeball)
    {
        if (belt.Count < 6)
        {
            belt.Add(pokeball);
        }
        else
        {
            throw new Exception("The trainer's belt is already full. Cannot add more pokeballs.");
        }
    }

    public static void Shuffle<T>(List<T> list)
    {
        Random random = new Random();

        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
