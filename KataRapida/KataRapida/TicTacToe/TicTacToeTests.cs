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
        
        Assert.AreEqual(sut.SymbolAt((0,0)), "X");
    }
}

public class TicTacToe
{
    bool hasPlaced;
    
    public string SymbolAt((int, int) cell)
    {
        return hasPlaced ? "X" : "";
    }

    public void PlaceAt((int, int) cell)
    {
        hasPlaced = true;
    }
}