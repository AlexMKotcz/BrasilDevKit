namespace BrasilDevKit.Ferramentas.Documentos;

/// <summary>
/// Classe base para todos os documentos.
/// </summary>
public abstract class DocumentoBase
{
    /// <summary>
    /// O número do documento.
    /// </summary>
    public string Numero { get; protected set; }

    /// <summary>
    /// Construtor padrão para todos os documentos.
    /// </summary>
    /// <param name="numero">O número do documento sendo criado.</param>
    protected DocumentoBase(string numero)
    {
        Numero = numero;
    }
}