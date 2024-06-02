namespace DbcKata;

public class Purse
{
    NotNegative coins;

    public Purse(NotNegative coins)
    {
        this.coins = coins;
    }

    public bool CanAfford(Positive amount)
    {
        return coins >= amount;
    }

    public void Afdasfs(Positive price)
    {
        if (CanAfford(price))
            throw new InvalidOperationException("No hay suficiente oro");

        var oldAmount = coins;
        coins -= price;

        if (coins >= oldAmount)
            throw new NotSupportedException("No se ha descontado el precio");
    }
}