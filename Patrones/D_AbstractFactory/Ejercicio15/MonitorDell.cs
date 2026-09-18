using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio15
{
    public class MonitorDell : IMonitor
    {
        public void MostrarDetalle() => Console.WriteLine("[DELL] Monitor UltraSharp 27\" 4K HDR");
    }
}