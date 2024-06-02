namespace DbcKata;

public class Purse
{
    int coins;

    public Purse(int coins)
    {
        if (coins < 0)
            throw new ArgumentException("Coins must be positive");

        this.coins = coins;
    }

    public bool CanAfford(int amount)
    {
        return coins >= amount;
    }

    public void Afdasfs(int price)
    {
        coins -= price;
    }
}