/*
Calcular el sueldo líquido de un trabajador.
Los elementos a considerar son:
    - sueldo base
    - fondo de pensión (20%)
    - fondo de salud (7%)
Estos tres valores son ingresados por el usuario.
*/

using System;

namespace Ejercicio_12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el sueldo líquido de un trabajador\n");

            double Base, afp, salud;

            do
            {
                Console.Write("Ingrese el sueldo base: ");
                Base = Convert.ToDouble(Console.ReadLine());

                if (Base <= 0)
                {
                    Console.WriteLine("[!] El suelo base no puede ser menor o igual a 0");
                }
            } while (Base <= 0);

            do
            {
                Console.Write("Ingrese el fondo de pensión (poner 0 para tomar el 20% del sueldo base): ");
                afp = Convert.ToDouble(Console.ReadLine());

                if (afp < 0)
                {
                    Console.WriteLine("[!] El fondo de pensión no puede ser menor a 0");
                }
            } while (afp < 0);

            do
            {
                Console.Write("Ingrese el fondo de salud (poner 0 para tomar el 7% del sueldo base): ");
                salud = Convert.ToDouble(Console.ReadLine());

                if (salud < 0)
                {
                    Console.WriteLine("[!] El fondo de salud no puede ser menor a 0");
                }
            } while (salud < 0);

            if (afp == 0)
            {
                afp = Base * 0.20;
            }

            if (salud == 0)
            {
                salud = Base * 0.07;
            }

            double liquido = Base - (afp + salud);
            Console.WriteLine($"El sueldo líquido es de ${liquido}");
        }
    }
}