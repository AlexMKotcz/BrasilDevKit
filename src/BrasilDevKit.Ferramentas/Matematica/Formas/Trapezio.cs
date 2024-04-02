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

    public double CalcularPerimetro()
    {
        double lado1 = Math.Abs(BaseMaior - BaseMenor) / 2;
        double hipotenusa = Math.Sqrt(Math.Pow(lado1, 2) + Math.Pow(Altura, 2));
        return BaseMaior + BaseMenor + 2 * hipotenusa;
    }
}
