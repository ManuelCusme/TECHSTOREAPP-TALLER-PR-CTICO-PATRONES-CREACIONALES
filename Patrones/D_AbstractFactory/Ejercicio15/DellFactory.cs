namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio15
{
    public class DellFactory : IProveedorFactory
    {
        public ILaptop CrearLaptop() => new LaptopDell();
        public IMonitor CrearMonitor() => new MonitorDell();
    }
}