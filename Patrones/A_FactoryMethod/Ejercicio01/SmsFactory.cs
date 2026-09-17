namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio01
{
    public class SmsFactory : NotificacionFactory
    {
        public override INotificacion CrearNotificacion()
        {
            return new SmsNotificacion();
        }
    }
}