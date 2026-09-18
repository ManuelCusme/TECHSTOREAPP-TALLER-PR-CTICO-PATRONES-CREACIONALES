namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio15
{
    public class LenovoFactory : IProveedorFactory
    {
        public ILaptop CrearLaptop() => new LaptopLenovo();
        public IMonitor CrearMonitor() => new MonitorLenovo();
    }
}