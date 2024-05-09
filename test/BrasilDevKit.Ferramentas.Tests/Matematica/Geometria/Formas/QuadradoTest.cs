using BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

namespace BrasilDevKit.Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class QuadradoTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaQuadradoDeLado10()
    {
        Quadrado quadrado = new(lado: 10);

        double area = quadrado.CalcularArea();

        Assert.Equal(100, area);
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaQuadradoDeLado25Ponto321()
    {
        Quadrado quadrado = new(lado: 25.321);

        double area = quadrado.CalcularArea();

        Assert.Equal(Math.Round(641.153041, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaQuadradoDeLado10()
    {
        Quadrado quadrado = new(lado: 10);
        double perimetro = quadrado.CalcularPerimetro();
        Assert.Equal(40, perimetro);
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaQuadradoDeLado25Ponto321()
    {
        Quadrado quadrado = new(lado: 25.321);
        double perimetro = quadrado.CalcularPerimetro();
        Assert.Equal(Math.Round(101.284, 10), Math.Round(perimetro, 10));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarQuadradoComLado10()
    {
        Quadrado quadrado = new(lado: 10);
        Assert.Equal(10, quadrado.Lado);
    }

    #endregion
}
