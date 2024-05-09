namespace BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

// Implementação de uma forma geométrica específica: Hexágono
public class Hexagono(double lado) : IFormaGeometrica
{
    public double Lado { get; } = lado;

    public double CalcularArea()
    {
        return 3 * Math.Sqrt(3) * Math.Pow(Lado, 2) / 2;
    }

    public double CalcularPerimetro()
    {
        return Lado * 6;
    }
}

