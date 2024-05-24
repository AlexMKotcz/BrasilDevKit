using Ferramentas.Matematica.Geometria.Formas;

namespace Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class PentagonoTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaPentagonoDeLado5()
    {
        Pentagono pentagono = new(lado: 5);

        double area = pentagono.CalcularArea();

        Assert.Equal(Math.Round(43.0119350147, 10), Math.Round(area, 10));
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaPentagonoDeLado10Ponto123()
    {
        Pentagono pentagono = new(lado: 10.123);

        double area = pentagono.CalcularArea();

        Assert.Equal(Math.Round(176.3061435669, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaPentagonoDeLado5()
    {
        Pentagono pentagono = new(lado: 5);
        double perimetro = pentagono.CalcularPerimetro();
        Assert.Equal(25, perimetro);
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaPentagonoDeLado10Ponto123()
    {
        Pentagono pentagono = new(lado: 10.123);
        double perimetro = pentagono.CalcularPerimetro();
        Assert.Equal(Math.Round(50.615, 10), Math.Round(perimetro, 10));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarPentagonoComLado5()
    {
        Pentagono pentagono = new(lado: 5);
        Assert.Equal(5, pentagono.Lado);
    }

    #endregion
}
