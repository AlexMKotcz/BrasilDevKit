namespace Ferramentas.Matematica.Geometria.Formas;

public class TrianguloRetangulo(double @base, double altura) : IFormaGeometrica
{
    //TODO: Verificação para permitir outros tipos de triangulos
    public double Base { get; } = @base;
    public double Altura { get; } = altura;

    public double CalcularArea()
    {
        return Base * Altura / 2;
    }

    public double CalcularPerimetro()
    {
        return Base + Altura + Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
    }
}
