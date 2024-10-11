namespace KataRapida;

// [] Qué hay en una casilla (Si X o O)
// [] Si una casilla está ocupada
// [] Si hay 3 del mismo símbolo alineadas game over
// [] Después de colocar una X, va una O.

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
}

public class TicTacToe
{
    List<(int, int)> cells = new();

    public string SymbolAt((int, int) cell)
    {
        return cells.Contains(cell) ? "X" : "";
    }

    public void PlaceAt((int, int) cell)
    {
        cells.Add(cell);
    }
}