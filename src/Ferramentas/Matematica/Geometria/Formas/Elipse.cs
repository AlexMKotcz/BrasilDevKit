namespace Ferramentas.Matematica.Geometria.Formas;

// Implementação de uma forma geométrica específica: Elipse
public class Elipse(double semiEixoMaior, double semiEixoMenor) : IFormaGeometrica
{
    public double SemiEixoMaior { get; } = semiEixoMaior;
    public double SemiEixoMenor { get; } = semiEixoMenor;

    public double CalcularArea()
    {
        return Math.PI * SemiEixoMaior * SemiEixoMenor;
    }

    /// <summary>
    /// Cálculo aproximado do perímetro de uma elipse.
    /// </summary>
    /// <remarks>
    /// Referência: <see href="https://www.omnicalculator.com/pt/matematica/calculadora-perimetro#formula-do-perimetro-de-uma-elipse"/>
    /// <br/>
    /// Referência 2: <see href="https://stackoverflow.com/questions/42310956/how-to-calculate-the-perimeter-of-an-ellipse"/>
    /// </remarks>
    /// <returns></returns>
    public double CalcularPerimetro()
    {
        double a = SemiEixoMenor;
        double b = SemiEixoMaior;

        return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
    }
}

