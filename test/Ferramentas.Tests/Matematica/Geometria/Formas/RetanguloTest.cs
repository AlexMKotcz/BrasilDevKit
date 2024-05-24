using Ferramentas.Matematica.Geometria.Formas;

namespace Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class RetanguloTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaRetanguloDeLargura10Altura5()
    {
        Retangulo retangulo = new(@base: 10, altura: 5);

        double area = retangulo.CalcularArea();

        Assert.Equal(50, area);
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaRetanguloDeLargura25Ponto321Altura10Ponto123()
    {
        Retangulo retangulo = new(@base: 25.321, altura: 10.123);

        double area = retangulo.CalcularArea();

        Assert.Equal(Math.Round(256.324483, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaRetanguloDeLargura10Altura5()
    {
        Retangulo retangulo = new(@base: 10, altura: 5);
        double perimetro = retangulo.CalcularPerimetro();
        Assert.Equal(30, perimetro);
    }
    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaRetanguloDeLargura25Ponto321Altura10Ponto123()
    {
        Retangulo retangulo = new(@base: 25.321, altura: 10.123);
        double perimetro = retangulo.CalcularPerimetro();
        Assert.Equal(Math.Round(70.888, 10), Math.Round(perimetro, 10));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarRetanguloComLargura10Altura5()
    {
        Retangulo retangulo = new(@base: 10, altura: 5);
        Assert.Equal(10, retangulo.Largura);
        Assert.Equal(5, retangulo.Altura);
    }

    #endregion
}
