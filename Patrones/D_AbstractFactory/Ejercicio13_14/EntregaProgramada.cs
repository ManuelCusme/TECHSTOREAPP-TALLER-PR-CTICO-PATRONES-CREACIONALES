using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public class EntregaProgramada : IEntrega
    {
        public void Procesar() => Console.WriteLine("[ENTREGA PROGRAMADA] Envío agendado para lote corporativo.");
    }
}