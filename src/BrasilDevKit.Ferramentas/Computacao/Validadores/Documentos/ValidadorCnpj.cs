namespace BrasilDevKit.Ferramentas.Computacao.Validadores;

/// <summary>
/// Classe responsável por validar um CNPJ (Cadastro Nacional de Pessoa Jurídica).
/// </summary>
public class ValidadorCnpj : IValidadorSimples
{
    /// <summary>
    /// Multiplicadores utilizados para o cálculo do primeiro dígito verificador do CNPJ.
    /// </summary>
    static int[] MultiplicadoresPrimeiroDigito { get; } = [5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];
    /// <summary>
    /// Multiplicadores utilizados para o cálculo do segundo dígito verificador do CNPJ.
    /// </summary>
    static int[] MultiplicadoresSegundoDigito { get; } = [6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];

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
    /// <param name="cnpjArray">Array contendo os dígitos do CNPJ.</param>
    /// <returns>O primeiro dígito verificador do CNPJ.</returns>
    private static int ObterPrimeiroDigitoVerificador(int[] cnpjArray)
    {
        int soma = 0;
        for (int i = 0; i < 12; i++)
        {
            soma += cnpjArray[i] * MultiplicadoresPrimeiroDigito[i];
        }
        int resto = soma % 11;
        int primeiroDigito = resto < 2 ? 0 : 11 - resto;
        return primeiroDigito;
    }

    /// <summary>
    /// Obtém o segundo dígito verificador do CNPJ.
    /// </summary>
    /// <param name="cnpjArray">Array contendo os dígitos do CNPJ.</param>
    /// <returns>O segundo dígito verificador do CNPJ.</returns>
    private static int ObterSegundoDigitoVerificador(int[] cnpjArray)
    {
        int soma = 0;
        for (int i = 0; i < 13; i++)
        {
            soma += cnpjArray[i] * MultiplicadoresSegundoDigito[i];
        }
        int resto = soma % 11;
        int segundoDigito = resto < 2 ? 0 : 11 - resto;
        return segundoDigito;
    }
}