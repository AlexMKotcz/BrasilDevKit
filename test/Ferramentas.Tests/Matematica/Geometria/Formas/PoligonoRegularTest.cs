using Ferramentas.Matematica.Geometria.Formas;

namespace Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class PoligonoRegularTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaPoligonoRegularDe5LadosELado10()
    {
        PoligonoRegular poligonoRegular = new(numeroLados: 5, lado: 10);

        double area = poligonoRegular.CalcularArea();

        Assert.Equal(Math.Round(172.0477400589d, 10), Math.Round(area, 10));
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaPoligonoRegularDe6LadosELado10()
    {
        PoligonoRegular poligonoRegular = new(numeroLados: 6, lado: 10);

        double area = poligonoRegular.CalcularArea();

        Assert.Equal(Math.Round(259.8076211353, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaPoligonoRegularDe5LadosELado10()
    {
        PoligonoRegular poligonoRegular = new(numeroLados: 5, lado: 10);
        double perimetro = poligonoRegular.CalcularPerimetro();
        Assert.Equal(50, perimetro);
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaPoligonoRegularDe6LadosELado10()
    {
        PoligonoRegular poligonoRegular = new(numeroLados: 6, lado: 10);
        double perimetro = poligonoRegular.CalcularPerimetro();
        Assert.Equal(60, perimetro);
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarPoligonoRegularCom5LadosELado10()
    {
        PoligonoRegular poligonoRegular = new(numeroLados: 5, lado: 10);
        Assert.Equal(5, poligonoRegular.NumeroLados);
        Assert.Equal(10, poligonoRegular.Lado);
    }

    #endregion
}
