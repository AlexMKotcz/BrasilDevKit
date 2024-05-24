namespace Ferramentas.Documentos;

/// <summary>
/// Interface base para todos os documentos.
/// </summary>
public interface IDocumento
{
    public abstract static string NomeAbreviadoDocumento { get; }
    public abstract static string NomeOficialDocumento { get; }

    /// <summary>
    /// O número do documento.
    /// </summary>
    public string Numero { get; init; }
    public string NumeroFormatado { get; }
}