namespace KataRapida;

// [] Filas
// [] Columnas
// [] Diagonales
// [] Assert en AreInRow (No duplicados)

internal class Aasdfgasfg
{
    internal static bool AreInRow(params (int x, int y)[] coords)
    {
        if (coords.Distinct().Count() != coords.Count())
            throw new ArgumentException();

        return coords.Any(aCoord => coords.Count(coord => coord.y == aCoord.y) == 3);
    }

    internal static bool AreInColumn(params (int x, int y)[] coords)
    {
        if (coords.Distinct().Count() != coords.Count())
            throw new ArgumentException();

        return coords.Any(aCoord => coords.Count(coord => coord.x == aCoord.x) == 3);
    }

    internal static bool AreInDiagonal(params (int x, int y)[] coords)
    {
        if (coords.Distinct().Count() != coords.Count())
            throw new ArgumentException();

        return coords.Contains((0, 0)) && coords.Contains((1, 1)) && coords.Contains((2, 2))
            || coords.Contains((0, 2)) && coords.Contains((1, 1)) && coords.Contains((2, 0));
    }
}
