using System.ComponentModel;

namespace Clientes.Web.Auxiliares.Enumeradores;

public enum TipoDocumento
{
    [Description("CPF")]
    CadastroPessoaFisica,
    [Description("CNPJ")]
    CadastroNacionalPessoaJuridica
}