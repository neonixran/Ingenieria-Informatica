/*
Calcular el costo en pesos (CLP) de una bolsa de pan que contiene N kg.
El precio de 1 kg es ingresado por el usuario.
*/

using System;

namespace Ejercicio_9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el costo en pesos (CLP) de una bolsa de pan que contiene N kg\n");

            double precio, kg;

            do
            {
                Console.Write("Ingrese el precio del kilo de pan: ");
                precio = Convert.ToDouble(Console.ReadLine());

                if (precio <= 0)
                {
                    Console.WriteLine("[!] El precio/kg no puede ser menor o igual a 0");
                }
            } while (precio <= 0);

            do
            {
                Console.Write("Ingrese la cantidad de kilos: ");
                kg = Convert.ToDouble(Console.ReadLine());

                if (kg <= 0)
                {
                    Console.WriteLine("[!] Los kilos no puede ser menores o iguales a 0");
                }
            } while (kg <= 0);

            double costo = precio * kg;

            Console.WriteLine($"El costo de la bolsa de pan es ${costo}");
        }
    }
}