namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public class VentaCorporativaFactory : IVentaFactory
    {
        public IEntrega CrearEntrega() => new EntregaProgramada();
        public IEmpaque CrearEmpaque() => new EmpaqueCorporativo();
    }
}