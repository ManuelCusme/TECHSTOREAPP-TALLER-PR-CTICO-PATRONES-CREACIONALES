namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio16
{
    public class AzureFactory : ICloudFactory
    {
        public IStorage CrearStorage() => new BlobStorage();
        public IQueue CrearQueue() => new ServiceBus();
    }
}