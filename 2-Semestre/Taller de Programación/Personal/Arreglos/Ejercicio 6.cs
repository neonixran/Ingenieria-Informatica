/*
Hacer un programa en python que lea números desde teclado (el usuario debe determinar cuántos)
que los guarde en un arreglo, luego pregunte al usuario un número, multiplique los números iniciales
por el último número ingresado y muestre los valores finales.
*/

using System;

namespace Ejercicio_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[1];

            int dato = 1;
            
            do
            {
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write("Ingrese un número (0 para salir): ");
                    dato = Convert.ToInt32(Console.ReadLine());

                    if (dato != 0)
                    {
                        Array.Resize(ref A, A.Length + 1);
                        A[i] = dato;
                    }
                    else
                    {
                        Array.Resize(ref A, A.Length - 1);
                        break;
                    }
                }
            } while (dato != 0);

            Console.Write("\nIngrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"{num} * {A[i]} = {num * A[i]}");
            }
        }
    }
}