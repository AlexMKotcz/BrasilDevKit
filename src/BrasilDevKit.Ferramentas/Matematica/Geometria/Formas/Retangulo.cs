namespace BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

public class Retangulo(double @base, double altura) : IFormaGeometrica
{
    public double Largura { get; } = @base;
    public double Altura { get; } = altura;

    public double CalcularArea()
    {
        return Largura * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}
