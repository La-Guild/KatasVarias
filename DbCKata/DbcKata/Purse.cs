namespace DbcKata;

public class Purse
{
    Positive coins;

    public Purse(Positive coins)
    {
        this.coins = coins;
    }

    public bool CanAfford(Positive amount)
    {
        return coins >= amount;
    }

    public void Afdasfs(Positive price)
    {
        coins -= price;
    }
}