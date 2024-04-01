namespace BrasilDevKit.Ferramentas.Matematica.Area;

public class SetorCircular(double raio, double angulo) : IFormaGeometrica
{
    public double Raio { get; } = raio;
    public double Ângulo { get; } = angulo;

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2) * Ângulo / 360;
    }
}

