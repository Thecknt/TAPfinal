public class Helicoptero : Aeronave
{
    private int rotores;

    public Helicoptero(string modelo, double velocidadMaxima, int rotores) : base(modelo, velocidadMaxima)
    {
        this.rotores = rotores;
    }

    public int Rotores
    {
        get { return rotores; }
        set { rotores = value; }
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Número de Rotores: {rotores}");
    }
}   