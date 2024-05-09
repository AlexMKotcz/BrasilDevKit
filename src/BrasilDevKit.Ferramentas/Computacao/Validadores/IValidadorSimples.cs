namespace BrasilDevKit.Ferramentas.Computacao.Validadores;

/// <summary>
/// Define um contrato para validadores simples.
/// </summary>
public interface IValidadorSimples
{
    /// <summary>
    /// Valida um valor.
    /// </summary>
    /// <param name="valor">O valor a ser validado.</param>
    /// <returns>True se o valor for válido, False caso contrário.</returns>
    bool Validar(string valor);
}