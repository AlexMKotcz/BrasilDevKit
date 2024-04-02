namespace BrasilDevKit.Ferramentas.Matematica.Area;

public class Retangulo(double largura, double altura) : IFormaGeometrica
{
    public double Largura { get; } = largura;
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
