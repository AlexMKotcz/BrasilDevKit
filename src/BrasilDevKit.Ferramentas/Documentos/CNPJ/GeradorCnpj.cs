namespace BrasilDevKit.Ferramentas.Documentos.CNPJ;

/// <summary>
/// Classe responsável por gerar um CNPJ válido.
/// </summary>
public sealed class GeradorCnpj : IGeradorDocumento<CadastroNacionalPessoaJuridica>
{
    /// <summary>
    /// Gera um CNPJ válido.
    /// </summary>
    /// <returns>Um CNPJ válido.</returns>
    public static CadastroNacionalPessoaJuridica Gerar()
    {
        Random random = new();

        int[] cnpjArray = new int[14];
        for (int i = 0; i < 12; i++)
        {
            cnpjArray[i] = random.Next(0, 9);
        }

        int primeiroDigito = ValidadorCnpj.ObterPrimeiroDigitoVerificador(cnpjArray);
        int segundoDigito = ValidadorCnpj.ObterSegundoDigitoVerificador(cnpjArray);

        cnpjArray[13] = primeiroDigito;
        cnpjArray[14] = segundoDigito;

        string cnpj = string.Join(string.Empty, cnpjArray);
        return new CadastroNacionalPessoaJuridica(cnpj);
    }
}
