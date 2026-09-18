namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public class VentaPremiumFactory : IVentaFactory
    {
        public IEntrega CrearEntrega() => new EntregaExpress();
        public IEmpaque CrearEmpaque() => new EmpaquePremium();
    }
}