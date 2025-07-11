public class Avion : Aeronave
{
    private int alas;

    public Avion(string modelo, double velocidadMaxima, int alas) : base(modelo, velocidadMaxima)
    {
        this.alas = alas;
    }

    public int Alas
    {
        get { return alas; }
        set { alas = value; }
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Número de Alas: {alas}");
    }
}