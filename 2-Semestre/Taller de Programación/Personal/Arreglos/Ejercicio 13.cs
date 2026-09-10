/*
Hacer un programa en python que lea n números y los guarde en un arreglo A, ordenar el arreglo de
mayor a menor e imprimir (sólo se debe usar 1 arreglo).
*/

using System;
using System.Collections.Generic;

namespace Ejercicio_13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[5];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Ingrese un número #{i + 1}: ");
                int dato = Convert.ToInt32(Console.ReadLine());

                A[i] = dato;
            }

			Array.Sort<int>(arr, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1))); // Sortear de mayor a menor
            Console.WriteLine($"\nArreglo A (Mayor a Menor): {string.Join(", ", A)}");
        }
    }
}