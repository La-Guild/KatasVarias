using FluentAssertions;

namespace SmartFridget;

public class Tests
{
    // Meter item
    // Mostrar estado items no caducados: $item.name: n day(s) remaining 
    // Expired Items displayed as "EXPIRED: $item.name"
    // Expired Items antes que los que los demas.
    // Abiertos degradan en 5h cuando se abre el frigo
    // Cerrados degradan en 1h cuando se abre el frigo

    [Test]
    public void Test1()
    {
        Fridge.Empty.DisplayContents(new DateTime()).Should().BeEmpty();
    }

    [Test]
    public void Testadfasdf1()
    {
        Fridge sut = Fridge.Empty;

        DateTime expiration = new DateTime();
        sut.SADfasdf(new AddedItem(Name: "Lechuga", Expiration: expiration));

        sut.DisplayContents(expiration).Should().Be("EXPIRED: Lechuga");
    }

    [Test]
    public void Testaddasfsdffasdf1()
    {
        Fridge sut = Fridge.Empty;

        DateTime expiration = new DateTime();
        AddedItem expiresTomorrow =
            new AddedItem(Name: "Tomate", Expiration: expiration.AddDays(1));

        sut.SADfasdf(expiresTomorrow);

        sut.DisplayContents(expiration).Should().Be("Tomate: 0 day(s) remaining");
    }

    [Test]
    public void Testaddasfsdsfdsfdfdffasdf1()
    {
        Fridge sut = Fridge.Empty;

        DateTime expiration = new DateTime();
        AddedItem expiresTomorrow =
            new AddedItem(Name: "Patata", Expiration: expiration.AddDays(2));

        sut.SADfasdf(expiresTomorrow);

        sut.DisplayContents(expiration).Should().Be("Patata: 1 day(s) remaining");
    }

    [Test]
    public void Testaddasfdsfdfsdsfdsfdfdffasdf1()
    {
        Fridge sut = Fridge.Empty;
        DateTime expiration = new DateTime();
        AddedItem expiresTomorrow =
            new AddedItem(Name: "Patata", Expiration: expiration.AddDays(2));
        sut.SADfasdf(expiresTomorrow);

        sut.Open();

        sut.DisplayContents(expiration).Should().Be("Patata: 0 day(s) remaining");
    }

    [Test]
    public void Testaddasfdsfdfsdsfdsfdfdfasdfasdfffasdf1()
    {
        Fridge sut = Fridge.Empty;
        DateTime expiration = new DateTime();
        AddedItem expiresTomorrow =
            new AddedItem(Name: "Patata", Expiration: expiration.AddDays(1));
        sut.SADfasdf(expiresTomorrow);

        sut.Open();

        sut.DisplayContents(expiration).Should().Be("EXPIRED: Patata");
    }

    [Test]
    public void Testaddasfdsfdfsdsfdsfdfsdsddfasdfasdfffasdf1()
    {
        Fridge sut = Fridge.Empty;
        sut.Open();
        DateTime yesterday = new DateTime();
        DateTime today = yesterday.AddDays(1);
        sut.AtDay(today);

        AddedItem expiresTomorrow =
            new AddedItem(
                Name: "Patata",
                Expiration: today.AddDays(1),
                AddedAt: today);
        sut.SADfasdf(expiresTomorrow);

        sut.DisplayContents(today).Should().NotBe("EXPIRED: Patata");
    }

    [Test]
    public void sdfgsdgf()
    {
        Fridge
            .IsExpired(
                currentDate: new DateTime(),
                itemExpiration: new DateTime())
            .Should().BeTrue();

        Fridge
            .IsExpired(
                currentDate: new DateTime(),
                itemExpiration: new DateTime().AddDays(1))
            .Should().BeFalse();

        Fridge
            .IsExpired(
                currentDate: new DateTime().AddDays(1),
                itemExpiration: new DateTime())
            .Should().BeTrue();
    }
}