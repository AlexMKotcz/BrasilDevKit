namespace BrasilDevKit.Ferramentas.Matematica.Geometria.Formas;

public class CoroaCircular : IFormaGeometrica
{
    public double RaioExterno { get; }
    public double RaioInterno { get; }

    public CoroaCircular(double raioExterno, double raioInterno)
    {
        if (raioInterno >= raioExterno)
            throw new ArgumentException("O raio interno deve ser menor que o raio externo.");

        RaioExterno = raioExterno;
        RaioInterno = raioInterno;
    }

    public double CalcularArea()
    {
        return Math.PI * (Math.Pow(RaioExterno, 2) - Math.Pow(RaioInterno, 2));
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * (RaioExterno + RaioInterno);
    }
}

