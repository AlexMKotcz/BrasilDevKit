namespace BrasilDevKit.Ferramentas.Computacao.Validadores;

internal static class ExtensoesString
{
    /// <summary>
    /// Verifica se todos os dígitos de uma string são iguais.
    /// </summary>
    /// <param name="valor">A string a ser verificada.</param>
    /// <returns>True se todos os dígitos forem iguais, caso contrário, False.</returns>
    public static bool TodosDigitosIguais(this string valor)
    {
        bool todosDigitosIguais = true;
        for (int i = 1; i < valor.Length; i++)
        {
            if (valor[i] != valor[0])
            {
                todosDigitosIguais = false;
                break;
            }
        }

        return todosDigitosIguais;
    }

    /// <summary>
    /// Remove todos os caracteres não numéricos de uma string.
    /// </summary>
    /// <param name="valor">A string a ser processada.</param>
    /// <returns>A string resultante após a remoção dos caracteres não numéricos.</returns>
    public static string RemoverNaoNumericos(this string valor)
    {
        return Regexes.RegexCaracteresNaoNumericos().Replace(valor, "");
    }
}
