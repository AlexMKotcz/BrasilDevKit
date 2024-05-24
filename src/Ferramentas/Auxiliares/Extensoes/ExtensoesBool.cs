namespace Ferramentas.Auxiliares.Extensoes;

public static class ExtensoesBool
{
    public static string ParaSimNao(this bool valor)
    {
        return valor ? "Sim" : "Não";
    }
}