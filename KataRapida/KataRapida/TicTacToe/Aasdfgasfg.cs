namespace KataRapida;

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
