/*
Hacer un programa en python que lea 10 números, los guarde en un arreglo A, verifique si son pares
o impares, los pares los guarde en un arreglo llamado PAR, y los impares en uno llamado IMPAR.
Finalmente debe imprimir los arreglos A, PAR e IMPAR.
*/

using System;
using System.Collections.Generic; // Necesario para poder hacer uso de List

namespace Ejercicio_9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[10];
            List<int> PAR = new List<int>(); // Se usa una lista para poder agregar elementos dinámicamente sin definir previamente el tamaño
            List<int> IMPAR = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Ingrese un número #{i + 1}: ");
                int dato = Convert.ToInt32(Console.ReadLine());

                A[i] = dato;

                if (dato % 2 == 0) // Si es par
                {
                    PAR.Add(dato);
                }
                else // Si es impar
                {
                    IMPAR.Add(dato);
                }
            }

            Console.WriteLine($"\nNúmeros: {string.Join(", ", A)}");
            Console.WriteLine($"Números Pares: {string.Join(", ", PAR)}");
            Console.WriteLine($"Números Impares: {string.Join(", ", IMPAR)}");
        }
    }
}