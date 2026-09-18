using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio16
{
    public class BlobStorage : IStorage
    {
        public void Guardar() => Console.WriteLine("[AZURE BLOB] Archivo subido exitosamente a Azure Blob Storage.");
    }
}