/*
Obtener el promedio de notas de un alumno.
Las evaluaciones a tomar en cuenta son:
    - certamen 1 con un 40%
    - certamen 2 con un 40%
    - un test de 20%

Las notas son ingresadas por el usuario y el promedio debe expresarse con decimales.
*/

using System;

namespace Ejercicio_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el promedio ponderado de notas de un alumno\n");

            double cert1, cert2, test, prom;
            int alumnos;

            do
            {
                Console.Write("Ingrese la cantidad de alumnos: ");
                alumnos = Convert.ToInt32(Console.ReadLine());

                if (alumnos <= 0)
                {
                    Console.WriteLine("[!] La cantidad de alumnos no puede ser menor o igual a 0");
                }
            } while (alumnos <= 0);

            for (int alumno = 0; alumno < alumnos; alumno++)
            {
                Console.WriteLine($"#{alumno + 1}");

                do
                {
                    Console.Write("Ingrese la nota del certamen 1: ");
                    cert1 = Convert.ToDouble(Console.ReadLine());

                    if (cert1 < 1 || cert1 > 7)
                    {
                        Console.WriteLine("[!] Las notas están fuera de rango");
                    }
                } while (cert1 < 1 || cert1 > 7);

                do
                {
                    Console.Write("Ingrese la nota del certamen 2: ");
                    cert2 = Convert.ToDouble(Console.ReadLine());

                    if (cert2 < 1 || cert2 > 7)
                    {
                        Console.WriteLine("[!] Las notas están fuera de rango");
                    }
                } while (cert2 < 1 || cert2 > 7);

                do
                {
                    Console.Write("Ingrese la nota del test: ");
                    test = Convert.ToDouble(Console.ReadLine());

                    if (test < 1 || test > 7)
                    {
                        Console.WriteLine("[!] Las notas están fuera de rango");
                    }
                } while (test < 1 || test > 7);

                prom = cert1 * 0.4 + cert2 * 0.4 + test * 0.2;

                Console.WriteLine($"El promedio de notas ponderado del alumno #{alumno + 1} es {prom}");
            }
        }
    }
}