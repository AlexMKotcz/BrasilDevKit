using Ferramentas.Documentos;

namespace Ferramentas.Documentos.CPF;

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

        int[] cpfArray = new int[9];
        for (int i = 0; i < 9; i++)
        {
            cpfArray[i] = random.Next(0, 9);
        }

        string cpf = string.Join(string.Empty, cpfArray);

        int primeiroDigito = ValidadorCpf.ObterPrimeiroDigitoVerificador(cpf);
        int segundoDigito = ValidadorCpf.ObterSegundoDigitoVerificador(cpf + primeiroDigito);

        return new CadastroPessoaFisica() { Numero = cpf + primeiroDigito + segundoDigito };
    }
}
