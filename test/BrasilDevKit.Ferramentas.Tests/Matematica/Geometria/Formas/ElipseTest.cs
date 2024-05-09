using BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

namespace BrasilDevKit.Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class ElipseTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaElipseDeRaioMaior10RaioMenor5()
    {
        Elipse elipse = new(semiEixoMaior: 10, semiEixoMenor: 5);

        double area = elipse.CalcularArea();

        Assert.Equal(Math.Round(157.07963267948966, 10), Math.Round(area, 10));
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaElipseDeRaioMaior25Ponto321RaioMenor10Ponto123()
    {
        Elipse elipse = new(semiEixoMaior: 25.321, semiEixoMenor: 10.123);

        double area = elipse.CalcularArea();

        Assert.Equal(Math.Round(805.2671127280, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]

    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaElipseDeRaioMaior10RaioMenor5()
    {
        Elipse elipse = new(semiEixoMaior: 10, semiEixoMenor: 5);

        double perimetro = elipse.CalcularPerimetro();

        Assert.Equal(Math.Round(48.442_105_488_356, 10), Math.Round(perimetro, 10));
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaElipseDeRaioMaior25Ponto321RaioMenor10Ponto123()
    {
        Elipse elipse = new(semiEixoMaior: 25.321, semiEixoMenor: 10.123);

        double perimetro = elipse.CalcularPerimetro();

        Assert.Equal(Math.Round(116.529_049_548_396, 10), Math.Round(perimetro, 10));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarElipseComRaioMaior10RaioMenor5()
    {
        Elipse elipse = new(semiEixoMaior: 10, semiEixoMenor: 5);

        Assert.Equal(10, elipse.SemiEixoMaior);
        Assert.Equal(5, elipse.SemiEixoMenor);
    }

    #endregion
}
