
using System.Xml.Linq;

class Trainer
{
    public string name;
    // has belt
    public List<Pokeball> belt = new List<Pokeball>();

    // add a pokeball to the belt
    public Trainer(string name)
    {
        this.name = name;
    }

    public void addPokeball(Pokeball pokeball)
    {
        belt.Add(pokeball);
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