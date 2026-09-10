namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string claveCorrecta = "2026";
            int intentoActual = 0;

            Console.WriteLine("SISTEMA DE ACCESO\n");

            intentoActual++;

            string claveSecreta = acceso(intentoActual, claveCorrecta);

            while (claveSecreta != claveCorrecta && intentoActual < 3)
            {
                intentoActual++;

                claveSecreta = acceso(intentoActual, claveCorrecta);
            }
        }

        static string acceso(int intentoActual, string claveCorrecta)
        {
            Console.Write("Ingrese su clave secreta: ");
            string claveSecreta = Console.ReadLine();

            if (claveSecreta == claveCorrecta)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Intento {intentoActual}, acceso concedido");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                if (intentoActual == 3)
                {
                    Console.WriteLine($"Intento {intentoActual}, acceso denegado (bloqueado)");
                }
                else
                {
                    Console.WriteLine($"Intento {intentoActual}, acceso denegado");
                }
            }

            Console.ResetColor();

            return claveSecreta;
        }
    }
}
