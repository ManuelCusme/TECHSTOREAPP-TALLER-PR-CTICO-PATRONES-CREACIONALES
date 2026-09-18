using System;

namespace TechStoreAppTaller.Patrones.B_Builder.Ejercicio07
{
    public class Computadora
    {
        public string Procesador { get; set; } = string.Empty;
        public int RamGB { get; set; }
        public int DiscoGB { get; set; }
        public string TarjetaGrafica { get; set; } = string.Empty;
        public string SistemaOperativo { get; set; } = string.Empty;
        public bool TieneWifi { get; set; }

        public void MostrarDetalle()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Procesador: {Procesador} | RAM: {RamGB} GB | Almacenamiento: {DiscoGB} GB");
            Console.WriteLine($"GPU: {TarjetaGrafica} | S.O.: {SistemaOperativo} | Wi-Fi: {TieneWifi}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}