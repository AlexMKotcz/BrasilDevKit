namespace BrasilDevKit.Ferramentas.Matematica.Area;
public class Quadrado(double lado) : IFormaGeometrica
{
    public double Lado { get; } = lado;

    public double CalcularArea()
    {
        return Lado * Lado;
    }
}
