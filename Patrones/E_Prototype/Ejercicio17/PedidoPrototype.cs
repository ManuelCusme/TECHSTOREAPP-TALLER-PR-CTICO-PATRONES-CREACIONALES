using System;

namespace TechStoreAppTaller.Patrones.E_Prototype.Ejercicio17
{
    public class PedidoPrototype
    {
        public string Cliente { get; set; } = string.Empty;
        public string Producto { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string TipoEntrega { get; set; } = string.Empty;
        public bool RequiereFactura { get; set; }
        public string Direccion { get; set; } = string.Empty;

        public PedidoPrototype Clonar()
        {
            return (PedidoPrototype)this.MemberwiseClone();
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Cliente: {Cliente} | Producto: {Producto} | Precio: ${Precio:F2} | Entrega: {TipoEntrega} | Factura: {RequiereFactura} | Dir: {Direccion}");
        }
    }
}