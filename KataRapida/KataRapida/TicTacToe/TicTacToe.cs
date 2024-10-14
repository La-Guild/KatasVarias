namespace KataRapida;
using static KataRapida.Aasdfgasfg;

public class TicTacToe
{
    List<(int, int)> takenCells = new();
    public string Winner => HasWon(XSymbols) ? "X" : "";
    public IEnumerable<(int, int)> XSymbols => takenCells.Where(IsX);

    bool HasWon(IEnumerable<(int, int)> symbols)
    {
        return AreInRow(symbols.ToArray()) 
            || AreInColumn(symbols.ToArray()) 
            || AreInDiagonal(symbols.ToArray());
    }

    public string SymbolAt((int, int) cell)
    {
        return takenCells.Contains(cell) ? SymbolAtNew(cell) : "";
    }

    string SymbolAtNew((int, int) cell) => IsX(cell) ? "X" : "O";

    bool IsX((int, int) cell)
    {
        return takenCells.IndexOf(cell) % 2 == 0;
    }

    public void PlaceAt((int, int) cell)
    {
        takenCells.Add(cell);
    }
}