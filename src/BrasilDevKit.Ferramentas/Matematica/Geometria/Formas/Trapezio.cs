namespace BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

public class Trapezio(double baseMaior, double baseMenor, double altura) : IFormaGeometrica
{
    public double BaseMaior { get; } = baseMaior;
    public double BaseMenor { get; } = baseMenor;
    public double Altura { get; } = altura;

    public double CalcularArea()
    {
        return (BaseMaior + BaseMenor) * Altura / 2;
    }

    //TODO: implementação do método CalcularPerimetro() para Trapezio
    public double CalcularPerimetro()
    {
        throw new NotImplementedException("TODO: Implementar método CalcularPerimetro() para Trapezio");
    }
}
