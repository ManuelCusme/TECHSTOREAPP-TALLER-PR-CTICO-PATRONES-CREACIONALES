using System;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio01
{
    public class SmsNotificacion : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"[SMS] Enviando mensaje de texto SMS... Mensaje: {mensaje}");
        }
    }
}