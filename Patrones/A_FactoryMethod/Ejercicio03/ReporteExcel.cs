using System;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio03
{
    public class ReporteExcel : IReporte
    {
        public void Generar()
        {
            Console.WriteLine("[REPORTE EXCEL] Generando hoja de cálculo de pedidos (.xlsx)...");
        }
    }
}