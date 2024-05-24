using Ferramentas.Matematica.Geometria;
using Ferramentas.Matematica.Geometria.Formas;

namespace Ferramentas.Tests.Matematica.Geometria;

public sealed class CalculadoraDeAreaTests
{
    [Fact]
    public void CalcularArea_DeveRetornarAreaCorreta()
    {
        Quadrado quadrado = new(lado: 10);

        double area = CalculadoraDeArea.CalcularArea(quadrado);

        Assert.Equal(100, area);
    }
}
