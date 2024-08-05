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
        Fridge.Empty.ASDfasfd().Should().BeEmpty();
    }

    [Test]
    public void Testadfasdf1()
    {
        Fridge sut = Fridge.Empty;

        sut.SADfasdf(new AddedItem(name: "Lechuga", expiration: new DateTime()));

        sut.ASDfasfd().Should().NotBeEmpty();
    }
}