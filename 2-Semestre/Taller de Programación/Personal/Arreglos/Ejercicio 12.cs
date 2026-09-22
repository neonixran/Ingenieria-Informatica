/*
Hacer un programa en python que lea n números y los guarde en un arreglo A, ordenar los números
de menor a mayor y guardarlos ordenados en un arreglo B, imprimir ambos arreglos.
*/

using System;
using System.Collections.Generic;

namespace Ejercicio_12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> A = new List<int>();

            int n = 4;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ingrese un número #{i}: ");
                int dato = Convert.ToInt32(Console.ReadLine());

                A.Add(dato);
            }

			Console.WriteLine($"\nArreglo A (Original): {string.Join(", ", A)}");
            A.Sort();
            Console.WriteLine($"\nArreglo B (Ordenado): {string.Join(", ", A)}");
        }
    }
}