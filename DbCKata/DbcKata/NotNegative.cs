namespace DbcKata;

public readonly struct NotNegative
{
    readonly int howMuch;

    NotNegative(int howMuch)
    {
        if (howMuch < 0)
            throw new ArgumentException("Coins must be not negative");

        this.howMuch = howMuch;
    }

    public static implicit operator NotNegative(int howMuch) => new NotNegative(howMuch);
    public static implicit operator int(NotNegative purse) => purse.howMuch;
}

public readonly struct Positive
{
    readonly int howMuch;

    Positive(int howMuch)
    {
        if (howMuch <= 0)
            throw new ArgumentException("Coins must be positive");

        this.howMuch = howMuch;
    }

    public static implicit operator Positive(int howMuch) => new Positive(howMuch);
    public static implicit operator int(Positive purse) => purse.howMuch;
}