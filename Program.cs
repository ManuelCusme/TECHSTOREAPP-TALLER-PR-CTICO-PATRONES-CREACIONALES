using System;
using TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio01;
using TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 1: Notificaciones (Email y SMS) ---");
        NotificacionFactory factoryEmail = new EmailFactory();
        INotificacion notiEmail = factoryEmail.CrearNotificacion();
        notiEmail.Enviar("Tu pedido en TechStore ha sido registrado.");

        NotificacionFactory factorySms = new SmsFactory();
        INotificacion notiSms = factorySms.CrearNotificacion();
        notiSms.Enviar("Tu pedido está en camino.");

        Console.WriteLine("\n--- EJERCICIO 2: Notificaciones (WhatsApp) ---");
        NotificacionFactory factoryWhatsApp = new WhatsAppFactory();
        INotificacion notiWhatsApp = factoryWhatsApp.CrearNotificacion();
        notiWhatsApp.Enviar("Tu pedido ha sido entregado exitosamente.");
    }
}