/*
Calcular e imprimir el valor de una cuota en pesos (CLP) de un crédito hipotecario expresado en UF.
    a) El valor de la UF es el valor del día.
    b) El valor del crédito debe ser ingresado por el usuario.
*/

using System;

namespace Ejercicio_7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el valor de una cuota en pesos (CLP) de un crédito hipotecario expresado en UF.\n");

            double uf, cuota;

            do
            {
                Console.Write("Ingrese el valor actual de la UF: ");
                uf = Convert.ToDouble(Console.ReadLine());

                if (uf <= 0)
                {
                    Console.WriteLine("[!] El valor de la UF no puede ser menor o igual a 0");
                }
            } while (uf <= 0);

            do
            {
                Console.Write("Ingrese el valor de la cuota en UF: ");
                cuota = Convert.ToDouble(Console.ReadLine());

                if (cuota <= 0)
                {
                    Console.WriteLine("[!] El valor de la cuota no puede ser menor o igual a 0");
                }
            } while (cuota <= 0);

            double cuota_clp = cuota * uf;
            Console.WriteLine($"\nEl valor de la cuota es de ${cuota_clp}");
        }
    }
}