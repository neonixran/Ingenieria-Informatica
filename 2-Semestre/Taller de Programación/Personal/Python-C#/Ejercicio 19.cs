/*
El sueldo neto de un vendedor se calcula como la suma de un sueldo básico más el 12% del monto total vendido.
Determinar el sueldo neto de un vendedor sabiendo que hizo tres ventas en el mes.

Las ventas son ingresadas por el usuario.
*/

using System;

namespace Ejercicio_19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el sueldo neto de un vendedor\n");

            int sueldo_base;
            double ventas = 0;

            do
            {
                Console.Write("Ingrese el sueldo base del vendedor: ");
                sueldo_base = Convert.ToInt32(Console.ReadLine());

                if (sueldo_base <= 0)
                {
                    Console.WriteLine("[!] El sueldo base no puede ser menor o igual a 0");
                }
            } while (sueldo_base <= 0);

            for (int i = 1; i <= 3; i++)
            {
                int venta;

                do
                {
                    Console.Write($"Ingrese el monto de la venta {i}: ");
                    venta = Convert.ToInt32(Console.ReadLine());

                    if (venta <= 0)
                    {
                        Console.WriteLine($"El monto de la venta {i} no puede ser menor o igual a 0");
                    }
                } while (venta <= 0);

                ventas += venta;
            }

            double sueldo_neto = sueldo_base + (ventas * 0.12);

            Console.WriteLine($"El sueldo neto del vender es de ${sueldo_neto}");
        }
    }
}