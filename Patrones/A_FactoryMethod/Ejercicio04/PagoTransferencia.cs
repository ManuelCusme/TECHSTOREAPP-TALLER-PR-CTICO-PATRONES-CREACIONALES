using System;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio04
{
    public class PagoTransferencia : IPago
    {
        public void Procesar(decimal total)
        {
            Console.WriteLine($"[PAGO TRANSFERENCIA] Validando transferencia bancaria por el monto de ${total:F2}.");
        }
    }
}