namespace BrasilDevKit.Ferramentas.Matematica.Datas;

public static class CalculadoraDeData
{
    public static int CalcularDias(DateTime dataInicial, DateTime dataFinal)
        => (dataFinal - dataInicial).Days;

    public static DateTime SomarDias(DateTime dataInicial, int diasASeremAdicionados)
        => dataInicial.AddDays(diasASeremAdicionados);

    public static DateTime SubtrairDias(DateTime dataInicial, int diasASeremSubtraidos)
        => dataInicial.AddDays(-diasASeremSubtraidos);
}
