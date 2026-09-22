/*
Usted se dedica a sembrar pasto para jardines de lujo, para lo cual, cobra sus honorarios por m².
Este costo incluye materiales (semillas y abonos). Calcular el costo total de su trabajo en un jardín de N m².
    - Considere que el kilo de semillas tiene un costo de $5.000 y esto cubre 1 m2 del jardín.
    - El abono tiene un costo de $2.000 y esto cubre, también, 1 m² del jardín.
    - Los honorarios del jardinero (mano de obra) son de $30.000 por cada m2.
Los N m² son ingresados por el usuario.
*/

using System;

namespace Ejercicio_15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el costo total de sembrar pasto para jardines de lujo\n");

            int semillas = 5000;
            int abono = 2000;
            int honorarios = 30000;

            double m2;

            do
            {
                Console.Write("Ingrese la cantidad de m² trabajados: ");
                m2 = Convert.ToDouble(Console.ReadLine());

                if (m2 <= 0)
                {
                    Console.WriteLine("La cantidad de m² no puede ser menor o igual a 0");
                }
            } while (m2 <= 0);

            double total = m2 * (semillas + abono + honorarios);
            Console.WriteLine($"El costo total del trabajo es de ${total}");
        }
    }
}