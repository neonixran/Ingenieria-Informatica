/*
Expresar la capacidad de un disco duro en megabytes, kilobytes y bytes, conociendo la capacidad del disco en gigabytes.
Considere que:
    - 1 kilobyte = 1024 bytes
    - 1 megabyte = 1024 kilobyte
    - 1 gigabyte = 1024 megabytes
*/

using System;

namespace Ejercicio_20
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este programa convierte la capacidad de un disco duro en gigabytes a megabytes, kilobytes y bytes\n");

            int gb; // gigabytes

            do
            {
                Console.Write("Ingrese la capacidad del disco duro en gigabytes: ");
                gb = Convert.ToInt32(Console.ReadLine());

                if (gb <= 0)
                {
                    Console.WriteLine("[!] La capacidad del disco duro no puede ser menor o igual a 0");
                }
            } while (gb <= 0);

            double mb = gb * 1024; // megabytes
            double kb = mb * 1024; // kilobytes
            double b = kb * 1024; // bytes

            Console.WriteLine("La capacidad del disco duro en: ");
            Console.WriteLine($"Megabytes: {mb} MB");
            Console.WriteLine($"Kilobytes: {kb} KB");
            Console.WriteLine($"Bytes: {b} B");
        }
    }   
}