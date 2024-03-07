namespace pokemonbattlesimulator;
public class Charmander
{
    public string? nickname;
    public string strength = "fire";
    public string weakness = "water";

    public string getname()
    {
        return nickname;
    }

    public string battlecry()
    {
        string battlecry = this.nickname+"!!!!!!";
        return battlecry.ToUpper();
    }

    public Charmander(string nickname, string strength, string weakness)
    {
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
    }
}