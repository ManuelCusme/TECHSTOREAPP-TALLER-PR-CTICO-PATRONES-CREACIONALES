namespace TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio03
{
    public class ReporteExcelFactory : ReporteFactory
    {
        public override IReporte CrearReporte() => new ReporteExcel();
    }
}