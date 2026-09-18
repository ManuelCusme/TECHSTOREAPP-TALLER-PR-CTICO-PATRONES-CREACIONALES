namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio04
{
    public class PagoTarjetaFactory : PagoFactory
    {
        public override IPago CrearPago() => new PagoTarjeta();
    }
}