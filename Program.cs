using System;
using TechStoreAppTaller.Patrones.B_Builder.Ejercicio07;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 7: Builder para Computadoras (Oficina vs Gaming) ---");

        // Computadora de Oficina
        Computadora pcOficina = new ComputadoraBuilder()
            .ConProcesador("Intel Core i3 13th Gen")
            .ConRamGB(8)
            .ConDiscoGB(256)
            .ConTarjetaGrafica("Integrada Intel UHD")
            .ConSistemaOperativo("Windows 11 Home")
            .TieneWifi(true)
            .Construir();

        Console.WriteLine("\n>>> CONFIGURACIÓN DE OFICINA:");
        pcOficina.MostrarDetalle();

        // Computadora Gaming
        Computadora pcGaming = new ComputadoraBuilder()
            .ConProcesador("AMD Ryzen 7 7800X3D")
            .ConRamGB(32)
            .ConDiscoGB(2000)
            .ConTarjetaGrafica("NVIDIA RTX 4080 Super")
            .ConSistemaOperativo("Windows 11 Pro")
            .TieneWifi(true)
            .Construir();

        Console.WriteLine("\n>>> CONFIGURACIÓN GAMING:");
        pcGaming.MostrarDetalle();
    }
}