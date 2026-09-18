using System;
using System.Collections.Generic;

namespace TechStoreAppTaller.Patrones.C_Singleton.Ejercicio09_10
{
    public sealed class Bitacora
    {
        private static readonly Lazy<Bitacora> _instancia = new Lazy<Bitacora>(() => new Bitacora());
        private readonly List<string> _historial = new List<string>();

        private Bitacora()
        {
            Registrar("Bitácora del sistema inicializada.");
        }

        public static Bitacora Instancia => _instancia.Value;

        public void Registrar(string mensaje)
        {
            string entrada = $"[{DateTime.Now:HH:mm:ss}] {mensaje}";
            _historial.Add(entrada);
            Console.WriteLine($"[BITÁCORA]: {entrada}");
        }

        public void MostrarHistorial()
        {
            Console.WriteLine("\n--- HISTORIAL DE LA BITÁCORA ---");
            foreach (var log in _historial)
            {
                Console.WriteLine(log);
            }
            Console.WriteLine("--------------------------------");
        }
    }
}