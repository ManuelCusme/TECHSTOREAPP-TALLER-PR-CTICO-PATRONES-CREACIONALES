using System;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio04
{
    public class PagoEfectivo : IPago
    {
        public void Procesar(decimal total)
        {
            Console.WriteLine($"[PAGO EFECTIVO] Registrando pago en efectivo en caja por ${total:F2}.");
        }
    }
}