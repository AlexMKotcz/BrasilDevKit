using Ferramentas.Matematica.Geometria.Formas;

namespace Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class TrianguloRetanguloTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaTrianguloRetanguloDeBase10Altura5()
    {
        TrianguloRetangulo triangulo = new(@base: 10, altura: 5);

        double area = triangulo.CalcularArea();

        Assert.Equal(25, area);
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaTrianguloRetanguloDeBase25Ponto321Altura10Ponto123()
    {
        TrianguloRetangulo triangulo = new(@base: 25.321, altura: 10.123);

        double area = triangulo.CalcularArea();

        Assert.Equal(Math.Round(128.1622415, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro
    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaTrianguloRetanguloDeBase10Altura5()
    {
        TrianguloRetangulo triangulo = new(@base: 10, altura: 5);
        double perimetro = triangulo.CalcularPerimetro();
        Assert.Equal(26.180339887498948482045868343656d, perimetro);
    }
    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaTrianguloDeBase25Ponto321Altura10Ponto123()
    {
        TrianguloRetangulo triangulo = new(@base: 25.321, altura: 10.123);
        double perimetro = triangulo.CalcularPerimetro();
        Assert.Equal(Math.Round(62.713546567554070718345967531596, 10), Math.Round(perimetro, 10));
    }
    #endregion
    #region Construtor
    [Fact]
    public void Construtor_DeveCriarTrianguloRetanguloComBase10Altura5()
    {
        TrianguloRetangulo triangulo = new(@base: 10, altura: 5);
        Assert.Equal(10, triangulo.Base);
        Assert.Equal(5, triangulo.Altura);
    }
    #endregion
}
