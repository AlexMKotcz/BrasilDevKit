using BrasilDevKit.Ferramentas.Documentos.CNPJ;

namespace BrasilDevKit.Ferramentas.Tests.Documentos;
public class CadastroNacionalPessoaJuridicaTestes
{
    [Fact]
    public void Gerar_DeveRetornarCnpjCom14Digitos()
    {
        CadastroNacionalPessoaJuridica cnpj = GeradorCnpj.Gerar();

        Assert.Equal(14, cnpj.Numero.Length);
    }

    [Fact]
    public void Gerar_DeveRetornarCnpjValido()
    {
        CadastroNacionalPessoaJuridica cnpj = GeradorCnpj.Gerar();

        Assert.True(ValidadorCnpj.Validar(cnpj));
    }

    [Theory]
    [InlineData("78742055000164", true)] // CNPJ válido gerado em um site
    [InlineData("37221764000117", true)] // CNPJ válido gerado em um site
    [InlineData("91427218000182", true)] // CNPJ válido gerado em um site
    [InlineData("72943370000173", true)] // CNPJ válido gerado em um site
    [InlineData("", false)] // String vazia
    [InlineData("1234567", false)] // CNPJ com menos de 14 dígitos
    [InlineData("11111111111111", false)] // CNPJ com todos os dígitos iguais
    [InlineData("1234567890123a", false)] // CNPJ com caractere não numérico
    public void Validar_DeveRetornarCorretamente(string numero, bool resultadoEsperado)
    {
        // Arrange
        CadastroNacionalPessoaJuridica documento = new() { Numero = numero };

        // Act
        bool result = ValidadorCnpj.Validar(documento);

        // Assert
        Assert.Equal(resultadoEsperado, result);
    }
}
