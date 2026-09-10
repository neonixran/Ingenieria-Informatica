/*
Una institución benéfica europea ha recibido tres donaciones en soles, dólares y marcos.
La donación será repartida en tres rubros:
    - 60% para la implementación de un centro de salud
    - 30% para un comedor deniños
    - el resto para gastos administrativos.

Determinar el monto en euros que le corresponde a cada rubro.
Considere que:
    - 1 dólar = 3.52 soles
    - 1 dólar = 2.08 marcos
    - 1 dólar = 1.07 euros.

Las donaciones son ingresadas por el usuario.
*/

using System;

namespace Ejercicio_17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el monto en euros que le corresponde a cada rubro de una donación\n");

            double soles, marcos, dolares;

            do
            {
                Console.Write("Ingrese la donación en soles: ");
                soles = Convert.ToDouble(Console.ReadLine());

                if (soles <= 0)
                {
                    Console.WriteLine("[!] La donación en soles no puede ser menor o igual a 0");
                }
            } while (soles <= 0);

            do
            {
                Console.Write("Ingrese la donación en marcos: ");
                marcos = Convert.ToDouble(Console.ReadLine());

                if (marcos <= 0)
                {
                    Console.WriteLine("[!] La donación en marcos no puede ser menor o igual a 0");
                }
            } while (marcos <= 0);

            do
            {
                Console.Write("Ingrese la donación en dólares: ");
                dolares = Convert.ToDouble(Console.ReadLine());

                if (dolares <= 0)
                {
                    Console.WriteLine("[!] La donación en dólares no puede ser menor o igual a 0");
                }
            } while (dolares <= 0);

            // Convertir las donaciones a dólares (se usa la misma variables de la moneda local)
            soles /= 3.52;
            marcos /= 2.08;

            // Convertir las donaciones a euros
            double euros = (soles + marcos + dolares) * 1.07;

            // Calcular el monto para cada rubro
            double centro_salud = euros * 0.6;
            double comedor_ninos = euros * 0.3;
            double gastos_administrativos = euros * 0.1;

            // Mostrar los resultados
            Console.WriteLine($"Para el centro de salud fueron donados €{centro_salud}, para el comedor de niños €{comedor_ninos} y para gastos administrativos €{gastos_administrativos}.");
        }
    }
}