using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio16
{
    public class Sqs : IQueue
    {
        public void Publicar() => Console.WriteLine("[AWS SQS] Mensaje publicado en la cola de Amazon SQS.");
    }
}