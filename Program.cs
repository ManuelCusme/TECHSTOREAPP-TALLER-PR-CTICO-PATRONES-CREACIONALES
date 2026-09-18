using System;
using TechStoreAppTaller.Patrones.B_Builder.Ejercicio08;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 8: Builder para Paquete de Entrega ---");

        // Paquete Normal
        PaqueteEntrega paqueteNormal = new PaqueteEntregaBuilder()
            .ConTipoCaja("Cartón Estándar")
            .ConProteccion("Burbuja Básica")
            .ConSeguro(false)
            .ConEtiquetaFragil(false)
            .ConObservacion("Manejo regular de paquetería")
            .Construir();

        Console.WriteLine("\n>>> PAQUETE NORMAL:");
        paqueteNormal.MostrarDetalle();

        // Paquete Premium
        PaqueteEntrega paquetePremium = new PaqueteEntregaBuilder()
            .ConTipoCaja("Caja de Madera Reforzada")
            .ConProteccion("Espuma de Alta Densidad")
            .ConSeguro(true)
            .ConEtiquetaFragil(true)
            .ConObservacion("Entrega prioritaria delicada")
            .Construir();

        Console.WriteLine("\n>>> PAQUETE PREMIUM:");
        paquetePremium.MostrarDetalle();
    }
}