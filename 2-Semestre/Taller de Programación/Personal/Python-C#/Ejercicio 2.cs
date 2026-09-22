/*
Conversión de una longitud dada en centímetros a pies.
Los centímetros son ingresados por el usuario. Considere que: 1 pie = 30.48 centímetros.
*/

using System;

namespace Ejercicio_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa convierte centímetros a pies\n");

            double cm;

            do
            {
                Console.Write("Ingrese la longitud en cm: ");
                cm = Convert.ToDouble(Console.ReadLine());

                if (cm <= 0)
                {
                    Console.WriteLine("[!] La longitud debe ser mayor a 0.");
                }
            } while (cm <= 0);

            double ft = cm / 30.48;

            Console.WriteLine($"La longitud en pies es de {ft} ft");
        }
    }
}