using Ferramentas.Auxiliares.Extensoes;
using Ferramentas.Documentos;

namespace Ferramentas.Documentos.CPF;

/// <summary>
/// Classe que representa um CPF.
/// </summary>
/// <param name="numero">O número do CPF.</param>
public sealed class CadastroPessoaFisica : IDocumento
{
    public static string NomeAbreviadoDocumento => "CPF";

    public static string NomeOficialDocumento => "Cadastro de Pessoa Física";

    public string Numero { get; init; } = string.Empty;

    public string NumeroFormatado
    {
        get
        {
            if (string.IsNullOrEmpty(Numero))
                return string.Empty;

            string numerosApenas = Numero.RemoverNaoNumericos();
            return $"{long.Parse(numerosApenas):000\\.000\\.000\\-00}";
        }
    }
}
