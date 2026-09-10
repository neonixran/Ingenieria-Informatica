/*
Hacer un programa en python que lea 10 números, los guarde en un arreglo A, luego lea otros 10
números, los guarde en un arreglo B, sume los números y guarde el resultado en un arreglo C. Imprima
los 3 arreglos.

Pasos:
    1. Crear 3 arreglos
    2. En los primeros 2 arreglos usar un bucle for que lea 10 números de forma independiente y guardarlos en el arreglo correspondiente.
    3. En el último arreglo, usar un bucle for.
        3-1. Crear una variable que almacene la suma de los números de ambos arreglos.
        3-2. guardar el resultado de cada suma al último arreglo.
    4. Imprimir los arreglos (num1, num2 y resultados)
*/

using System;

namespace Ejercicio_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int longitud = 10;

            int[] A = new int[longitud];
            int[] B = new int[longitud];
            int[] C = new int[longitud];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Ingrese un número 1.{i + 1}: ");
                int dato = Convert.ToInt32(Console.ReadLine());

                A[i] = dato;
            }

            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"Ingrese un número 2.{i + 1}: ");
                int dato = Convert.ToInt32(Console.ReadLine());

                A[i] = dato;
            }

            for (int i = 0; i < C.Length; i++)
            {
                int suma = A[i] + B[i];
                C[i] = suma;
            }

            Console.WriteLine($"\nA: {string.Join(", ", A)}");
            Console.WriteLine($"B: {string.Join(", ", B)}");
            Console.WriteLine($"Resultados: {string.Join(", ", C)}");
        }
    }
}