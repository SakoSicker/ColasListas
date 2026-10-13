using System;

namespace ColasListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colas cola = new Colas();

            cola.Agregar("Cliente 1");
            cola.Agregar("Cliente 2");
            cola.Agregar("Cliente 3");

            Console.WriteLine("Estado inicial de la cola:");
            Console.WriteLine(cola.ObtenerDatos());

            cola.Agregar("Cliente 4");
            Console.WriteLine("Después de agregar al Cliente 4:");
            Console.WriteLine(cola.ObtenerDatos());

            cola.Eliminar();
            Console.WriteLine("Después de atender (eliminar) al frente:");
            Console.WriteLine(cola.ObtenerDatos());
        }
    }
}