
class Pokeball
{
    public bool empty;
    public bool open;
    public Pokemon pokemon;

    public Pokeball(Pokemon pokemon)
    {
        this.empty = false;
        this.open = false;
        this.pokemon = pokemon;
    }
}