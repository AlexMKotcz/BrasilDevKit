using Ferramentas.Matematica.Geometria.Formas;

namespace Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class SetorCircularTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaSetorCircularDeRaio10Angulo45()
    {
        SetorCircular setorCircular = new(raio: 10, angulo: 45);

        double area = setorCircular.CalcularArea();

        Assert.Equal(Math.Round(39.269_908_169_9d, 10), Math.Round(area, 10));
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaSetorCircularDeRaio25Ponto321Angulo60()
    {
        SetorCircular setorCircular = new(raio: 25.321, angulo: 60);

        double area = setorCircular.CalcularArea();

        Assert.Equal(Math.Round(335.706_947_238_725_916_900d, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaSetorCircularDeRaio10Angulo45()
    {
        SetorCircular setorCircular = new(raio: 10, angulo: 45);
        double perimetro = setorCircular.CalcularPerimetro();
        Assert.Equal(Math.Round(27.853_981_633_974d, 10), Math.Round(perimetro, 10));
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaSetorCircularDeRaio25Ponto321Angulo60()
    {
        SetorCircular setorCircular = new(raio: 25.321, angulo: 60);
        double perimetro = setorCircular.CalcularPerimetro();
        Assert.Equal(Math.Round(77.158_089_193_849_052d, 10), Math.Round(perimetro, 10));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarSetorCircularComRaio10Angulo45()
    {
        SetorCircular setorCircular = new(raio: 10, angulo: 45);
        Assert.Equal(10, setorCircular.Raio);
        Assert.Equal(45, setorCircular.Angulo);
    }

    #endregion
}
