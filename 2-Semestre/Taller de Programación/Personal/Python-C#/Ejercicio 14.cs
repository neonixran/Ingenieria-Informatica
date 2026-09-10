/*
Usted cuenta con un seguro automotriz, el cual tiene un deducible de 5 UF.
Usted debe hacer uso del seguro por un accidente pequeño, el cual tiene un costo total de $678.987.
    - Mostrar por pantalla el monto que asume la seguradora y el monto que debe pagar usted.
    - Los montos se expresan en pesos (CLP).
*/

using System;

namespace Ejercicio_14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el monto que asume la aseguradora y el monto que debe pagar usted por un accidente automotriz\n");

            int costo_total = 678987;
            double uf;

            do
            {
                Console.Write("Ingrese el valor actual de la UF: ");
                uf = Convert.ToDouble(Console.ReadLine());

                if (uf <= 0)
                {
                    Console.WriteLine("[!] El valor de la UF no puede ser menor o igual a 0");
                }
            } while (uf <= 0);

            double aseguradora = uf * 5;
            double deducible = costo_total - aseguradora;

            Console.WriteLine($"El monto que asume la aseguradora es ${aseguradora}, usted deberá pagar ${deducible}");
        }
    }
}