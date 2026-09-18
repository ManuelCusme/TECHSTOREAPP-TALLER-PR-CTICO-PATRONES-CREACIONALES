namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio16
{
    public class AwsFactory : ICloudFactory
    {
        public IStorage CrearStorage() => new S3();
        public IQueue CrearQueue() => new Sqs();
    }
}