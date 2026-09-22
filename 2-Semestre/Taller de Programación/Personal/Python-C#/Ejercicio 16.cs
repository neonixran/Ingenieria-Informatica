/*
Usted se debe estacionar frente a un parquímetro, el cual tiene la siguiente tarifa:
    - 0 a 20 minutos = $366
    - Minuto adicional es de $18.28
Calcular la cantidad de pesos (CLP) que debe cancelar al parquímetro por estar estacionado por N minutos.
N debe ser ingresado por el usuario.
*/

using System;

namespace Ejercicio_16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el costo de estacionamiento en un parquímetro\n");

            int minutos;

            do
            {
                Console.Write("Ingrese la cantidad de minutos que estuvo estacionado: ");
                minutos = Convert.ToInt32(Console.ReadLine());

                if (minutos < 0)
                {
                    Console.WriteLine("La cantidad de minutos no puede ser menor a 0");
                }
            } while (minutos < 0);

            if (minutos < 20)
            {
                Console.WriteLine("Debe cancelar $366");
            }
            else
            {
                double adicional = (minutos - 20) * 18.28;
                double total = adicional + 366;
                
                Console.WriteLine($"Debe cancelar ${total}");
            }
        }
    }
}