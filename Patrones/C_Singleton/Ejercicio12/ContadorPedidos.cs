using System;

namespace TechStoreAppTaller.Patrones.C_Singleton.Ejercicio12
{
    public sealed class ContadorPedidos
    {
        private static readonly Lazy<ContadorPedidos> _instancia = new Lazy<ContadorPedidos>(() => new ContadorPedidos());
        private int _total = 0;

        private ContadorPedidos() { }

        public static ContadorPedidos Instancia => _instancia.Value;

        public int Total => _total;

        public void Incrementar()
        {
            _total++;
            Console.WriteLine($"[CONTADOR GLOBAL]: Se ha registrado un nuevo pedido. Total acumulado: {_total}");
        }
    }
}