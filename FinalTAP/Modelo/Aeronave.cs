public class Aeronave
{
    protected string modelo;
    protected double velocidadMaxima;

    public Aeronave(string modelo, double velocidadMaxima)
    {
        this.modelo = modelo;
        this.velocidadMaxima = velocidadMaxima;
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }
    public double VelocidadMaxima
    {
        get { return velocidadMaxima; }
        set { velocidadMaxima = value; }
    }

    public virtual void Mostrar()
    { 
        Console.WriteLine($"Modelo: {modelo}, Velocidad Máxima: {velocidadMaxima} km/h");
    }
}