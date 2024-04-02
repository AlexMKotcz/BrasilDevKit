namespace BrasilDevKit.Ferramentas.Computacao.Validadores;

/// <summary>
/// Representa um validador para números de CPF (Cadastro de Pessoas Físicas).
/// </summary>
public class ValidadorCpf : IValidadorSimples
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
    /// Valida um número de CPF.
    /// </summary>
    /// <param name="valor">O número de CPF a ser validado.</param>
    /// <returns>True se o CPF é válido, caso contrário, False.</returns>
    public bool Validar(string valor)
    {
        if (string.IsNullOrWhiteSpace(valor))
            return false;

        valor = valor.RemoverNaoNumericos();

        if (valor.Length != 11)
            return false;

        if (valor.TodosDigitosIguais())
            return false;

        string cpfSemDigitosVerificadores = valor[..9];
        int primeiroDigitoVerificador = ObterPrimeiroDigitoVerificador(cpfSemDigitosVerificadores);

        if (int.Parse(valor[9].ToString()) != primeiroDigitoVerificador)
            return false;

        cpfSemDigitosVerificadores += primeiroDigitoVerificador;
        int segundoDigitoVerificador = ObterSegundoDigitoVerificador(cpfSemDigitosVerificadores);

        return int.Parse(valor[10].ToString()) == segundoDigitoVerificador;
    }

    /// <summary>
    /// Obtém o primeiro dígito verificador do CPF.
    /// </summary>
    /// <param name="cpfSemDigitosVerificadores">O CPF sem os dígitos verificadores.</param>
    /// <returns>O primeiro dígito verificador do CPF.</returns>
    private static int ObterPrimeiroDigitoVerificador(string cpfSemDigitosVerificadores)
    {
        int soma = 0;
        for (int i = 0; i < cpfSemDigitosVerificadores.Length; i++)
        {
            soma += int.Parse(cpfSemDigitosVerificadores[i].ToString()) * MultiplicadoresPrimeiroDigito[i];
        }

        int resto = soma % 11;
        int primeiroDigitoVerificador = resto < 2 ? 0 : 11 - resto;
        return primeiroDigitoVerificador;
    }

    /// <summary>
    /// Obtém o segundo dígito verificador do CPF.
    /// </summary>
    /// <param name="cpfSemDigitosVerificadores">O CPF sem os dígitos verificadores.</param>
    /// <returns>O segundo dígito verificador do CPF.</returns>
    private static int ObterSegundoDigitoVerificador(string cpfSemDigitosVerificadores)
    {
        int soma = 0;
        for (int i = 0; i < cpfSemDigitosVerificadores.Length; i++)
        {
            soma += int.Parse(cpfSemDigitosVerificadores[i].ToString()) * MultiplicadoresSegundoDigito[i];
        }

        int resto = soma % 11;
        int segundoDigitoVerificador = resto < 2 ? 0 : 11 - resto;
        return segundoDigitoVerificador;
    }
}
