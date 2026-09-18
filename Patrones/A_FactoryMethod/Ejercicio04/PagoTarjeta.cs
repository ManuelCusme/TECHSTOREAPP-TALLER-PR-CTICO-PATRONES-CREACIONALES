using System;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio04
{
    public class PagoTarjeta : IPago
    {
        public void Procesar(decimal total)
        {
            Console.WriteLine($"[PAGO TARJETA] Procesando cobro de ${total:F2} con tarjeta de crédito/débito.");
        }
    }
}