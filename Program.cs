using System;
using TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 3: Factory Method para Reportes ---");

        ReporteFactory factoryPdf = new ReportePdfFactory();
        IReporte reportePdf = factoryPdf.CrearReporte();
        reportePdf.Generar();

        ReporteFactory factoryExcel = new ReporteExcelFactory();
        IReporte reporteExcel = factoryExcel.CrearReporte();
        reporteExcel.Generar();

        ReporteFactory factoryCsv = new ReporteCsvFactory();
        IReporte reporteCsv = factoryCsv.CrearReporte();
        reporteCsv.Generar();
    }
}