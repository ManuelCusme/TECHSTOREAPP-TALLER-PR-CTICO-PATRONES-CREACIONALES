using System;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio03
{
    public class ReportePdf : IReporte
    {
        public void Generar()
        {
            Console.WriteLine("[REPORTE PDF] Generando reporte de pedidos en formato PDF (.pdf)...");
        }
    }
}