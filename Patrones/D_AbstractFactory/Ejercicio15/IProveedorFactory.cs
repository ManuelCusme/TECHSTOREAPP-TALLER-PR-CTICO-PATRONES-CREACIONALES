namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio15
{
    public interface IProveedorFactory
    {
        ILaptop CrearLaptop();
        IMonitor CrearMonitor();
    }
}