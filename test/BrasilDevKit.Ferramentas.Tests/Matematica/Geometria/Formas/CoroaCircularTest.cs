using BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

namespace BrasilDevKit.Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class CoroaCircularTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaCoroaCircularDeRaioMaior10RaioMenor5()
    {
        CoroaCircular coroaCircular = new(raioExterno: 10, raioInterno: 5);

        double area = coroaCircular.CalcularArea();

        Assert.Equal(Math.Round(235.61944901923449288469825374596d, 10), Math.Round(area, 10));
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaCoroaCircularDeRaioMaior25Ponto321RaioMenor10Ponto123()
    {
        CoroaCircular coroaCircular = new(raioExterno: 25.321, raioInterno: 10.123);

        double area = coroaCircular.CalcularArea();

        Assert.Equal(Math.Round(1_692.306_570_990_289d, 10), Math.Round(area, 10));
    }
    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaCoroaCircularDeRaioMaior10RaioMenor5()
    {
        CoroaCircular coroaCircular = new(raioExterno: 10, raioInterno: 5);

        double perimetro = coroaCircular.CalcularPerimetro();

        Assert.Equal(Math.Round(94.247_779_607_69d, 10), Math.Round(perimetro, 10));
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaCoroaCircularDeRaioMaior25Ponto321RaioMenor10Ponto123()
    {
        CoroaCircular coroaCircular = new(raioExterno: 25.321, raioInterno: 10.123);

        double perimetro = coroaCircular.CalcularPerimetro();

        Assert.Equal(Math.Round(222.701_220_027_673d, 10), Math.Round(perimetro, 10));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarCoroaCircularComRaioMaior10RaioMenor5()
    {
        CoroaCircular coroaCircular = new(raioExterno: 10, raioInterno: 5);

        Assert.Equal(10, coroaCircular.RaioExterno);
        Assert.Equal(5, coroaCircular.RaioInterno);
    }

    [Theory]
    [InlineData(5, 5)]
    [InlineData(5, 10)]
    public void Construtor_DeveLancarExcecao_QuandoRaioInternoForMaiorOuIgualAoRaioExterno(int raioExterno, int raioInterno)
    {
        ArgumentException ex = Assert.Throws<ArgumentException>(() => new CoroaCircular(raioExterno, raioInterno));

        Assert.Equal("O raio interno deve ser menor que o raio externo.", ex.Message);
    }

    #endregion
}
