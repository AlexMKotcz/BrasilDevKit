namespace BrasilDevKit.Ferramentas.Documentos.CPF;

/// <summary>
/// Classe responsável por gerar um CPF.
/// </summary>
public sealed class GeradorCpf : IGeradorDocumento<CadastroPessoaFisica>
{
    /// <summary>
    /// Gera um CPF válido.
    /// </summary>
    /// <returns>Um CPF válido.</returns>
    public static CadastroPessoaFisica Gerar()
    {
        Random random = new();

        int[] cpfArray = new int[11];
        for (int i = 0; i < 9; i++)
        {
            cpfArray[i] = random.Next(0, 9);
        }

        int primeiroDigito = ValidadorCpf.ObterPrimeiroDigitoVerificador(cpfArray);
        int segundoDigito = ValidadorCpf.ObterSegundoDigitoVerificador(cpfArray);

        cpfArray[9] = primeiroDigito;
        cpfArray[10] = segundoDigito;

        string cpf = string.Join(string.Empty, cpfArray);
        return new CadastroPessoaFisica(cpf);
    }
}
