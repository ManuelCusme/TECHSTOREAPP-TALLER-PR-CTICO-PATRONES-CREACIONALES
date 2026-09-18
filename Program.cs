using System;
using TechStoreAppTaller.Patrones.C_Singleton.Ejercicio09_10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 9 & 10: Singleton (Bitácora del Sistema) ---");

        // Ejercicio 9: Registrar mensajes desde diferentes puntos
        Bitacora bitacora1 = Bitacora.Instancia;
        bitacora1.Registrar("Usuario inició sesión en el sistema.");
        bitacora1.Registrar("Se generó una consulta sobre catálogo.");

        Bitacora bitacora2 = Bitacora.Instancia;
        bitacora2.Registrar("Se registró un nuevo pedido desde el módulo de ventas.");

        // Ejercicio 10: Comprobar que existe una sola instancia (retorna True)
        Console.WriteLine("\n>>> COMPROBACIÓN DE INSTANCIA ÚNICA:");
        bool sonIguales = ReferenceEquals(bitacora1, bitacora2);
        Console.WriteLine($"ReferenceEquals(bitacora1, bitacora2): {sonIguales}");

        // Mostrar todo el historial grabado en la misma instancia
        bitacora1.MostrarHistorial();
    }
}