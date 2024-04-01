namespace BrasilDevKit.Ferramentas.Matematica.Area;

public class Losango(double diagonalMaior, double diagonalMenor) : IFormaGeometrica
{
    public double DiagonalMaior { get; } = diagonalMaior;
    public double DiagonalMenor { get; } = diagonalMenor;

    public double CalcularArea()
    {
        return DiagonalMaior * DiagonalMenor / 2;
    }
}

