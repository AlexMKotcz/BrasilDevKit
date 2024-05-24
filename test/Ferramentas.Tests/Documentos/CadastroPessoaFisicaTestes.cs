using Ferramentas.Documentos.CPF;

namespace Ferramentas.Tests.Documentos;

public sealed class CadastroPessoaFisicaTestes
{
    [Fact]
    public void Gerar_DeveRetornarCpfCom11Digitos()
    {
        CadastroPessoaFisica cnpj = GeradorCpf.Gerar();

        Assert.Equal(11, cnpj.Numero.Length);
    }

    [Fact]
    public void Gerar_DeveRetornarCpfValido()
    {
        CadastroPessoaFisica cnpj = GeradorCpf.Gerar();

        Assert.True(ValidadorCpf.Validar(cnpj));
    }

    [Theory]
    [InlineData("48305584070", true)] // CPF válido gerado em um site
    [InlineData("53650823039", true)] // CPF válido gerado em um site
    [InlineData("41275087019", true)] // CPF válido gerado em um site
    [InlineData("87266811023", true)] // CPF válido gerado em um site
    [InlineData("", false)] // String vazia
    [InlineData("1234567", false)] // CPF com menos de 11 dígitos
    [InlineData("11111111111", false)] // CPF com todos os dígitos iguais
    [InlineData("1234567890a", false)] // CPF com caractere não numérico
    public void Validar_DeveRetornarCorretamente(string numero, bool resultadoEsperado)
    {
        // Arrange
        CadastroPessoaFisica documento = new() { Numero = numero };

        // Act
        bool result = ValidadorCpf.Validar(documento);

        // Assert
        Assert.Equal(resultadoEsperado, result);
    }
}
