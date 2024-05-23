using System.ComponentModel;

namespace Clientes.Web.Auxiliares.Enumeradores;

public enum TipoCalculoData
{
    [Description("Diferença entre datas")]
    Diferenca,
    [Description("Adicionar dias")]
    Adicionar,
    [Description("Subtrair dias")]
    Subtrair
}
