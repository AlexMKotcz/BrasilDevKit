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

    //TODO: implementa��o do m�todo CalcularPerimetro() para Trapezio
    public double CalcularPerimetro()
    {
        throw new NotImplementedException("TODO: Implementar m�todo CalcularPerimetro() para Trapezio");
    }
}
