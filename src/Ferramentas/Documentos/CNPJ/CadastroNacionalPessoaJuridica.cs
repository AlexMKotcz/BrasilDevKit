using Ferramentas.Auxiliares.Extensoes;

namespace Ferramentas.Documentos.CNPJ;

/// <summary>
/// Construtor para criação de um documento CNPJ.
/// </summary>
/// <param name="numero">O número do CNPJ.</param>
public sealed class CadastroNacionalPessoaJuridica : IDocumento
{
    public static string NomeAbreviadoDocumento => "CNPJ";

    public static string NomeOficialDocumento => "Cadastro Nacional de Pessoa Jurídica";

    public string Numero { get; init; } = string.Empty;

    public string NumeroFormatado
    {
        get
        {
            if (string.IsNullOrEmpty(Numero))
                return string.Empty;

            string numerosApenas = Numero.RemoverNaoNumericos();
            return $"{long.Parse(numerosApenas):00\\.000\\.000\\/0000\\-00}";
        }
    }
}
