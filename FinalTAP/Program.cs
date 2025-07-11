using System;

namespace Cristian_Barreto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****Sistema de Aeronaves*****");
            Console.WriteLine("Mostrando Avión");
            AvionServicio avionServicio = new AvionServicio();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            avionServicio.crearAvion();
            Console.WriteLine("Mostrando Helicóptero");
            HelicopteroServicio helicopteroServicio = new HelicopteroServicio();
            helicopteroServicio.CrearHelicoptero();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}