/*
En una competencia atlética de velocidad el tiempo se mide en minutos, segundos y centésimas de segundo y, el espacio recorrido se mide en metros.
Determinar la velocidad promedio de un atleta en km/hr.
Considere que:
    - 1 hora = 60 minutos
    - 1 minuto = 60 segundos
    - 1 segundo = 100 centésimas de segundo
    - 1 kilómetro = 1000 metros
    
Todos los datos requeridos son ingresados por el usuario.
*/

using System;

namespace Ejercicio_18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula la velocidad promedio de un atleta en km/h\n");

            double metros;
            int minutos, segundos, centesimas;

            do
            {
                Console.Write("Ingrese la distancia recorrida en metros: ");
                metros = Convert.ToDouble(Console.ReadLine());

                if (metros <= 0)
                {
                    Console.WriteLine("[!] La distancia recorrida no puede ser menor o igual a 0");
                }
            } while (metros <= 0);

            do
            {
                Console.Write("Ingrese la cantidad de minutos: ");
                minutos = Convert.ToInt32(Console.ReadLine());

                if (minutos <= 0)
                {
                    Console.WriteLine("[!] La cantidad de minutos no puede ser menor o igual a 0");
                }
            } while (minutos <= 0);

            do
            {
                Console.Write("Ingrese la cantidad de segundos: ");
                segundos = Convert.ToInt32(Console.ReadLine());

                if (segundos <= 0)
                {
                    Console.WriteLine("[!] La cantidad de segundos no puede ser menor o igual a 0");
                }
            } while (segundos <= 0);

            do
            {
                Console.Write("Ingrese la cantidad de centésimas de segundo: ");
                centesimas = Convert.ToInt32(Console.ReadLine());

                if (centesimas <= 0)
                {
                    Console.WriteLine("[!] La cantidad de centésimas de segundo no puede ser menor o igual a 0");
                }
            } while (centesimas <= 0);

            double km = metros / 1000; // Convertir metros a kilómetros

            // Convertir el tiempo a horas
            minutos += (segundos + (centecimas / 100)) / 60;
            horas = minutos / 60;

            double velocidad = km / horas; // Velocidad en km/h

            Console.WriteLine($"La velocidad promedio del atleta es de {velocidad} km/h");
        }
    }   
}