namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio01
{
    public class EmailFactory : NotificacionFactory
    {
        public override INotificacion CrearNotificacion()
        {
            return new EmailNotificacion();
        }
    }
}