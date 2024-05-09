namespace BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

public class SetorCircular(double raio, double angulo) : IFormaGeometrica
{
    public double Raio { get; } = raio;
    public double Angulo { get; } = angulo;

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2) * Angulo / 360;
    }

    public double CalcularPerimetro()
    {
        double anguloRadiano = Angulo * Math.PI / 180;
        return Raio * (anguloRadiano + 2);
    }
}

