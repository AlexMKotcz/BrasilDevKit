using System.ComponentModel;

namespace Clientes.Web.Auxiliares.Enumeradores;

public enum TipoCalculo
{
    [Description("Diferença entre datas")]
    DiferencaDatas,
    [Description("Adicionar dias")]
    AdicionarDias,
    [Description("Subtrair dias")]
    SubtrairDias
}
