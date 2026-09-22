using System.Globalization;

namespace Trabajo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. CONFIGURACIÓN INVARIABLE DE DECIMALES
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // 2. ORQUESTADOR DE FLUJO PRINCIPAL

            MostrarBannerInstitucional();

            string nombrePyme = SolicitarTextoNoVacio("Nombre de la PYME cliente: ");
            string comuna = SolicitarTextoNoVacio("Comuna de la PYME (ej: Concepción, Coronel): ");

            // Capturas robustas con validación
            int cantPaneles = SolicitarEnteroValido("Cantidad de paneles requeridos (1 a 200): ", 1, 200);
            double tarifaPanel = SolicitarDecimalValido("Tarifa unitaria base por panel en USD (50.0 a 1500.0): ", 50.0, 1500.0);
            double costoInversor = SolicitarDecimalValido("Costo de equipos inversores y montaje en USD (100.0 a 10000.0): ", 100.0, 10000.0);
            double dctoFomento = SolicitarDecimalValido("Porcentaje de descuento por fomento estatal (0 a 30%): ", 0.0, 30.0);
            double presupuestoMax = SolicitarDecimalValido("Presupuesto mensual límite de la PYME en USD (500.0 a 100000.0): ", 500.0, 100000.0);

            // Lógica de cálculo modular
            double subtotalNeto = CalcularSubtotal(cantPaneles, tarifaPanel, costoInversor);
            double montoDescuento = CalcularDescuentoFomento(subtotalNeto, dctoFomento);
            double netoConDescuento = subtotalNeto - montoDescuento;
            double montoIva = CalcularIvaChileno(netoConDescuento);
            double totalCotizacion = netoConDescuento + montoIva;

            // Evaluar la viabilidad económica
            bool esViable = EvaluarViabilidadEconomica(totalCotizacion, presupuestoMax);

            // Presentación visual del presupuesto
            MostrarDetalleCotizacion(nombrePyme, comuna, cantPaneles, subtotalNeto, montoDescuento, netoConDescuento, montoIva, totalCotizacion, esViable, presupuestoMax);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
        //danko
        static void MostrarBannerInstitucional()
        {
            Console.WriteLine("\n==========================================================");
            Console.WriteLine(" Bienvenido al sistema de presupuestación de energía solar");
            Console.WriteLine("==========================================================\n");
        }

        static string SolicitarTextoNoVacio(string prompt) {
            string entrada;
            do
            {
                Console.Write(prompt);
                entrada = Console.ReadLine();
                if (string.IsNullOrEmpty(entrada))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Error] La entrada no puede estar vacía. Intente de nuevo.");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(entrada));

            return entrada;
        }
        static int SolicitarEnteroValido(string prompt, int min, int max) {
            int valorResultado;
            bool esValido;

            do
            {
                Console.Write(prompt);
                string entradaRaw = Console.ReadLine() ?? "0";

                // Uso del parámetro out en TryParse para una conversión libre de colapsos
                esValido = int.TryParse(entradaRaw, out valorResultado);

                if (!esValido || valorResultado < min || valorResultado > max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[Error] Ingrese un número válido entre {min:F2} y {max:F2}.");
                    Console.ResetColor();
                    esValido = false; // Forza la repetición del ciclo
                }

            } while (!esValido);

            return valorResultado;
        }
        static double SolicitarDecimalValido(string prompt, double min, double max) {
            double valorResultado;
            bool esValido;

            do
            {
                Console.Write(prompt);
                string entradaRaw = Console.ReadLine() ?? "0";

                // Uso del parámetro out en TryParse para una conversión libre de colapsos
                esValido = double.TryParse(entradaRaw, out valorResultado);

                if (!esValido || valorResultado < min || valorResultado > max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[Error] Ingrese un número válido entre {min:F2} y {max:F2}.");
                    Console.ResetColor();
                    esValido = false; // Forza la repetición del ciclo
                }

            } while (!esValido);

            return valorResultado;
        }
        static double CalcularSubtotal(int paneles, double precioPanel, double inversores) {
            return (paneles * precioPanel) + inversores;
        }
        static double CalcularDescuentoFomento(double bruto, double dcto) {
            return bruto * (dcto / 100); // Se divide por 100 el descuento ingresado, ya que es ingresado como un entero (ej. 30)
        }
        static double CalcularIvaChileno(double netoAfecto) {
            return netoAfecto * 0.19;
        }
        static bool EvaluarViabilidadEconomica(double total, double presupuestoPyme) {
            return total <= presupuestoPyme || total <= presupuestoPyme * 1.10; // Se declara la validación según los requerimientos.
        }

        static void MostrarDetalleCotizacion(string nombrePyme, string comuna, int cantPaneles, double subtotalNeto, double montoDescuento, double netoConDescuento, double montoIva, double totalCotizacion, bool esViable, double presupuestoMax)
        {
            Console.WriteLine("\n========================================================");
            Console.WriteLine("              Resumen de cotizacion");
            Console.WriteLine("========================================================");
            Console.WriteLine($"Nombre cliente:                           {nombrePyme}");
            Console.WriteLine($"Comuna:                                   {comuna}");
            Console.WriteLine($"Presupuesto máximo:                       {presupuestoMax:N2} USD");
            Console.WriteLine("");
            Console.WriteLine($"Cantidad de Paneles:                      {cantPaneles}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Subtotal Neto:                          $ {subtotalNeto:N2} USD");
            if (montoDescuento != 0) // Si hay descuento, se muestra en la tabla de detalle de cotización; En caso contrario, no muestra la línea de descuento aplicado.
            {
                Console.WriteLine($"Descuento Fomento Estatal:              $ {montoDescuento:N2} USD");
                Console.WriteLine($"Subtotal con descuento:                 $ {netoConDescuento:N2} USD");
            }
            Console.WriteLine($"IVA (19%):                              $ {montoIva:N2} USD");
            Console.WriteLine("========================================================");
            Console.WriteLine($"TOTAL COTIZACIÓN:                       $ {totalCotizacion:N2} USD");
            if (esViable)
            {
                Console.WriteLine($"Análisis de viabilidad:                   Viable");
            }
            else
            {
                Console.WriteLine($"Análisis de viabilidad:                   No viable");
            }
            Console.WriteLine("========================================================");
        }
    }
}
