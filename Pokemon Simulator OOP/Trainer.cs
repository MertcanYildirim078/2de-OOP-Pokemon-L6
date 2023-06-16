
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
}