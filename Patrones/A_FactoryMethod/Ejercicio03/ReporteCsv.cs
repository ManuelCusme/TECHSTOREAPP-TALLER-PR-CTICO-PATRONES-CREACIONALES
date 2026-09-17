using System;

namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio03
{
    public class ReporteCsv : IReporte
    {
        public void Generar()
        {
            Console.WriteLine("[REPORTE CSV] Generando archivo plano delimitado por comas (.csv)...");
        }
    }
}