using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio16
{
    public class ServiceBus : IQueue
    {
        public void Publicar() => Console.WriteLine("[AZURE SERVICE BUS] Evento enviado al bus de mensajes de Azure.");
    }
}