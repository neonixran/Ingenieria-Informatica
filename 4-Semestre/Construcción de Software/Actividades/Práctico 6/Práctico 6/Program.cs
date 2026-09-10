using System.Globalization;

namespace Práctico_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Encabezado
            MostrarEncabezado();

            // Entradas
            string proyecto = SolicitarNombreProyecto();
            int desarrolladores = SolicitarDesarrolladores();
            double tarifaHora = SolicitarTarifaHora();

            // Cálculos
            int totalHorasDev = 160;
            double tasaImpuestos = 0.1375;

            double costoManoObra = CalcularCostoManoObra(desarrolladores, tarifaHora, totalHorasDev);
            double retencionHonorarios = CalcularImpuestoRetencion(costoManoObra, tasaImpuestos);
            double totalNeto = CalcularTotalNeto(costoManoObra, retencionHonorarios);

            // Resultados
            MostrarInformeFinal(proyecto, desarrolladores, costoManoObra, retencionHonorarios, totalNeto);

            Console.Write("Presione cualquier tecla para finalizar la aplicación...");
            Console.ReadKey();
        }

        static void MostrarEncabezado()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=======================================================");
            Console.WriteLine("         PRESUPUESTOS DE PROYECTOS DE SOFTWARE         ");
            Console.WriteLine("         IP VIRGINIO GÓMEZ  -  SEDE CONCEPCIÓN         ");
            Console.WriteLine("=======================================================");
            Console.ResetColor();
        }

        static string SolicitarNombreProyecto()
        {
            string entrada;

            do
            {
                Console.Write("Ingrese el nombre del proyecto: ");
                entrada = Console.ReadLine();

                if (string.IsNullOrEmpty(entrada))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Error]: Debe ingresar el nombre del proyecto");
                    Console.ResetColor();
                }
            }
            while (string.IsNullOrEmpty(entrada));

            return entrada;
        }

        static int SolicitarDesarrolladores()
        {
            int entrada;
            bool esValido;

            do
            {
                Console.Write("Ingrese la cantidad de desarrolladores: ");
                esValido = int.TryParse(Console.ReadLine(), out entrada);

                if (!esValido || entrada < 1 || entrada > 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Error]: Debe ingresar una cantidad entre 1 y 15\n");
                    Console.ResetColor();
                }
            }
            while (!esValido || entrada < 1 || entrada > 15);

            return entrada;
        }

        static double SolicitarTarifaHora()
        {
            double entrada;
            bool esValido;

            do
            {
                Console.Write("Ingrese la tarifa por hora: $");
                esValido = double.TryParse(Console.ReadLine(), out entrada);

                if (!esValido || entrada < 15.5 || entrada > 150.0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Error]: Debe ingresar una cantidad entre $15.5 y $150\n");
                    Console.ResetColor();
                }
            }
            while (!esValido || entrada < 15.5 || entrada > 150.0);

            return entrada;
        }

        static double CalcularCostoManoObra(int numDevs, double valorHora, int totalHorasPorDev)
        {
            return numDevs * valorHora * totalHorasPorDev;
        }

        static double CalcularImpuestoRetencion(double montoBruto, double tasaImpuesto)
        {
            return montoBruto * tasaImpuesto;
        }

        static double CalcularTotalNeto(double manoObra, double retencion)
        {
            return manoObra - retencion;
        }

        static void MostrarInformeFinal(string proyecto, int devs, double manoObra, double retencion, double totalNeto)
        {
            Console.WriteLine("\n=======================================================");
            Console.WriteLine("                 RESUMEN DE PRESUPUESTO                ");
            Console.WriteLine("=======================================================");
            Console.WriteLine($"Nombre del proyecto:              {proyecto}          ");
            Console.WriteLine($"Cantidad desarrolladores:         {devs}              ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Mano de obra:                     $ {manoObra:N2} USD ");
            Console.WriteLine($"Retención de honorarios:          $ {retencion:N2} USD\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"TOTAL NETO:                       $ {totalNeto:N2} USD");
            Console.ResetColor();
            Console.WriteLine("=======================================================\n");
        }
    }
}
