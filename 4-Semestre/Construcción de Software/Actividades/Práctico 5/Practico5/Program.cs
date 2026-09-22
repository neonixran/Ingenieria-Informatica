using System.Globalization;

namespace Practico5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            double tasaIva = 0.19; 
            double porcentajeDescuento = 0.1;

            MostrarEncabezado();

            double costoServidor = SolicitarCostoServidores();
            double costoAlmacenamiento = SolicitarCostoAlmacenamiento();

            double subtotalNeto = CalcularNeto(costoServidor, costoAlmacenamiento);
            double descuento = CalcularDescuentoCorporativo(subtotalNeto, porcentajeDescuento);
            double subtotalConDescuento = CalcularNetoConDescuento(subtotalNeto, descuento);
            double iva = CalcularIva(subtotalConDescuento, tasaIva);
            double total = CalcularTotal(subtotalConDescuento, iva);

            MostrarDetallePlan(costoServidor, costoAlmacenamiento, porcentajeDescuento, descuento, subtotalConDescuento, iva, total);

            Console.WriteLine("Presione cualquier tecla para finalizar la aplicación...");
            Console.ReadKey();
        }

        static void MostrarEncabezado()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=======================================================");
            Console.WriteLine("                   CONSULTORA PEPITO                   ");
            Console.WriteLine("         IP VIRGINIO GÓMEZ  -  SEDE CONCEPCIÓN         ");
            Console.WriteLine("=======================================================");
            Console.ResetColor();
        }

        static double SolicitarCostoServidores()
        {
            double entrada;
            bool esValido;

            do
            {
                Console.Write("Ingrese el costo de los servidores: $");
                esValido = double.TryParse(Console.ReadLine() ?? "0", out entrada);

                if (!esValido || entrada <= 0.0 || entrada >= 10000.0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Error] Ingrese un número válido entre $1 y $9.999.");
                    Console.ResetColor();
                    esValido = false;
                }
            }
            while (!esValido);

            return entrada;
        }

        static double SolicitarCostoAlmacenamiento()
        {
            double entrada;
            bool esValido;

            do
            {
                Console.Write("Ingrese el costo de almacenamiento: $");
                esValido = double.TryParse(Console.ReadLine() ?? "0", out entrada);

                if (!esValido)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Error] Ingrese un número válido.");
                    Console.ResetColor();
                    esValido = false;
                }
            }
            while (!esValido);

            return entrada;
        }

        static double CalcularDescuentoCorporativo(double subtotalNeto, double porcentajeDescuento)
        {
            return subtotalNeto * porcentajeDescuento;
        }

        static double CalcularIva(double subtotalFinal, double tasaIva)
        {
            return subtotalFinal * tasaIva;
        }

        static double CalcularNeto(double servidores, double almacenamiento)
        {
            return servidores + almacenamiento;
        }

        static double CalcularNetoConDescuento(double subtotalNeto, double descuento)
        {
            return subtotalNeto - descuento;
        }

        static double CalcularTotal(double subtotalFinal, double iva)
        {
            return subtotalFinal + iva;
        }

        static void MostrarDetallePlan(double servidores, double almacenamiento, double porcentajeDescuento, double descuento, double netoFinal, double iva, double totalConIva)
        {
            Console.WriteLine("\n=======================================================");
            Console.WriteLine("                 RESUMEN DE PRESUPUESTO                ");
            Console.WriteLine("=======================================================");
            Console.WriteLine($"Servidores:          $ {servidores:N2} USD");
            Console.WriteLine($"Almacenamiento:      $ {almacenamiento:N2} USD");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Descuento ({porcentajeDescuento * 100}%):     $ {descuento:N2} USD");
            Console.WriteLine($"Neto final:          $ {netoFinal:N2} USD");
            Console.WriteLine($"Impuesto IVA (19%):  $ {iva:N2} USD");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"TOTAL COTIZADO:      $ {totalConIva:N2} USD");
            Console.ResetColor();
            Console.WriteLine("=======================================================\n");
        }
    }
}
