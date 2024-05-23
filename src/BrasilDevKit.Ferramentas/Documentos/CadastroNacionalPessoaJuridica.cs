using BrasilDevKit.Ferramentas.Auxiliares;
using BrasilDevKit.Ferramentas.Geradores;
using BrasilDevKit.Ferramentas.Validadores;

namespace BrasilDevKit.Ferramentas.Documentos;

/// <summary>
/// Classe que representa o documento de CNPJ (Cadastro Nacional de Pessoa Jurídica).
/// </summary>
/// <remarks>
/// Implementa um validador e gerador de documentos.
/// </remarks>
public class CadastroNacionalPessoaJuridica : IValidadorSimples, IGeradorSimples
{
    /// <summary>
    /// Multiplicadores utilizados para o cálculo do primeiro dígito verificador do CNPJ.
    /// </summary>
    private static int[] MultiplicadoresPrimeiroDigito { get; } = [5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];
    /// <summary>
    /// Multiplicadores utilizados para o cálculo do segundo dígito verificador do CNPJ.
    /// </summary>
    private static int[] MultiplicadoresSegundoDigito { get; } = [6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];

    /// <summary>
    /// Valida um número de CNPJ.
    /// </summary>
    /// <param name="valor">O número de CNPJ a ser validado.</param>
    /// <returns>True se o número de CNPJ é válido, caso contrário, False.</returns>
    public bool Validar(string valor)
    {
        if (string.IsNullOrWhiteSpace(valor))
            return false;

        valor = valor.RemoverNaoNumericos();

        if (valor.Length != 14)
            return false;

        if (valor.TodosDigitosIguais())
            return false;

        int[] cnpjArray = new int[14];
        for (int i = 0; i < 12; i++)
        {
            cnpjArray[i] = int.Parse(valor[i].ToString());
        }

        int primeiroDigito = ObterPrimeiroDigitoVerificador(cnpjArray);
        int segundoDigito = ObterSegundoDigitoVerificador(cnpjArray);

        // Verificar se os dígitos calculados batem com os fornecidos
        if (primeiroDigito != int.Parse(valor[12].ToString()) || segundoDigito != int.Parse(valor[13].ToString()))
            return false;

        // Se passou por todas as verificações, retorna true
        return true;
    }

    /// <summary>
    /// Obtém o primeiro dígito verificador do CNPJ.
    /// </summary>
    /// <param name="cnpjSemDigitosVerificadores">Array contendo os dígitos do CNPJ, exceto os dígitos verificadores.</param>
    /// <returns>O primeiro dígito verificador do CNPJ.</returns>
    private static int ObterPrimeiroDigitoVerificador(int[] cnpjSemDigitosVerificadores)
    {
        int soma = 0;
        for (int i = 0; i < 12; i++)
        {
            soma += cnpjSemDigitosVerificadores[i] * MultiplicadoresPrimeiroDigito[i];
        }
        int resto = soma % 11;
        int primeiroDigito = resto < 2 ? 0 : 11 - resto;
        return primeiroDigito;
    }

    /// <summary>
    /// Obtém o segundo dígito verificador do CNPJ.
    /// </summary>
    /// <param name="cnpjSemDigitosVerificadores">Array contendo os dígitos do CNPJ, exceto os dígitos verificadores.</param>
    /// <returns>O segundo dígito verificador do CNPJ.</returns>
    private static int ObterSegundoDigitoVerificador(int[] cnpjSemDigitosVerificadores)
    {
        int soma = 0;
        for (int i = 0; i < 13; i++)
        {
            soma += cnpjSemDigitosVerificadores[i] * MultiplicadoresSegundoDigito[i];
        }
        int resto = soma % 11;
        int segundoDigito = resto < 2 ? 0 : 11 - resto;
        return segundoDigito;
    }

    /// <summary>
    /// Gera um número de CNPJ válido.
    /// </summary>
    /// <returns>Um número de CNPJ válido.</returns>
    public string Gerar()
    {
        Random random = new();

        int[] cnpjArray = new int[14];
        for (int i = 0; i < 12; i++)
        {
            cnpjArray[i] = random.Next(0, 9);
        }

        int primeiroDigito = ObterPrimeiroDigitoVerificador(cnpjArray);
        int segundoDigito = ObterSegundoDigitoVerificador(cnpjArray);

        cnpjArray[13] = primeiroDigito;
        cnpjArray[14] = segundoDigito;

        string cnpj = string.Join(string.Empty, cnpjArray);
        return cnpj;
    }
}