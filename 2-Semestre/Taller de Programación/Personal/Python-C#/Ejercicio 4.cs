/*
Calculo del área y perímetro de un rectángulo.

Considere las siguientes formulas:
    a) área = base x altura
    b) perímetro = 2 x (base + altura)

Tanto base como altura son ingresados por el usuario.
*/

using System;

namespace Ejercicio_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el área y perímetro de un rectángulo.\n");
            
            double Base;
            double Altura;

            do // Bloque de código para verificar que sea un rectángulo
            {
                do // Bloque de código para preguntar y verificar la base
                {
                    Console.Write("Ingrese la base: ");
                    Base = Convert.ToDouble(Console.ReadLine());

                    if (Base <= 0)
                    {
                        Console.WriteLine("[!] La base no puede ser menor o igual a 0");
                    }
                } while (Base <= 0); // Se repite hasta que la base sea mayor a 0

                do // Bloque de código para preguntar y verificar la altura
                {
                    Console.Write("Ingrese la altura: ");
                    Altura = Convert.ToDouble(Console.ReadLine());

                    if (Altura <= 0)
                    {
                        Console.WriteLine("[!] La altura no puede ser menor o igual a 0");
                    }
                } while (Altura <= 0); // Se repite hasta que la altura sea mayor a 0

                if (Base == Altura)
                {
                    Console.WriteLine("[!] La base y altura no puede ser iguales");
                }
            } while (Base == Altura);

            // Cálculo e impresión del área y perímetro
            double Area = Base * Altura;
            double Perimetro = 2 * (Base + Altura);

            Console.WriteLine($"El área es de {Area} cm²");
            Console.WriteLine($"El perímetro es de {Perimetro} cm");
        }
    }
}