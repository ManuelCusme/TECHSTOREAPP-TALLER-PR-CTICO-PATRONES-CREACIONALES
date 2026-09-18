using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio15
{
    public class MonitorLenovo : IMonitor
    {
        public void MostrarDetalle() => Console.WriteLine("[LENOVO] Monitor ThinkVision 27\" QHD");
    }
}