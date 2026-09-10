/*
Existe un alumno que utiliza periódicamente la “ley del menor esfuerzo”, por lo cual, necesita saber la cantidad de veces que se le permite faltar a la asignatura de “Lenguaje de programación”.
Él sabe que el módulo se compone de 12 clases y que la asistencia mínima es de un 70%.

Calcular a cuántas clases puede faltar este alumno sin perder la asignatura por inasistencia.
*/

using System;

namespace Ejercicio_21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula la cantidad de clases que un alumno puede faltar sin perder la asignatura\n");

            int clases_totales;

            do
            {
                Console.Write("Ingrese la cantidad total de clases: ");
                clases_totales = Convert.ToInt32(Console.ReadLine());

                if (clases_totales < 5)
                {
                    Console.WriteLine("[!] La cantidad de clases totales no puede ser menor a 5");
                }
            } while (clases_totales < 5); // Mínimo 5 clases para evitar errores en el cálculo

            double minimo_asistencia = clases_totales * 0.7;
            double permitido = clases_totales - minimo_asistencia;

            Console.WriteLine($"El alumno puede faltar a {permitido} clases sin perder la asistencia.");
        }
    }
}