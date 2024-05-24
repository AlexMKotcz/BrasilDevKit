namespace Ferramentas.Matematica.Geometria.Formas;

public class Losango(double diagonalMaior, double diagonalMenor) : IFormaGeometrica
{
    public double DiagonalMaior { get; } = diagonalMaior;
    public double DiagonalMenor { get; } = diagonalMenor;

    public double CalcularArea()
    {
        return DiagonalMaior * DiagonalMenor / 2;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.Sqrt(Math.Pow(DiagonalMaior, 2) + Math.Pow(DiagonalMenor, 2));
    }
}

