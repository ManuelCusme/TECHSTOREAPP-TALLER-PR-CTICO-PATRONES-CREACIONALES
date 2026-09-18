namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio16
{
    public interface ICloudFactory
    {
        IStorage CrearStorage();
        IQueue CrearQueue();
    }
}