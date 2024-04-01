namespace BrasilDevKit.Ferramentas.Matematica.Area;

// Implementação de uma forma geométrica específica: Pentágono
public class Pentagono : IFormaGeometrica
{
    public double Lado { get; }

    public Pentagono(double lado)
    {
        Lado = lado;
    }

    public double CalcularArea()
    {
        return (5.0 / 4.0) * Math.Pow(Lado, 2) * (1 / Math.Tan(Math.PI / 5));
    }
}

