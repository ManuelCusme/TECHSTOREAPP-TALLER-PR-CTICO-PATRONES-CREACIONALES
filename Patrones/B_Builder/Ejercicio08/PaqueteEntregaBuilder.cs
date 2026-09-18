namespace TechStoreAppTaller.Patrones.B_Builder.Ejercicio08
{
    public class PaqueteEntregaBuilder
    {
        private readonly PaqueteEntrega _paquete = new PaqueteEntrega();

        public PaqueteEntregaBuilder ConTipoCaja(string tipoCaja)
        {
            _paquete.TipoCaja = tipoCaja;
            return this;
        }

        public PaqueteEntregaBuilder ConProteccion(string proteccion)
        {
            _paquete.Proteccion = proteccion;
            return this;
        }

        public PaqueteEntregaBuilder ConSeguro(bool tieneSeguro = true)
        {
            _paquete.Seguro = tieneSeguro;
            return this;
        }

        public PaqueteEntregaBuilder ConEtiquetaFragil(bool esFragil = true)
        {
            _paquete.EtiquetaFragil = esFragil;
            return this;
        }

        public PaqueteEntregaBuilder ConObservacion(string observacion)
        {
            _paquete.Observacion = observacion;
            return this;
        }

        public PaqueteEntrega Construir()
        {
            return _paquete;
        }
    }
}