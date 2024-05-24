namespace Ferramentas.Matematica.Datas;

public static class CalculadoraDeData
{
    public static int CalcularDias(DateOnly dataInicial, DateOnly dataFinal)
        => Math.Abs(dataInicial.DayNumber - dataFinal.DayNumber);

    public static DateOnly SomarDias(DateOnly dataInicial, int diasASeremAdicionados)
        => dataInicial.AddDays(diasASeremAdicionados);

    public static DateOnly SubtrairDias(DateOnly dataInicial, int diasASeremSubtraidos)
        => dataInicial.AddDays(-diasASeremSubtraidos);
}
