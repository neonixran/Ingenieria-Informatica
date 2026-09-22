/*
Calcular e imprimir el valor de un dividendo en pesos (CLP) para un crédito de 2500 UF a 30 años.
El valor de la UF es el valor del día.
*/

using System;

namespace Ejercicio_10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el valor de un dividendo en pesos (CLP) para un crédito de 2500 UF a 30 años\n");

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

            double cuota = 2500 * uf / (30 * 12);

            Console.WriteLine($"La cuota del dividendo es de ${cuota}");
        }
    }
}