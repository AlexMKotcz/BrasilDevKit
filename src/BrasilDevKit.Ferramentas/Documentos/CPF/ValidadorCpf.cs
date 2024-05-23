using BrasilDevKit.Ferramentas.Auxiliares;

namespace BrasilDevKit.Ferramentas.Documentos.CPF;

/// <summary>
/// Classe responsável por validar um CPF pelo seu número.
/// </summary>
public sealed class ValidadorCpf : IValidadorDocumento<CadastroPessoaFisica>
{
    /// <summary>
    /// Multiplicadores utilizados para o cálculo do primeiro dígito verificador do CPF.
    /// </summary>
    private static int[] MultiplicadoresPrimeiroDigito { get; } = [10, 9, 8, 7, 6, 5, 4, 3, 2];
    /// <summary>
    /// Multiplicadores utilizados para o cálculo do segundo dígito verificador do CPF.
    /// </summary>
    private static int[] MultiplicadoresSegundoDigito { get; } = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];

    /// <summary>
    /// Valida um CPF pelo seu número.
    /// </summary>
    /// <param name="documento">O cpf.</param>
    /// <returns>True se o CPF possui um número válido, false caso contrário.</returns>
    public static bool Validar(CadastroPessoaFisica documento)
    {
        string valor = documento.Numero;

        if (string.IsNullOrWhiteSpace(valor))
            return false;

        valor = valor.RemoverNaoNumericos();

        if (valor.Length != 11)
            return false;

        if (valor.TodosDigitosIguais())
            return false;

        int[] cpfArray = new int[9];
        for (int i = 0; i < 9; i++)
        {
            cpfArray[i] = int.Parse(valor[i].ToString());
        }

        int primeiroDigitoVerificador = ObterPrimeiroDigitoVerificador(cpfArray);
        int segundoDigitoVerificador = ObterSegundoDigitoVerificador(cpfArray);

        // Verificar se os dígitos calculados batem com os fornecidos
        if (primeiroDigitoVerificador != int.Parse(valor[10].ToString()) || segundoDigitoVerificador != int.Parse(valor[11].ToString()))
            return false;

        // Se passou por todas as verificações, retorna true
        return true;
    }

    /// <summary>
    /// Obtém o primeiro dígito verificador do CPF.
    /// </summary>
    /// <param name="cpfSemDigitosVerificadores">Array do CPF sem os dígitos verificadores.</param>
    /// <returns>O primeiro dígito verificador do CPF.</returns>
    internal static int ObterPrimeiroDigitoVerificador(int[] cpfSemDigitosVerificadores)
    {
        int soma = 0;
        for (int i = 0; i < cpfSemDigitosVerificadores.Length; i++)
        {
            soma += cpfSemDigitosVerificadores[i] * MultiplicadoresPrimeiroDigito[i];
        }

        int resto = soma % 11;
        int primeiroDigitoVerificador = resto < 2 ? 0 : 11 - resto;
        return primeiroDigitoVerificador;
    }

    /// <summary>
    /// Obtém o segundo dígito verificador do CPF.
    /// </summary>
    /// <param name="cpfSemDigitosVerificadores">Array do CPF sem os dígitos verificadores.</param>
    /// <returns>O segundo dígito verificador do CPF.</returns>
    internal static int ObterSegundoDigitoVerificador(int[] cpfSemDigitosVerificadores)
    {
        int soma = 0;
        for (int i = 0; i < cpfSemDigitosVerificadores.Length; i++)
        {
            soma += cpfSemDigitosVerificadores[i] * MultiplicadoresSegundoDigito[i];
        }

        int resto = soma % 11;
        int segundoDigitoVerificador = resto < 2 ? 0 : 11 - resto;
        return segundoDigitoVerificador;
    }
}
