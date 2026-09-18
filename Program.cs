using System;
using TechStoreAppTaller.Patrones.E_Prototype.Ejercicio17;
using TechStoreAppTaller.Patrones.E_Prototype.Ejercicio18;
using TechStoreAppTaller.Patrones.E_Prototype.Ejercicio19;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO 17: Prototype (Pedido Base) ---");
        PedidoPrototype basePedido = new PedidoPrototype
        {
            Producto = "PC",
            Precio = 700m,
            TipoEntrega = "NORMAL",
            RequiereFactura = true
        };

        PedidoPrototype pedido1 = basePedido.Clonar();
        pedido1.Cliente = "Juan";
        pedido1.Direccion = "Quito";

        PedidoPrototype pedido2 = basePedido.Clonar();
        pedido2.Cliente = "Maria";
        pedido2.Direccion = "Guayaquil";

        pedido1.MostrarInfo();
        pedido2.MostrarInfo();

        Console.WriteLine("\n--- EJERCICIO 18: Prototype (Computadoras Lab) ---");
        ComputadoraPrototype pcBase = new ComputadoraPrototype { Procesador = "Intel i5", MemoriaRam = 16 };
        
        var labA = pcBase.Clonar(); labA.NombreEquipo = "LAB-A"; labA.MemoriaRam = 16;
        var labB = pcBase.Clonar(); labB.NombreEquipo = "LAB-B"; labB.MemoriaRam = 32;
        var labC = pcBase.Clonar(); labC.NombreEquipo = "LAB-C"; labC.MemoriaRam = 64;

        labA.MostrarInfo(); labB.MostrarInfo(); labC.MostrarInfo();

        Console.WriteLine("\n--- EJERCICIO 19: Prototype Deep Copy (Servidores) ---");
        ServidorPrototype srvOriginal = new ServidorPrototype 
        { 
            NombreServidor = "Srv-Prod", 
            Red = new ConfiguracionRed { Ip = "192.168.1.1", Puerto = 80 } 
        };
        
        ServidorPrototype srvClon = srvOriginal.Clonar();
        srvClon.NombreServidor = "Srv-Backup";
        srvClon.Red.Ip = "10.0.0.1";

        Console.WriteLine("Original:"); srvOriginal.MostrarInfo();
        Console.WriteLine("Copia independiente:"); srvClon.MostrarInfo();
    }
}