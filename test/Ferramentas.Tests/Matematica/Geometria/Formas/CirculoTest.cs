using Ferramentas.Matematica.Geometria.Formas;

namespace Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class CirculoTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaCirculoDeRaio10()
    {
        Circulo circulo = new(raio: 10);

        double area = circulo.CalcularArea();

        Assert.Equal(Math.Round(314.15926535897932384626433832795d, 10), Math.Round(area, 10));
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaCirculoDeRaio25Ponto321()
    {
        Circulo circulo = new(raio: 25.321);

        double area = circulo.CalcularArea();

        Assert.Equal(Math.Round(2014.2416834323555014015619700882d, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaCirculoDeRaio10()
    {
        Circulo circulo = new(raio: 10);

        double perimetro = circulo.CalcularPerimetro();

        Assert.Equal(Math.Round(62.831853071795862692295472353775d, 10), Math.Round(perimetro, 10));
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaCirculoDeRaio25Ponto321()
    {
        Circulo circulo = new(raio: 25.321);

        double perimetro = circulo.CalcularPerimetro();

        Assert.Equal(Math.Round(159.096_535_163_094_31d, 10), Math.Round(perimetro, 10));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarCirculoComRaio10()
    {
        Circulo circulo = new(raio: 10);

        Assert.Equal(10, circulo.Raio);
    }

    [Fact]
    public void Construtor_DeveCriarCirculoComRaio25Ponto321()
    {
        Circulo circulo = new(raio: 25.321);

        Assert.Equal(25.321, circulo.Raio);
    }

    #endregion
}
