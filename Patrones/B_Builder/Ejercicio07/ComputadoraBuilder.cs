namespace TechStoreAppTaller.Patrones.B_Builder.Ejercicio07
{
    public class ComputadoraBuilder
    {
        private readonly Computadora _computadora = new Computadora();

        public ComputadoraBuilder ConProcesador(string procesador)
        {
            _computadora.Procesador = procesador;
            return this;
        }

        public ComputadoraBuilder ConRamGB(int ramGB)
        {
            _computadora.RamGB = ramGB;
            return this;
        }

        public ComputadoraBuilder ConDiscoGB(int discoGB)
        {
            _computadora.DiscoGB = discoGB;
            return this;
        }

        public ComputadoraBuilder ConTarjetaGrafica(string tarjetaGrafica)
        {
            _computadora.TarjetaGrafica = tarjetaGrafica;
            return this;
        }

        public ComputadoraBuilder ConSistemaOperativo(string sistemaOperativo)
        {
            _computadora.SistemaOperativo = sistemaOperativo;
            return this;
        }

        public ComputadoraBuilder TieneWifi(bool tieneWifi = true)
        {
            _computadora.TieneWifi = tieneWifi;
            return this;
        }

        public Computadora Construir()
        {
            return _computadora;
        }
    }
}