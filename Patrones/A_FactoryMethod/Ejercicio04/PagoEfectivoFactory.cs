namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio04
{
    public class PagoEfectivoFactory : PagoFactory
    {
        public override IPago CrearPago() => new PagoEfectivo();
    }
}