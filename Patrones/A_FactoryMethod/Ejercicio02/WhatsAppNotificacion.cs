using System;
using TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio01;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio02
{
    public class WhatsAppNotificacion : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"[WHATSAPP] Enviando mensaje de WhatsApp... Mensaje: {mensaje}");
        }
    }
}