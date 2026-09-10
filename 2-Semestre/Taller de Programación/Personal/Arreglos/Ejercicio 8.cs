/*
Hacer un programa que lea 10 números, los ordene y muestre ordenados de menor a mayor.
*/

using System;

namespace Ejercicio_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[10];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Ingrese un número #{i + 1}: ");
                int dato = Convert.ToInt32(Console.ReadLine());

                A[i] = dato;
            }

            Array.Sort(A); // Ordena el arreglo, por defecto de menor a mayor
            Console.WriteLine($"A: {string.Join(", ", A)}");
        }
    }
}