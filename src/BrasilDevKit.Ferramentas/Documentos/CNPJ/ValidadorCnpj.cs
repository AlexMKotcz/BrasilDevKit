using System.Runtime.CompilerServices;
using BrasilDevKit.Ferramentas.Auxiliares.Extensoes;

namespace BrasilDevKit.Ferramentas.Documentos.CNPJ;

/// <summary>
/// Classe responsável por validar um número de CNPJ.
/// </summary>
public sealed class ValidadorCnpj : IValidadorDocumento<CadastroNacionalPessoaJuridica>
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
    /// Valida um CNPJ pelo seu número.
    /// </summary>
    /// <param name="documento">O CNPJ a ser validado.</param>
    /// <returns>True se o número de CNPJ é válido, caso contrário, False.</returns>
    public static bool Validar(CadastroNacionalPessoaJuridica documento)
    {
        if (string.IsNullOrWhiteSpace(documento.Numero))
            return false;

        string valor = documento.Numero.RemoverNaoNumericos();

        if (valor.Length != 14)
            return false;

        if (valor.TodosDigitosIguais())
            return false;        

        int primeiroDigito = ObterPrimeiroDigitoVerificador(valor);
        int segundoDigito = ObterSegundoDigitoVerificador(valor + primeiroDigito);

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
    internal static int ObterPrimeiroDigitoVerificador(string numero)
    {
        int soma = 0;
        for (int i = 0; i < 12; i++)
        {
            soma += int.Parse(numero[i].ToString()) * MultiplicadoresPrimeiroDigito[i];
        }

        int resto = soma % 11;
        return resto < 2 ? 0 : 11 - resto;
    }

    /// <summary>
    /// Obtém o segundo dígito verificador do CNPJ.
    /// </summary>
    /// <param name="cnpjSemDigitosVerificadores">Array contendo os dígitos do CNPJ, exceto os dígitos verificadores.</param>
    /// <returns>O segundo dígito verificador do CNPJ.</returns>
    internal static int ObterSegundoDigitoVerificador(string numero)
    {
        int soma = 0;
        for (int i = 0; i < 13; i++)
        {
            soma += int.Parse(numero[i].ToString()) * MultiplicadoresSegundoDigito[i];
        }

        int resto = soma % 11;
        return resto < 2 ? 0 : 11 - resto;
    }
}
