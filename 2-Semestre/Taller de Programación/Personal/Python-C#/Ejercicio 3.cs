/*
Conversión de una longitud dada en pies a centímetros.
Los pies son ingresados por el usuario. Considere que: 1 pie = 30.48 centímetros.
*/

using System;

namespace Ejercicio_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa convierte pies a centimetros\n");

            double ft;
            do
            {
                Console.Write("Ingrese la longitud en pies: ");
                ft = Convert.ToDouble(Console.ReadLine());

                if (ft <= 0)
                {
                    Console.WriteLine("[!] La longitud no puede ser menor o igual a 0.");
                }
            } while (ft <= 0);

            double cm = ft * 30.48;
            Console.WriteLine($"La longitud en centimetros es de {cm} cm");
        }
    }
}