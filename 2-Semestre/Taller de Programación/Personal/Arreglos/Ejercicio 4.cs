/*
Hacer un programa que dado 1 arreglo con los números del 1 al 10 genere las tablas de
multiplicar y las imprima como tabla con sus resultados.

Pasos:
    1. Crear un arreglo con números del 1 al 10
    2. Recorrer el arreglo hasta el 10 creado en el paso 1 usando un bucle for.
    3. Usar un bucle for anidado al del paso 2 recorriendo del 1 al 10 (siempre se agrega 1 más).
    4. Imprimir las tablas de multiplicar
*/

using System;

namespace Ejercicio_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"\nTabla del {A[i]}");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{A[i]} * {j} = {A[i] * j}");
                }
            }
        }
    }
}