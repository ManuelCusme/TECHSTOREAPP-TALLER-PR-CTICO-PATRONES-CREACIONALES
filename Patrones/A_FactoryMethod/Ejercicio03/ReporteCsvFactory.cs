namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio03
{
    public class ReporteCsvFactory : ReporteFactory
    {
        public override IReporte CrearReporte() => new ReporteCsv();
    }
}