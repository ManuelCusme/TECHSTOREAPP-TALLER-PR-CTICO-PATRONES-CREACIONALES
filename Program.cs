using System;
using TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio01;
using TechStoreAppTaller.Patrones.A_FactoryMethod.Ejercicio02;
using TechStoreAppTaller.Patrones.B_Builder.Ejercicio05_06;
using TechStoreAppTaller.Patrones.B_Builder.Ejercicio07;
using TechStoreAppTaller.Patrones.C_Singleton.Ejercicio09_10;
using TechStoreAppTaller.Patrones.C_Singleton.Ejercicio11;
using TechStoreAppTaller.Patrones.C_Singleton.Ejercicio12;
using TechStoreAppTaller.Patrones.D_AbstractFactory.Ejercicio13_14;
using TechStoreAppTaller.Patrones.E_Prototype.Ejercicio17;

class Program
{
    static void Main(string[] args)
    {
        // Plantilla Base (Prototype - Ejercicio 17 / 20)
        PedidoPrototype plantillaBase = new PedidoPrototype
        {
            Producto = "PC Escritorio Standar Lab",
            Precio = 700.00m,
            TipoEntrega = "NORMAL",
            RequiereFactura = true,
            Direccion = "Matriz TechStore"
        };

        bool salir = false;

        while (!salir)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n========================================");
            Console.WriteLine("               TECHSTORE                ");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine("1. Crear pedido NORMAL");
            Console.WriteLine("2. Crear pedido PREMIUM");
            Console.WriteLine("3. Crear pedido CORPORATIVO");
            Console.WriteLine("4. Crear pedido desde plantilla");
            Console.WriteLine("5. Probar notificaciones");
            Console.WriteLine("6. Probar Builder");
            Console.WriteLine("7. Mostrar contador de pedidos");
            Console.WriteLine("8. Mostrar configuración");
            Console.WriteLine("0. Salir");
            Console.Write("\nSeleccione una opción: ");

            string opcion = Console.ReadLine() ?? string.Empty;
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    ProcesarVenta(new VentaNormalFactory(), "NORMAL");
                    break;
                case "2":
                    ProcesarVenta(new VentaPremiumFactory(), "PREMIUM");
                    break;
                case "3":
                    ProcesarVenta(new VentaCorporativaFactory(), "CORPORATIVO");
                    break;
                case "4":
                    // Prototype + Builder + Singleton
                    PedidoPrototype copia = plantillaBase.Clonar();
                    copia.Cliente = "Carlos Pérez";
                    copia.Direccion = "Av. Cevallos y Montalvo, Ambato";

                    ContadorPedidos.Instancia.Incrementar();
                    Bitacora.Instancia.Registrar($"Pedido creado desde plantilla para cliente {copia.Cliente}");

                    Console.WriteLine(">>> PEDIDO DESDE PLANTILLA PROTOTYPE:");
                    copia.MostrarInfo();
                    break;
                case "5":
                    Console.WriteLine("Seleccione Notificación: 1. Email | 2. SMS | 3. WhatsApp");
                    string subNoti = Console.ReadLine() ?? "1";
                    NotificacionFactory nFactory = subNoti switch
                    {
                        "1" => new EmailFactory(),
                        "2" => new SmsFactory(),
                        _ => new WhatsAppFactory()
                    };
                    nFactory.CrearNotificacion().Enviar("Su pedido ha cambiado de estado.");
                    break;
                case "6":
                    Console.WriteLine(">>> DEMOSTRACIÓN BUILDER COMPUTADORA:");
                    var pcGamer = new ComputadoraBuilder()
                        .ConProcesador("Intel i9 14th Gen")
                        .ConRamGB(32)
                        .ConDiscoGB(1000)
                        .ConTarjetaGrafica("RTX 4080")
                        .ConSistemaOperativo("Windows 11")
                        .TieneWifi(true)
                        .Construir();
                    pcGamer.MostrarDetalle();
                    break;
                case "7":
                    Console.WriteLine($"Total acumulado en Singleton Contador: {ContadorPedidos.Instancia.Total}");
                    break;
                case "8":
                    ConfiguracionApp.Instancia.MostrarConfiguracion("Menú Principal");
                    break;
                case "0":
                    salir = true;
                    Console.WriteLine("Saliendo de la aplicación TechStore...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void ProcesarVenta(IVentaFactory ventaFactory, string modalidad)
    {
        // Abstract Factory
        IEntrega entrega = ventaFactory.CrearEntrega();
        IEmpaque empaque = ventaFactory.CrearEmpaque();

        // Builder
        Pedido pedido = new PedidoBuilder()
            .ConCliente("Cliente Tech")
            .ConProducto("Laptop Pro 15\"")
            .ConPrecio(1200m)
            .ConDireccion("Ambato, Ecuador")
            .ConEntrega(modalidad)
            .RequiereFactura(true)
            .Construir();

        // Singleton
        ContadorPedidos.Instancia.Incrementar();
        Bitacora.Instancia.Registrar($"Pedido registrado en modalidad {modalidad}");

        // Factory Method
        NotificacionFactory notiFactory = new EmailFactory();
        notiFactory.CrearNotificacion().Enviar("Registro exitoso.");

        Console.WriteLine($"\n--- DETALLE DE PROCESAMIENTO ({modalidad}) ---");
        pedido.MostrarDetalle();
        entrega.Procesar();
        empaque.Empacar();
    }
}