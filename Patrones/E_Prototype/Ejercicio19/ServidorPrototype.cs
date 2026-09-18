using System;

namespace TechStoreAppTaller.Patrones.E_Prototype.Ejercicio19
{
    public class ServidorPrototype
    {
        public string NombreServidor { get; set; } = string.Empty;
        public ConfiguracionRed Red { get; set; } = new ConfiguracionRed();

        public ServidorPrototype Clonar()
        {
            ServidorPrototype clon = (ServidorPrototype)this.MemberwiseClone();
            clon.Red = new ConfiguracionRed
            {
                Ip = this.Red.Ip,
                Puerto = this.Red.Puerto
            };
            return clon;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Servidor: {NombreServidor} | Red IP: {Red.Ip} | Puerto: {Red.Puerto}");
        }
    }
}