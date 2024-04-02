namespace BrasilDevKit.Ferramentas.Computacao.Validadores;

/// <summary>
/// Classe responsável por validar um valor utilizando um validador simples.
/// </summary>
public class Validador(IValidadorSimples validadorSimples)
{
    /// <summary>
    /// Verifica se o valor fornecido é válido utilizando o validador simples.
    /// </summary>
    /// <param name="valor">O valor a ser validado.</param>
    /// <returns>True se o valor for válido, caso contrário, False.</returns>
    public bool Valido(string valor)
    {
        return validadorSimples.Validar(valor);
    }
}