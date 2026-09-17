using System;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio01
{
    public class EmailNotificacion : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"[EMAIL] Enviando correo electrónico... Mensaje: {mensaje}");
        }
    }
}