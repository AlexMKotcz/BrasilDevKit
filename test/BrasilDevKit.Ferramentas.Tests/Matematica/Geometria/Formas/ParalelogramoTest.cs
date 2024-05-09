using BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

namespace BrasilDevKit.Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class ParalelogramoTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaParalelogramoDeBase10Altura5()
    {
        Paralelogramo paralelogramo = new(@base: 10, altura: 5);

        double area = paralelogramo.CalcularArea();

        Assert.Equal(50, area);
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaParalelogramoDeBase25Ponto321Altura10Ponto123()
    {
        Paralelogramo paralelogramo = new(@base: 25.321, altura: 10.123);

        double area = paralelogramo.CalcularArea();

        Assert.Equal(Math.Round(256.324483d, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaParalelogramoDeBase10Altura5()
    {
        Paralelogramo paralelogramo = new(@base: 10, altura: 5);

        double perimetro = paralelogramo.CalcularPerimetro();

        Assert.Equal(30, perimetro);
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaParalelogramoDeBase25Ponto321Altura10Ponto123()
    {
        Paralelogramo paralelogramo = new(@base: 25.321, altura: 10.123);

        double perimetro = paralelogramo.CalcularPerimetro();

        Assert.Equal(Math.Round(70.888, 10), Math.Round(perimetro, 10));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarParalelogramoComBase10Altura5()
    {
        Paralelogramo paralelogramo = new(@base: 10, altura: 5);

        Assert.Equal(10, paralelogramo.Base);
        Assert.Equal(5, paralelogramo.Altura);
    }
    #endregion
}
