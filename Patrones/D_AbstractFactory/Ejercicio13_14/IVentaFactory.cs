namespace TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14
{
    public interface IVentaFactory
    {
        IEntrega CrearEntrega();
        IEmpaque CrearEmpaque();
    }
}