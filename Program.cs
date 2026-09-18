using System;
using TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 4: Factory Method para Métodos de Pago ---");
        decimal totalCompra = 450.50m;

        PagoFactory factoryTarjeta = new PagoTarjetaFactory();
        IPago pagoTarjeta = factoryTarjeta.CrearPago();
        pagoTarjeta.Procesar(totalCompra);

        PagoFactory factoryTransferencia = new PagoTransferenciaFactory();
        IPago pagoTransferencia = factoryTransferencia.CrearPago();
        pagoTransferencia.Procesar(totalCompra);

        PagoFactory factoryEfectivo = new PagoEfectivoFactory();
        IPago pagoEfectivo = factoryEfectivo.CrearPago();
        pagoEfectivo.Procesar(totalCompra);
    }
}