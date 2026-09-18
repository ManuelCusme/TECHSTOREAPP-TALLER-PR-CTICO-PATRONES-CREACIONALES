using System;
using TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio16;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 16: Abstract Factory (Infraestructura Cloud AWS vs Azure) ---");

        Console.WriteLine("\n>>> INFRAESTRUCTURA AWS:");
        ProcesarCloud(new AwsFactory());

        Console.WriteLine("\n>>> INFRAESTRUCTURA AZURE:");
        ProcesarCloud(new AzureFactory());
    }

    static void ProcesarCloud(ICloudFactory factory)
    {
        IStorage storage = factory.CrearStorage();
        IQueue queue = factory.CrearQueue();

        storage.Guardar();
        queue.Publicar();
    }
}