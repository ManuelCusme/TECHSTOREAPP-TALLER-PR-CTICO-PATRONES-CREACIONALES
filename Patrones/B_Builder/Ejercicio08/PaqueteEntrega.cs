using System;

namespace TechStoreAppTaller.Patrones.B_Builder.Ejercicio08
{
    public class PaqueteEntrega
    {
        public string TipoCaja { get; set; } = string.Empty;
        public string Proteccion { get; set; } = string.Empty;
        public bool Seguro { get; set; }
        public bool EtiquetaFragil { get; set; }
        public string Observacion { get; set; } = string.Empty;

        public void MostrarDetalle()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Tipo de Caja: {TipoCaja} | Protección: {Proteccion}");
            Console.WriteLine($"Seguro Incluido: {Seguro} | Etiqueta Frágil: {EtiquetaFragil}");
            Console.WriteLine($"Observación: {(string.IsNullOrEmpty(Observacion) ? "Sin observaciones" : Observacion)}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}