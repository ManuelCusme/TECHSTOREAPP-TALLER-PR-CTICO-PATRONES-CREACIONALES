using TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio01;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio02
{
    public class WhatsAppFactory : NotificacionFactory
    {
        public override INotificacion CrearNotificacion()
        {
            return new WhatsAppNotificacion();
        }
    }
}