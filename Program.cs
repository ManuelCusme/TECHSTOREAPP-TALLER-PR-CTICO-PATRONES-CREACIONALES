using System;
using TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 1: Factory Method (Notificaciones) ---");

        NotificacionFactory factoryEmail = new EmailFactory();
        INotificacion notiEmail = factoryEmail.CrearNotificacion();
        notiEmail.Enviar("Tu pedido en TechStore ha sido registrado.");

        NotificacionFactory factorySms = new SmsFactory();
        INotificacion notiSms = factorySms.CrearNotificacion();
        notiSms.Enviar("Tu pedido está en camino.");
    }
}