using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio16
{
    public class S3 : IStorage
    {
        public void Guardar() => Console.WriteLine("[AWS S3] Archivo guardado correctamente en Amazon S3 Bucket.");
    }
}