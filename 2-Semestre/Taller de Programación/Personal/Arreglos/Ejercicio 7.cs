/*
Hacer un programa que lea 10 números, los guarde en un arreglo A, y luego los traspase al revés
a un arreglo B. Imprimir ambos arreglos.
*/

using System;

namespace Ejercicio_7
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

            Console.WriteLine($"Original: {string.Join(", ", A)}");
            Array.Reverse(A); // Invierte el arreglo
            Console.WriteLine($"Inversa: {string.Join(", ", A)}");
        }
    }
}