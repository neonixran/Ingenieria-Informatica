/*
Calcular el IMC (Índice de Masa Corporal).
    - Usando la fórmula: IMC = Masa / (estatura²)
Masa y estatura son ingresados por el usuario
*/

using System;

namespace Ejercicio_13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el IMC (Índice de Masa Corporal)\n");

            double masa, estatura;

            do
            {
                Console.Write("Ingrese su peso (kg): ");
                masa = Convert.ToDouble(Console.ReadLine());

                if (masa <= 0)
                {
                    Console.WriteLine("La masa no puede menor o igual a 0");
                }
            } while (masa <= 0);

            do
            {
                Console.Write("Ingrese su estatura (cm): ");
                estatura = Convert.ToDouble(Console.ReadLine());

                if (estatura <= 0)
                {
                    Console.WriteLine("La estatura no puede menor o igual a 0");
                }
            } while (estatura <= 0);

            double imc = masa / Math.Pow((estatura / 100), 2);

            if (imc < 18)
            {
                Console.WriteLine("Bajo peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Exceso de peso");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidad grado II");
            }
            else
            {
                Console.WriteLine("Obesidad grado III");
            }

            Console.WriteLine($"Su IMC es {imc}");
        }
    }
}