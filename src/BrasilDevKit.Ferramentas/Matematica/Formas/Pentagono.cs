namespace BrasilDevKit.Ferramentas.Matematica.Area;

// Implementação de uma forma geométrica específica: Pentágono
public class Pentagono(double lado) : IFormaGeometrica
{
    public double Lado { get; } = lado;

    public double CalcularArea()
    {
        return 5.0 / 4.0 * Math.Pow(Lado, 2) * (1 / Math.Tan(Math.PI / 5));
    }

    public double CalcularPerimetro()
    {
        return Lado * 5;
    }
}

