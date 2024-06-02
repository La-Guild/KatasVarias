namespace DbcKata;

public class Purse
{
    private int coins;

    public bool CanAfford(int amount)
    {
        return coins >= amount;
    }
}