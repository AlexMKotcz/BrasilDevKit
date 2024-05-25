using System.Text.RegularExpressions;

namespace Ferramentas.Auxiliares;

internal static partial class Regexes
{
    [GeneratedRegex(@"[^0-9]")]
    public static partial Regex RegexCaracteresNaoNumericos();

    [GeneratedRegex(@"[^1234567890,.\-/]")]
    public static partial Regex RegexCaracteresForaDoPadraoDeDocumentos();
}
