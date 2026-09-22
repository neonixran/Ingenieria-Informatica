// Suma de 2 números e imprimir el resultado

using System;

namespace Ejercicio_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa suma 2 números\n");

            Console.Write("Ingrese el Primer Número: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            int Sum = Num1 + Num2;
            Console.WriteLine($"El resultado de {Num1} + {Num2} es {Sum}");
        }
    };
};