namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio03
{
    public class ReportePdfFactory : ReporteFactory
    {
        public override IReporte CrearReporte() => new ReportePdf();
    }
}