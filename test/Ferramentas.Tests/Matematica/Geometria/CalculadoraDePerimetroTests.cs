using Ferramentas.Matematica.Geometria;
using Ferramentas.Matematica.Geometria.Formas;

namespace Ferramentas.Tests.Matematica.Geometria;

public sealed class CalculadoraDePerimetroTests
{
    [Fact]
    public void CalcularPerimetro_DeveRetornarPerimetroCorreto()
    {
        Quadrado quadrado = new(lado: 10);

        double perimetro = CalculadoraDePerimetro.CalcularPerimetro(quadrado);

        Assert.Equal(40, perimetro);
    }
}
