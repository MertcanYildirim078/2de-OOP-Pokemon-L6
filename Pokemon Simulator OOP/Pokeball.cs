class Pokeball
{
    private bool empty;
    private bool open;
    private readonly Pokemon pokemon;

    public bool Empty
    {
        get { return empty; }
        set { empty = value; }
    }

    public bool Open
    {
        get { return open; }
        set { open = value; }
    }

    public Pokemon Pokemon
    {
        get { return pokemon; }
    }

    public Pokeball(Pokemon pokemon)
    {
        Empty = false;
        Open = false;
        this.pokemon = pokemon;
    }
}
