namespace BrasilDevKit.Ferramentas.Matematica.Area;

public class Triangulo(double @base, double altura) : IFormaGeometrica
{
    public double Base { get; } = @base;
    public double Altura { get; } = altura;

    public double CalcularArea()
    {
        return Base * Altura / 2;
    }
}

