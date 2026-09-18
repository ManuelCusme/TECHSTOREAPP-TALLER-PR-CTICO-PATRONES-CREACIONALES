using System;

namespace TechStoreAppTaller.Patrones.E_Prototype.Ejercicio18
{
    public class ComputadoraPrototype
    {
        public string NombreEquipo { get; set; } = string.Empty;
        public string Procesador { get; set; } = string.Empty;
        public int MemoriaRam { get; set; }

        public ComputadoraPrototype Clonar()
        {
            return (ComputadoraPrototype)this.MemberwiseClone();
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"[CLON] Equipo: {NombreEquipo} | CPU: {Procesador} | RAM: {MemoriaRam}GB");
        }
    }
}