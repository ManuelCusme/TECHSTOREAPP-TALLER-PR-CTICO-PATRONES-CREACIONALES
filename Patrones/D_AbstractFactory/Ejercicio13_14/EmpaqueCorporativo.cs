using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public class EmpaqueCorporativo : IEmpaque
    {
        public void Empacar() => Console.WriteLine("[EMPAQUE CORPORATIVO] Embalaje institucional con logo empresarial.");
    }
}