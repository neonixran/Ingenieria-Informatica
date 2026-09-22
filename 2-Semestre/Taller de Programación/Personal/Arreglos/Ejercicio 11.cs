/*
Hacer un programa en python que lea n números, y que los guarde en un arreglo, sólo si los elementos
son múltiplos de 3. Imprimir el arreglo final.
*/

using System;
using System.Collections.Generic;

namespace Ejercicio_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> A = new List<int>();

            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ingrese un número #{i}: ");
                int dato = Convert.ToInt32(Console.ReadLine());

                if (dato % 3 == 0)
                {
                    A.Add(dato);
                }
            }

            Console.WriteLine($"\nMúltiplos de 3: {string.Join(", ", A)}");
        }
    }
}