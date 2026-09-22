/*
Hacer un programa que lea 10 elementos, los guarde en un arreglo, luego duplique los
elementos del arreglo (que queden guardados) e imprima los elementos duplicados

Pasos:
    1. Crear un arreglo vacio.
    2. Leer 10 números y guardarlos en el arreglo creado en el paso 1.
    3. Duplicar los números del arreglo.
    4. Imprimir el arreglo con los números duplicados.
*/

using System;

namespace Ejercicio_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[10]; // Se define el tipo y tamaño del Array

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Ingrese el elemento #{i + 1}: ");
                int dato = Convert.ToInt32(Console.ReadLine());

                A[i] = dato;
                A[i] *= 2;
            }

            Console.WriteLine($"Duplicada: {string.Join(", ", A)}");
        }
    }
}