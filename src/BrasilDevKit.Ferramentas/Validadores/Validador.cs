namespace BrasilDevKit.Ferramentas.Validadores;
/// <summary>
/// Classe responsável por validar valores.
/// </summary>
/// <param name="validadorSimples">Instância de um objeto que implementa a interface IValidadorSimples.</param>
public class Validador(IValidadorSimples validadorSimples)
{
    public bool Valido(string valor)
    {
        return validadorSimples.Validar(valor);
    }
}
