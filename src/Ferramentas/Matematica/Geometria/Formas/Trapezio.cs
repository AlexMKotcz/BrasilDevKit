namespace Ferramentas.Matematica.Geometria.Formas;

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
        double altura = Math.Pow(Altura, 2);
        double diferencaBases = Math.Pow(BaseMaior - BaseMenor, 2);
        double tamanhoUltimoLado = Math.Sqrt(altura + diferencaBases);
        return BaseMaior + BaseMenor + Altura + tamanhoUltimoLado;
    }
}
