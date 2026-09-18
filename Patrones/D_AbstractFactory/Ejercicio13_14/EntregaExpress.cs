using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public class EntregaExpress : IEntrega
    {
        public void Procesar() => Console.WriteLine("[ENTREGA EXPRESS] Envío prioritario (entregado en 24 horas).");
    }
}