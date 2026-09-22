using System.Globalization;

namespace Practico4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("COTIZADOR DE HARDWARE");

            double precioTotal = 0;

            int cantidadServidores;
            bool entradaServidores;

            do
            {
                Console.Write("Ingrese la cantidad de servidores (entero > 0): ");
                entradaServidores = int.TryParse(Console.ReadLine(), out cantidadServidores);

                if (!entradaServidores || cantidadServidores < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (!entradaServidores)
                    {
                        Console.WriteLine("Error: Ingrese un número válido");
                    }
                    else if (cantidadServidores <= 0)
                    {
                        Console.WriteLine("Error: Ingrese una cantidad mayor a 0");
                    }
                    Console.ResetColor();
                }
            }
            while (!entradaServidores || cantidadServidores <= 0);

            for (int i = 1; i <= cantidadServidores; i++)
            {
                Console.WriteLine($"\nServidor {i}");
                double precioServidor = 0;
                bool entradaPrecio = false;

                do {
                    Console.Write("Ingrese el precio del servidor (USD): $");
                    entradaPrecio = double.TryParse(Console.ReadLine(), out precioServidor);
                    
                    Console.ForegroundColor = ConsoleColor.Red;

                    if (!entradaPrecio) {
                        Console.WriteLine("Error: Ingrese un número válido");
                    } else if (precioServidor <= 0) {
                        Console.WriteLine("Error: Ingrese un precio mayor a 0");
                    }
                    
                    Console.ResetColor();
                } while (!entradaPrecio || precioServidor <= 0);

                precioTotal += precioServidor;
            }

            Console.WriteLine($"\nCantidad de servidores: {cantidadServidores}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Costo total: ${precioTotal} USD");
            Console.WriteLine($"Costo promedio por servidor: ${precioTotal / cantidadServidores} USD");
        }
    }
}
