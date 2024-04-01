namespace BrasilDevKit.Ferramentas.Matematica.Area;

// Implementação de uma forma geométrica específica: Elipse
public class Elipse : IFormaGeometrica
{
    public double SemiEixoMaior { get; }
    public double SemiEixoMenor { get; }

    public Elipse(double semiEixoMaior, double semiEixoMenor)
    {
        SemiEixoMaior = semiEixoMaior;
        SemiEixoMenor = semiEixoMenor;
    }

    public double CalcularArea()
    {
        return Math.PI * SemiEixoMaior * SemiEixoMenor;
    }
}

