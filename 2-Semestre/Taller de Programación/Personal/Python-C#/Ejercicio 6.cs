/*
Transforme pesos (CPL) a dólares (USD), imprimiendo el resultado en pantalla.
La cantidad de pesos (CLP) es ingresada por el usuario.
*/

using System;

namespace Ejercicio_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double usd, clp;

            do
            {
                Console.Write("Ingrese el valor del dólar actual: ");
                usd = Convert.ToDouble(Console.ReadLine());

                if (usd <= 0)
                {
                    Console.WriteLine("[!] El valor del dólar no puede ser menor o igual a 0");
                }
            } while (usd <= 0);

            do
            {
                Console.Write("Ingrese la cantidad de pesos (CLP): ");
                clp = Convert.ToDouble(Console.ReadLine());

                if (clp <= 0)
                {
                    Console.WriteLine("[!] La cantidad de pesos Chilenos no puede ser menor o igual a 0");
                }
            } while (clp <= 0);

            double conversión = clp / usd;
            Console.WriteLine($"\n${clp} pesos Chilenos a dólares son {conversión}");
        }
    }
}