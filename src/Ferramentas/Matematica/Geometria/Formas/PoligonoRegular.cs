namespace Ferramentas.Matematica.Geometria.Formas;

public class PoligonoRegular(int numeroLados, double lado) : IFormaGeometrica
{
    public int NumeroLados { get; } = numeroLados;
    public double Lado { get; } = lado;
    public double Apotema { get; } = CalcularApotema(numeroLados, lado);

    private static double CalcularApotema(int numeroLados, double lado)
    {
        return lado / (2 * Math.Tan(Math.PI / numeroLados));
    }

    public double CalcularArea()
    {
        return NumeroLados * Lado * Apotema / 2;
    }

    public double CalcularPerimetro()
    {
        return NumeroLados * Lado;
    }
}
