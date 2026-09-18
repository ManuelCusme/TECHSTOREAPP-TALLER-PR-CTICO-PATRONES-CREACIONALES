using System;
using TechStoreAppTaller.Patrones.C_Singleton.Ejercicio11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 11: Singleton (Configuración Global) ---");

        // Consulta desde el módulo de Facturación
        ConfiguracionApp configFacturacion = ConfiguracionApp.Instancia;
        configFacturacion.MostrarConfiguracion("Módulo Facturación");

        // Consulta desde el módulo de Inventario
        ConfiguracionApp configInventario = ConfiguracionApp.Instancia;
        configInventario.MostrarConfiguracion("Módulo Inventario");

        // Demostración de modificación global compartida
        Console.WriteLine("\n>>> Modificando moneda desde Facturación...");
        configFacturacion.Moneda = "EUR";

        configInventario.MostrarConfiguracion("Módulo Inventario (Verificación)");
    }
}