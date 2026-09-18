using System;

namespace TechStoreAppTaller.Patrones.C_Singleton.Ejercicio11
{
    public sealed class ConfiguracionApp
    {
        private static readonly Lazy<ConfiguracionApp> _instancia = new Lazy<ConfiguracionApp>(() => new ConfiguracionApp());

        private ConfiguracionApp()
        {
            NombreTienda = "TechStore - Matriz Ambato";
            Moneda = "USD";
            Ambiente = "Producción";
        }

        public static ConfiguracionApp Instancia => _instancia.Value;

        public string NombreTienda { get; set; }
        public string Moneda { get; set; }
        public string Ambiente { get; set; }

        public void MostrarConfiguracion(string moduloOrigen)
        {
            Console.WriteLine($"[{moduloOrigen}] Tienda: {NombreTienda} | Moneda: {Moneda} | Ambiente: {Ambiente}");
        }
    }
}