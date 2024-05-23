namespace BrasilDevKit.Ferramentas.Documentos;

/// <summary>
/// Interface para um validador de documentos.
/// </summary>
/// <typeparam name="T">O tipo de documento a ser validado.</typeparam>
public interface IValidadorDocumento<in T> where T : DocumentoBase
{
    /// <summary>
    /// Valida um documento.
    /// </summary>
    /// <param name="documento">O documento a ser validado.</param>
    /// <returns>True caso o documento seja válido, false caso contrário.</returns>
    abstract static bool Validar(T documento);
}