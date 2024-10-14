using static KataRapida.Aasdfgasfg;

namespace KataRapida;

// [x] Qué hay en una casilla (Si X o O)
// [] Si una casilla está ocupada
// [] Si hay 3 del mismo símbolo alineadas game over
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
    public void CoordinatesAlignment()
    {
        Assert.IsFalse(AreInRow((0, 0)));
        Assert.IsTrue(AreInRow((0, 0), (1, 0), (2, 0)));
        Assert.IsTrue(AreInRow((0, 0), (2, 0), (1, 0)));
        Assert.IsFalse(AreInRow((0, 1), (1, 0), (2, 0)));
        Assert.IsFalse(AreInRow((0, 1), (0, 1)));

        Assert.IsTrue(AreInRow((0, 1), (2, 1), (1, 1)));
    }
}

// [] Filas
// [] Columnas
// [] Diagonales
// [] Assert en AreInRow (No duplicados)

internal class Aasdfgasfg
{
    internal static bool AreInRow(params (int x, int y)[] coords)
    {
        return coords.Any(aCoord => coords.Count(coord => coord.y == aCoord.y) == 3);
    }
}

public class TicTacToe
{
    List<(int, int)> takenCells = new();

    public string SymbolAt((int, int) cell)
    {
        return takenCells.Contains(cell) ? SymbolAtNew(cell) : "";
    }

    string SymbolAtNew((int, int) cell) => takenCells.IndexOf(cell) % 2 == 0 ? "X" : "O";

    public void PlaceAt((int, int) cell)
    {
        takenCells.Add(cell);
    }
}