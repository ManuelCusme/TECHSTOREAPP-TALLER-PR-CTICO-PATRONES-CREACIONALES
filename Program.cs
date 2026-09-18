using System;
using TechStoreAppTaller.Patrones.C_Singleton.Ejercicio12;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 12: Singleton (Contador Global de Pedidos) ---");

        ContadorPedidos contador = ContadorPedidos.Instancia;

        Console.WriteLine("\n>>> Registrando primer pedido...");
        contador.Incrementar();

        Console.WriteLine("\n>>> Registrando segundo pedido...");
        contador.Incrementar();

        Console.WriteLine("\n>>> Registrando tercer pedido...");
        contador.Incrementar();

        Console.WriteLine($"\nTotal final de pedidos contados: {contador.Total}");
    }
}