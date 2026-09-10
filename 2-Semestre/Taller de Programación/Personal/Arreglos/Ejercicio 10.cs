/*
Hacer un programa en python que lea n números, los guarde en un arreglo busque los elementos
pares y los cambie por unos (1), luego imprima el arreglo modificado
*/

using System;

namespace Ejercicio_10
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

                if (dato % 2 == 0)
                {
                    A[i] = 1;
                }
                else
                {
                    A[i] = dato;
                }
            }

            Console.WriteLine($"\n{string.Join(",", A)}");
        }
    }
}