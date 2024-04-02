namespace BrasilDevKit.Ferramentas.Matematica.Area;

public class CoroaCircular(double raioExterno, double raioInterno) : IFormaGeometrica
{
    public double RaioExterno { get; } = raioExterno;
    public double RaioInterno { get; } = raioInterno;

    public double CalcularArea()
    {
        return Math.PI * (Math.Pow(RaioExterno, 2) - Math.Pow(RaioInterno, 2));
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * (RaioExterno + RaioInterno);
    }
}

