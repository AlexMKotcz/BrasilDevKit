namespace BrasilDevKit.Ferramentas.Geradores;

/// <summary>
/// Define um contrato para geradores simples.
/// </summary>
public interface IGeradorSimples
{
    /// <summary>
    /// Gera um valor.
    /// </summary>
    /// <returns>O valor gerado.</returns>
    string Gerar();
}