namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public class VentaNormalFactory : IVentaFactory
    {
        public IEntrega CrearEntrega() => new EntregaNormal();
        public IEmpaque CrearEmpaque() => new EmpaqueNormal();
    }
}