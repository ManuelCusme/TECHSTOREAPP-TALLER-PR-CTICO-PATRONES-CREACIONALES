using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio15
{
    public class LaptopDell : ILaptop
    {
        public void MostrarDetalle() => Console.WriteLine("[DELL] Laptop XPS 15 - Intel Core i9, 32GB RAM");
    }
}