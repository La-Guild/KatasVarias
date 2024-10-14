namespace KataRapida;

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