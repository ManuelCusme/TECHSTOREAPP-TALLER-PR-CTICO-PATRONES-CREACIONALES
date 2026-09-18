using System;

namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public class EmpaquePremium : IEmpaque
    {
        public void Empacar() => Console.WriteLine("[EMPAQUE PREMIUM] Envoltorio en caja acolchada reforzada con sello de seguridad.");
    }
}