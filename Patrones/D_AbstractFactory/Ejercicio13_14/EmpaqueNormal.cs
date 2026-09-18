using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public class EmpaqueNormal : IEmpaque
    {
        public void Empacar() => Console.WriteLine("[EMPAQUE NORMAL] Envoltorio en caja básica de cartón.");
    }
}