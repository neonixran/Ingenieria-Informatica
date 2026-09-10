/*
Hacer un programa que lea 10 números, los guarde en un arreglo, busque el menor y el mayor
de los elementos y los imprima

Pasos:
    1. Crear un arreglo vacio.
    2. Leer 10 números y guardarlos en el arreglo creado en el paso 1.
    3. Crear 2 variables, una para buscar el número menor y el mayor.
    4. Imprimir los valores de las variables del paso 3.
*/

using System;
using System.Linq;

namespace Ejercicio_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[10];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Ingrese el elemento #{i + 1}: ");
                int dato = Convert.ToInt32(Console.ReadLine());

                A[i] = dato;
            }

            int menor = A.Min();
            int mayor = A.Max();

            Console.WriteLine($"El menor de los elementos es {menor} y el mayor es {mayor}");
        }
    }
}