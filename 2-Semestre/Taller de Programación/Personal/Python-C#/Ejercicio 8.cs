/*
Calcular la cantidad de tazas de té que pueden ser servidas con N litros de agua y donde cada taza tiene una capacidad de 200 cc.
Debe tener en cuenta que 1 litro = 1000 cc.
N debe ser ingresado por el usuario.
*/

using System;

namespace Ejercicio_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula cuantas tazas de té se pueden servir con N litros de agua\n");

            double litros;

            do
            {
                Console.Write("Ingrese la cantidad de litros de agua: ");
                litros = Convert.ToDouble(Console.ReadLine());

                if (litros <= 0)
                {
                    Console.WriteLine("[!] La cantidad de litros no puede ser menor o igual a 0");
                }
            } while (litros <= 0);

            litros *= 1000; // Convertir litros a cc, 1 litro = 1000 cc
            double tazas = litros / 200;

            Console.WriteLine($"\nSe pueden servir {tazas} tazas de té");
        }
    }
}