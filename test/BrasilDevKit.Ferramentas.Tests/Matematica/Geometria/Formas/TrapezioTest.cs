using BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

namespace BrasilDevKit.Ferramentas.Tests.Matematica.Geometria.Formas;

public sealed class TrapezioTest
{
    #region Area

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaTrapezioDeBaseMaior10BaseMenor5Altura2()
    {
        Trapezio trapezio = new(baseMaior: 10, baseMenor: 5, altura: 2);

        double area = trapezio.CalcularArea();

        Assert.Equal(15, area);
    }

    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta_ParaTrapezioDeBaseMaior25Ponto321BaseMenor10Ponto123Altura5Ponto432()
    {
        Trapezio trapezio = new(baseMaior: 25.321, baseMenor: 10.123, altura: 5.432);

        double area = trapezio.CalcularArea();

        Assert.Equal(Math.Round(96.265904, 10), Math.Round(area, 10));
    }

    #endregion

    #region Perimetro
    [Fact(Skip = "Implementar método correto")]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaTrapezioDeBaseMaior10BaseMenor5Altura2()
    {
        Trapezio trapezio = new(baseMaior: 10, baseMenor: 5, altura: 2);
        double perimetro = trapezio.CalcularPerimetro();
        Assert.Equal(27.211102550927979, perimetro);
    }
    [Fact(Skip = "Implementar método correto")]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto_ParaTrapezioDeBaseMaior25Ponto321BaseMenor10Ponto123Altura5Ponto432()
    {
        Trapezio trapezio = new(baseMaior: 25.321, baseMenor: 10.123, altura: 5.432);
        double perimetro = trapezio.CalcularPerimetro();
        Assert.Equal(Math.Round(45.876, 10), Math.Round(perimetro, 10));
    }
    #endregion
    #region Construtor
    [Fact]
    public void Construtor_DeveCriarTrapezioComBaseMaior10BaseMenor5Altura2()
    {
        Trapezio trapezio = new(baseMaior: 10, baseMenor: 5, altura: 2);
        Assert.Equal(10, trapezio.BaseMaior);
        Assert.Equal(5, trapezio.BaseMenor);
        Assert.Equal(2, trapezio.Altura);
    }
    #endregion
}