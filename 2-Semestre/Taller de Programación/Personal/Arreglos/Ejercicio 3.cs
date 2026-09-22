/*
Hacer un programa que genere los 15 múltiplos de 16 que hay desde 160, guardar los múltiplos
en un arreglo

Pasos:
    1. Crear un arreglo vacio, este almacenará los múltiplos.
    2. Crear una variable de partida, empezará desde el 160.
    3. Usar un bucle for para generar 15 números.
    4. Agregar al arreglo el número inicial del paso 2.
    5. Ir sumando por 16 el número del paso 2 (el bucle for repetirá el proceso 15 veces, agregando cada número al arreglo).
    6. Imprimir el arreglo.
*/

using System;

namespace Ejercicio_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 160; // Número de partida
            int multiplo = 16;

            int[] A = new int[15];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = n;
                n += multiplo;
            }

            Console.WriteLine($"Los múltiplos de {multiplo} son {string.Join(", ", A)}");
        }
    }
}