﻿namespace Ferramentas.Documentos;

/// <summary>
/// Interface para um gerador de documentos.
/// </summary>
/// <typeparam name="T">O tipo do documento.</typeparam>
public interface IGeradorDocumento<out T> where T : IDocumento
{
    /// <summary>
    /// Gera um documento do tipo <typeparamref name="T"/>.
    /// </summary>
    /// <returns>Documento do tipo <typeparamref name="T"/>.</returns>
    abstract static T Gerar();
}