namespace BrasilDevKit.Ferramentas.Matematica.Area;

public class Trapezio(double baseMaior, double baseMenor, double altura) : IFormaGeometrica
{
    public double BaseMaior { get; } = baseMaior;
    public double BaseMenor { get; } = baseMenor;
    public double Altura { get; } = altura;

    public double CalcularArea()
    {
        return (BaseMaior + BaseMenor) * Altura / 2;
    }
}
