using System;
using TechStoreAppTaller.Patrones.B_Builder.Ejercicio05_06;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 5 & 6: Builder para Pedidos (Mínimo vs Completo) ---");

        // Ejercicio 6: Pedido Mínimo
        Pedido pedidoMinimo = new PedidoBuilder()
            .ConCliente("Ana")
            .ConProducto("Mouse Inalámbrico")
            .ConPrecio(25.00m)
            .Construir();

        Console.WriteLine("\n>>> PEDIDO MÍNIMO:");
        pedidoMinimo.MostrarDetalle();

        // Ejercicio 5 & 6: Pedido Completo
        Pedido pedidoCompleto = new PedidoBuilder()
            .ConCliente("Ana")
            .ConProducto("Laptop Gaming")
            .ConPrecio(950.00m)
            .ConDireccion("Ambato")
            .ConTelefono("0999999999")
            .ConObservacion("Entregar en horario de oficina")
            .ConEntrega("EXPRESS")
            .RequiereFactura(true)
            .Construir();

        Console.WriteLine("\n>>> PEDIDO COMPLETO:");
        pedidoCompleto.MostrarDetalle();
    }
}