namespace BrasilDevKit.Ferramentas.Matematica.Area;

public class Triangulo(double @base, double altura) : IFormaGeometrica
{
    public double Base { get; } = @base;
    public double Altura { get; } = altura;

    public double CalcularArea()
    {
        return Base * Altura / 2;
    }

    public double CalcularPerimetro()
    {
        double lado1 = Math.Sqrt(Math.Pow(Base / 2, 2) + Math.Pow(Altura, 2));
        return Base + 2 * lado1;
    }
}

