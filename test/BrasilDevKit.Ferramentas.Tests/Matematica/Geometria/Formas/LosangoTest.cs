using BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

namespace BrasilDevKit.Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class LosangoTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaLosangoDeDiagonalMaior10DiagonalMenor5()
    {
        Losango losango = new(diagonalMaior: 10, diagonalMenor: 5);

        double area = losango.CalcularArea();

        Assert.Equal(25, area);
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaLosangoDeDiagonalMaior25Ponto321DiagonalMenor10Ponto123()
    {
        Losango losango = new(diagonalMaior: 25.321, diagonalMenor: 10.123);

        double area = losango.CalcularArea();

        Assert.Equal(Math.Round(128.1622415, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaLosangoDeDiagonalMaior10DiagonalMenor5()
    {
        Losango losango = new(diagonalMaior: 10, diagonalMenor: 5);

        double perimetro = losango.CalcularPerimetro();

        Assert.Equal(Math.Round(22.360_679_774_8, 9), Math.Round(perimetro, 9));
    }

    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaLosangoDeDiagonalMaior25Ponto321DiagonalMenor10Ponto123()
    {
        Losango losango = new(diagonalMaior: 25.321, diagonalMenor: 10.123);

        double perimetro = losango.CalcularPerimetro();

        Assert.Equal(Math.Round(54.539_093_135, 9), Math.Round(perimetro, 9));
    }

    #endregion

    #region Construtor

    [Fact]
    public void Construtor_DeveCriarLosangoComDiagonalMaior10DiagonalMenor5()
    {
        Losango losango = new(diagonalMaior: 10, diagonalMenor: 5);

        Assert.Equal(10, losango.DiagonalMaior);
        Assert.Equal(5, losango.DiagonalMenor);
    }

    #endregion
}
