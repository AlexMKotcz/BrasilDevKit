namespace BrasilDevKit.Ferramentas.Matematica.Area;

// Implementação de uma forma geométrica específica: Paralelogramo
public class Paralelogramo : IFormaGeometrica
{
    public double Base { get; }
    public double Altura { get; }

    public Paralelogramo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return Base * Altura;
    }
}

