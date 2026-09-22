/*
Determinar el porcentaje de varones y de mujeres que hay en un salón de clases.
Todo número requerido para realizar el cálculo es ingresado por el usuario.
*/

using System;

namespace Ejercicio_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el porcentaje de hombres y mujeres en un salón de clases.\n");

            int mujeres, hombres;

            do
            {
                Console.Write("Ingrese la cantidad de mujeres: ");
                mujeres = Convert.ToInt32(Console.ReadLine());

                if (mujeres <= 0)
                {
                    Console.WriteLine("[!] La cantidad de mujeres no debe ser menor o igual a 0");
                }
            } while (mujeres <= 0);

            do
            {
                Console.Write("Ingrese la cantidad de hombres: ");
                hombres = Convert.ToInt32(Console.ReadLine());

                if (hombres <= 0)
                {
                    Console.WriteLine("[!] La cantidad de hombres no debe ser menor o igual a 0");
                }
            } while (hombres <= 0);


            double total = mujeres + hombres; // Total de alumnos
            double porcentaje_mujeres = (mujeres / total) * 100; // Porcentaje de mujeres
            double porcentaje_hombres = (hombres / total) * 100; // Porcentaje de hombres

            Console.WriteLine($"\nDe un total de {total} alumnos hay {porcentaje_mujeres}% de mujeres y {porcentaje_hombres}% de hombres en el salón.");
        }
    }
}