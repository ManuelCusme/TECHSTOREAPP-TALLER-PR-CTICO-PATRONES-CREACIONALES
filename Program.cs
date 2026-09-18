using System;
using TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 13 & 14: Abstract Factory (Familias de Venta) ---");

        Console.WriteLine("\n>>> FAMILIA NORMAL (Ejercicio 13):");
        ProcesarVenta(new VentaNormalFactory());

        Console.WriteLine("\n>>> FAMILIA PREMIUM (Ejercicio 13):");
        ProcesarVenta(new VentaPremiumFactory());

        Console.WriteLine("\n>>> FAMILIA CORPORATIVA (Ejercicio 14):");
        ProcesarVenta(new VentaCorporativaFactory());
    }

    static void ProcesarVenta(IVentaFactory factory)
    {
        IEntrega entrega = factory.CrearEntrega();
        IEmpaque empaque = factory.CrearEmpaque();

        entrega.Procesar();
        empaque.Empacar();
    }
}