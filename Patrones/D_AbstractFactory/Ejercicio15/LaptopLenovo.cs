using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio15
{
    public class LaptopLenovo : ILaptop
    {
        public void MostrarDetalle() => Console.WriteLine("[LENOVO] Laptop ThinkPad X1 Carbon - Ryzen 7, 16GB RAM");
    }
}