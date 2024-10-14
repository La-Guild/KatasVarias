using static KataRapida.Aasdfgasfg;

namespace KataRapida;

// [x] Qué hay en una casilla (Si X o O)
// [] Si una casilla está ocupada
// [] Si hay 3 del mismo símbolo alineadas game over
// [] Conocer ganador
// [x] Después de colocar una X, va una O.

public class TicTacToeTests
{
    [Test]
    public void CellIsFreeByDefault()
    {
        Assert.AreEqual(new TicTacToe().SymbolAt((0, 0)), "");
    }

    [Test]
    public void FirstSymbol_IsX()
    {
        var sut = new TicTacToe();

        sut.PlaceAt((0, 0));

        Assert.AreEqual(sut.SymbolAt((0, 0)), "X");
        Assert.AreEqual(sut.SymbolAt((0, 1)), "");
    }

    [Test]
    public void SecondSymbol_IsO()
    {
        var sut = new TicTacToe();

        sut.PlaceAt((0, 0));
        sut.PlaceAt((0, 1));

        Assert.AreEqual(sut.SymbolAt((0, 1)), "O");
    }

    [Test]
    public void AlternateSymbolTurn()
    {
        var sut = new TicTacToe();

        sut.PlaceAt((0, 2));
        sut.PlaceAt((1, 2));
        sut.PlaceAt((2, 2));

        Assert.AreEqual(sut.SymbolAt((1, 2)), "O");
        Assert.AreEqual(sut.SymbolAt((2, 2)), "X");
    }

    [Test]
    public void StartWithoutWinner()
    {
        Assert.AreEqual("", new TicTacToe().Winner);
    }

    [Test]
    public void StartWithoutX()
    {
        Assert.IsEmpty(new TicTacToe().XSymbols);
    }

    [Test]
    public void HaveOneX_AfterPlacing()
    {
        var sut = new TicTacToe();

        sut.PlaceAt((0, 0));
        sut.PlaceAt((0, 1));
        sut.PlaceAt((1, 0));

        Assert.IsNotEmpty(sut.XSymbols);
        Assert.IsTrue(sut.XSymbols.Contains((1,0)));
        Assert.IsTrue(sut.OSymbols.Contains((0,1)));
    }

    [Test]
    public void XWins()
    {
        var sut = new TicTacToe();

        sut.PlaceAt((0, 0));
        sut.PlaceAt((0, 1));
        sut.PlaceAt((1, 0));
        sut.PlaceAt((2, 2));
        sut.PlaceAt((2, 0));

        Assert.AreEqual("X", sut.Winner);
    }

    [Test]
    public void XHasntWonYet()
    {
        var sut = new TicTacToe();

        sut.PlaceAt((0, 0));
        sut.PlaceAt((1, 0));
        sut.PlaceAt((0, 1));
        sut.PlaceAt((2, 2));
        sut.PlaceAt((2, 0));

        Assert.AreEqual("", sut.Winner);
    }

    [Test]
    public void CoordinatesAreInTheSameRow()
    {
        Assert.IsFalse(AreInRow((0, 0)));
        Assert.IsTrue(AreInRow((0, 0), (1, 0), (2, 0)));
        Assert.IsTrue(AreInRow((0, 0), (2, 0), (1, 0)));
        Assert.IsFalse(AreInRow((0, 1), (1, 0), (2, 0)));

        Assert.IsTrue(AreInRow((0, 1), (2, 1), (1, 1)));
    }

    [Test]
    public void CoordinatesAreInTheSameColumn()
    {
        Assert.IsFalse(AreInColumn((0, 0)));
        Assert.IsTrue(AreInColumn((0, 0), (0, 1), (0, 2)));
    }

    [Test]
    public void CoordinatesAreInDiagonal()
    {
        Assert.IsFalse(AreInDiagonal((0, 0)));
        Assert.IsTrue(AreInDiagonal((0, 0), (1, 1), (2, 2)));
        Assert.IsTrue(AreInDiagonal((0, 2), (1, 1), (2, 0)));
    }
}