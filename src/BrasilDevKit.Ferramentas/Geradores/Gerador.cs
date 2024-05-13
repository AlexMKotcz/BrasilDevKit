namespace BrasilDevKit.Ferramentas.Geradores;

/// <summary>
/// Classe responsável por gerar valores.
/// </summary>
/// <param name="geradorSimples">Instância de um objeto que implementa a interface IGeradorSimples.</param>
public class Gerador(IGeradorSimples geradorSimples)
{
    public string Gerar()
    {
        return geradorSimples.Gerar();
    }
}