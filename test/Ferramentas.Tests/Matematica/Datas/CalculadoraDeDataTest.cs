using Ferramentas.Matematica.Datas;

namespace Ferramentas.Tests.Matematica.Datas;

public class CalculadoraDeDataTest
{
    #region CalcularDias
    [Fact]
    public void CalcularDias_10Dias_ReturnTrue()
    {
        int dias = CalculadoraDeData.CalcularDias(
            DateOnly.FromDateTime(DateTime.Now),
            DateOnly.FromDateTime(DateTime.Now.AddDays(10)));

        Assert.Equal(10, dias);
    }

    [Fact]
    public void CalcularDias_10DiasDataNegativa_ReturnTrue()
    {
        int dias = CalculadoraDeData.CalcularDias(
            DateOnly.FromDateTime(DateTime.Now),
            DateOnly.FromDateTime(DateTime.Now.AddDays(-10)));

        Assert.Equal(10, dias);
    }

    [Fact]
    public void CalcularDias_100Dias_ReturnTrue()
    {
        int dias = CalculadoraDeData.CalcularDias(
            DateOnly.FromDateTime(DateTime.Now),
            DateOnly.FromDateTime(DateTime.Now.AddDays(100)));

        Assert.Equal(100, dias);
    }

    [Fact]
    public void CalcularDias_100DiasDataNegativa_ReturnTrue()
    {
        int dias = CalculadoraDeData.CalcularDias(
            DateOnly.FromDateTime(DateTime.Now),
            DateOnly.FromDateTime(DateTime.Now.AddDays(-100)));

        Assert.Equal(100, dias);
    }

    [Fact]
    public void CalcularDias_10Dias_ReturnFalse()
    {
        int dias = CalculadoraDeData.CalcularDias(
            DateOnly.FromDateTime(DateTime.Now),
            DateOnly.FromDateTime(DateTime.Now.AddDays(5)));

        Assert.NotEqual(10, dias);
    }

    [Fact]
    public void CalcularDias_0Dias_ReturnTrue()
    {
        int dias = CalculadoraDeData.CalcularDias(
            DateOnly.FromDateTime(DateTime.Now),
            DateOnly.FromDateTime(DateTime.Now.AddDays(0)));

        Assert.Equal(0, dias);
    }

    [Fact]
    public void CalcularDias_EntreMeses_ReturnTrue()
    {
        int dias = CalculadoraDeData.CalcularDias(
            new DateOnly(2024, 03, 28),
            new DateOnly(2024, 04, 04));

        Assert.Equal(7, dias);
    }
    #endregion

    #region SomarDias
    [Fact]
    public void SomarDias_4Dias_ReturnTrue()
    {
        DateTime dataAtual = DateTime.Now;
        DateTime data4Dias = dataAtual.AddDays(4);
        DateOnly dataInicio = new(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        DateOnly dataEsperada = new(data4Dias.Year, data4Dias.Month, data4Dias.Day);

        Assert.Equal(dataEsperada, CalculadoraDeData.SomarDias(dataInicio, 4));
    }

    [Fact]
    public void SomarDias_4DiasNegativos_ReturnTrue()
    {
        DateTime dataAtual = DateTime.Now;
        DateTime data4Dias = dataAtual.AddDays(-4);
        DateOnly dataInicio = new(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        DateOnly dataEsperada = new(data4Dias.Year, data4Dias.Month, data4Dias.Day);

        Assert.Equal(dataEsperada, CalculadoraDeData.SomarDias(dataInicio, -4));
    }

    [Fact]
    public void SomarDias_40Dias_ReturnTrue()
    {
        DateTime dataAtual = DateTime.Now;
        DateTime data4Dias = dataAtual.AddDays(40);
        DateOnly dataInicio = new(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        DateOnly dataEsperada = new(data4Dias.Year, data4Dias.Month, data4Dias.Day);

        Assert.Equal(dataEsperada, CalculadoraDeData.SomarDias(dataInicio, 40));
    }

    [Fact]
    public void SomarDias_40DiasNegativos_ReturnTrue()
    {
        DateTime dataAtual = DateTime.Now;
        DateTime data4Dias = dataAtual.AddDays(-40);
        DateOnly dataInicio = new(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        DateOnly dataEsperada = new(data4Dias.Year, data4Dias.Month, data4Dias.Day);

        Assert.Equal(dataEsperada, CalculadoraDeData.SomarDias(dataInicio, -40));
    }
    #endregion

    #region SubtrairDias
    [Fact]
    public void SubtrairDias_4Dias_ReturnTrue()
    {
        DateTime dataAtual = DateTime.Now;
        DateTime data4DiasAtras = dataAtual.AddDays(-4);
        DateOnly dataInicio = new(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        DateOnly dataEsperada = new(data4DiasAtras.Year, data4DiasAtras.Month, data4DiasAtras.Day);

        Assert.Equal(dataEsperada, CalculadoraDeData.SubtrairDias(dataInicio, 4));
    }

    [Fact]
    public void SubtrairDias_4DiasNegativos_ReturnTrue()
    {
        DateTime dataAtual = DateTime.Now;
        DateTime data4Dias = dataAtual.AddDays(4);
        DateOnly dataInicio = new(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        DateOnly dataEsperada = new(data4Dias.Year, data4Dias.Month, data4Dias.Day);

        Assert.Equal(dataEsperada, CalculadoraDeData.SubtrairDias(dataInicio, -4));
    }

    [Fact]
    public void SubtrairDias_40Dias_ReturnTrue()
    {
        DateTime dataAtual = DateTime.Now;
        DateTime data4DiasAtras = dataAtual.AddDays(-40);
        DateOnly dataInicio = new(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        DateOnly dataEsperada = new(data4DiasAtras.Year, data4DiasAtras.Month, data4DiasAtras.Day);

        Assert.Equal(dataEsperada, CalculadoraDeData.SubtrairDias(dataInicio, 40));
    }

    [Fact]
    public void SubtrairDias_40DiasNegativos_ReturnTrue()
    {
        DateTime dataAtual = DateTime.Now;
        DateTime data4Dias = dataAtual.AddDays(40);
        DateOnly dataInicio = new(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        DateOnly dataEsperada = new(data4Dias.Year, data4Dias.Month, data4Dias.Day);

        Assert.Equal(dataEsperada, CalculadoraDeData.SubtrairDias(dataInicio, -40));
    }
    #endregion
}
