using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public class EntregaNormal : IEntrega
    {
        public void Procesar() => Console.WriteLine("[ENTREGA NORMAL] Envío estándar (3 a 5 días laborables).");
    }
}