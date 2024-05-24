namespace Ferramentas.Matematica.Geometria.Formas;

// Implementação de uma forma geométrica específica: Paralelogramo
public class Paralelogramo(double @base, double altura) : IFormaGeometrica
{
    public double Base { get; } = @base;
    public double Altura { get; } = altura;

    public double CalcularArea()
    {
        return Base * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Base + Altura);
    }
}

