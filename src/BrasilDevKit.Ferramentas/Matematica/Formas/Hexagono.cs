namespace BrasilDevKit.Ferramentas.Matematica.Area;

// Implementação de uma forma geométrica específica: Hexágono
public class Hexagono : IFormaGeometrica
{
    public double Lado { get; }

    public Hexagono(double lado)
    {
        Lado = lado;
    }

    public double CalcularArea()
    {
        return 3 * Math.Sqrt(3) * Math.Pow(Lado, 2) / 2;
    }
}

