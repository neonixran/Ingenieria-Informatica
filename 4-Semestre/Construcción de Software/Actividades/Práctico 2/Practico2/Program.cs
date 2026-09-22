using System;

namespace Practico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Entrada de datos con su respectivo parseo si es que corresponde.
            Console.Write("Ingrese el nombre de la empresa cliente: ");
            string nombreCliente = Console.ReadLine();

            Console.Write("Ingrese la cantidad de licencias corporativas requeridas: ");
            int cantidadLicencias = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario de lista por licencia (CLP): ");
            int precioUnitario = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el porcentaje de descuento comercial a aplicar: ");
            double descuentoComercial = double.Parse(Console.ReadLine());

            // 2. Cálculos
            int subtotalNeto = cantidadLicencias * precioUnitario;
            double montoDescuento = subtotalNeto * (descuentoComercial / 100);
            double subtotalConDescuento = subtotalNeto - montoDescuento;
            double tasaIva = 0.19;
            double impuestoIva = subtotalConDescuento * tasaIva;
            double totalCotizacion = subtotalConDescuento + impuestoIva;

            // 3. Salida de datos en consola
            Console.WriteLine("\n========================================================");
            Console.WriteLine("             RESUMEN DE COTIZACIÓN DE CLIENTE");
            Console.WriteLine("========================================================");
            Console.WriteLine($"Nombre empresa cliente:            {nombreCliente}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Subtotal de la compra:             {subtotalNeto:C0} CLP");
            Console.WriteLine($"Monto del descuento otorgado:      {montoDescuento:C0} CLP");
            Console.WriteLine($"Subtotal con descuento:            {subtotalConDescuento:C0} CLP");
            Console.WriteLine($"IVA (19%):                         {impuestoIva:C0} CLP");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Total neto:                        {totalCotizacion:C0} CLP");
            Console.WriteLine("========================================================\n");

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
