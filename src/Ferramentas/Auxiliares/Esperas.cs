namespace Ferramentas.Auxiliares;
public static class Esperas
{
    public const byte TempoEsperaPadrao = 200;
    public const byte TempoEsperaCurto = 100;
    public const int TempoEsperaLongo = 500;

    public static Task TaskEsperaPadrao { get => Task.Delay(TempoEsperaPadrao); }
    public static Task TaskEsperaCurta { get => Task.Delay(TempoEsperaCurto); }
    public static Task TaskEsperaLonga { get => Task.Delay(TempoEsperaLongo); }
}
