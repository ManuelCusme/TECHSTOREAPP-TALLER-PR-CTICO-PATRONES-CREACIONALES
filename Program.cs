using System;
using TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 15: Abstract Factory (Proveedores Dell vs Lenovo) ---");

        Console.WriteLine("\n>>> EQUIPAMIENTO FAMILIA DELL:");
        ProcesarEquipamiento(new DellFactory());

        Console.WriteLine("\n>>> EQUIPAMIENTO FAMILIA LENOVO:");
        ProcesarEquipamiento(new LenovoFactory());
    }

    static void ProcesarEquipamiento(IProveedorFactory factory)
    {
        ILaptop laptop = factory.CrearLaptop();
        IMonitor monitor = factory.CrearMonitor();

        laptop.MostrarDetalle();
        monitor.MostrarDetalle();
    }
}