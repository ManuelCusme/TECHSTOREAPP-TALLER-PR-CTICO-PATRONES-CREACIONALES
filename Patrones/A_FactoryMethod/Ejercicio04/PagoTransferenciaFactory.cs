namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio04
{
    public class PagoTransferenciaFactory : PagoFactory
    {
        public override IPago CrearPago() => new PagoTransferencia();
    }
}