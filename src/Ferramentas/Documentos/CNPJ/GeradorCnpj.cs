namespace Ferramentas.Documentos.CNPJ;

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

        int[] cnpjArray = new int[12];
        for (int i = 0; i < 12; i++)
        {
            cnpjArray[i] = random.Next(0, 9);
        }

        string cnpj = string.Join(string.Empty, cnpjArray);

        int primeiroDigito = ValidadorCnpj.ObterPrimeiroDigitoVerificador(cnpj);
        int segundoDigito = ValidadorCnpj.ObterSegundoDigitoVerificador(cnpj + primeiroDigito);

        return new CadastroNacionalPessoaJuridica() { Numero = cnpj + primeiroDigito + segundoDigito };
    }
}
