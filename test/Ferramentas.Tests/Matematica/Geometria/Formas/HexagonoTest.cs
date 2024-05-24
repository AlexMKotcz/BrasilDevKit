using Ferramentas.Matematica.Geometria.Formas;

namespace Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class HexagonoTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaHexagonoDeLado5()
    {
        Hexagono hexagono = new(lado: 5);

        double area = hexagono.CalcularArea();

        Assert.Equal(Math.Round(64.9519052838, 10), Math.Round(area, 10));
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaHexagonoDeLado10Ponto123()
    {
        Hexagono hexagono = new(lado: 10.123);

        double area = hexagono.CalcularArea();

        Assert.Equal(Math.Round(266.2381949103, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaHexagonoDeLado5()
    {
        Hexagono hexagono = new(lado: 5);

        double perimetro = hexagono.CalcularPerimetro();

        Assert.Equal(30, perimetro);
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaHexagonoDeLado10Ponto123()
    {
        Hexagono hexagono = new(lado: 10.123);

        double perimetro = hexagono.CalcularPerimetro();

        Assert.Equal(Math.Round(60.738, 10), Math.Round(perimetro, 10));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarHexagonoComLado5()
    {
        Hexagono hexagono = new(lado: 5);

        Assert.Equal(5, hexagono.Lado);
    }

    #endregion
}
