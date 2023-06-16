/*abstract om het alleen te kunnen gebruiken met sub classes*/
public abstract class Pokemon
{
    public string name;
    public string strength;
    public string weakness;

    public Pokemon(string name, string strength, string weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }

    public abstract void BattleCry();

  /*  abstract  om bij de subclasses te kunnen gebruiken soort van functie*/

}