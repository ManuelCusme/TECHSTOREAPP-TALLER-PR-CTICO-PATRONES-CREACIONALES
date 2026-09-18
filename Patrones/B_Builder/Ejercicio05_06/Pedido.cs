using System;

namespace TechStoreAppTaller.Patrones.B_Builder.Ejercicio05_06
{
    public class Pedido
    {
        public string Cliente { get; set; } = string.Empty;
        public string Producto { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Observacion { get; set; } = string.Empty;
        public string TipoEntrega { get; set; } = string.Empty;
        public bool RequiereFactura { get; set; }

        public void MostrarDetalle()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Cliente: {Cliente}");
            Console.WriteLine($"Producto: {Producto} | Precio: ${Precio:F2}");
            Console.WriteLine($"Dirección: {Direccion} | Teléfono: {Telefono}");
            Console.WriteLine($"Entrega: {TipoEntrega} | Requiere Factura: {RequiereFactura}");
            Console.WriteLine($"Observación: {(string.IsNullOrEmpty(Observacion) ? "N/A" : Observacion)}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}