namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTROLADOR DE CALIDAD DE SOFTWARE\n");

            int transacciones;
            do
            {
                Console.Write("Ingrese la cantidad de transacciones: ");
                transacciones = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;

                if (transacciones <= 0)
                {
                    Console.WriteLine("Error: la cantidad de transacciones debe ser mayor a 0");
                }

                Console.ResetColor();
            }
            while (transacciones <= 0);

            double tiempoAcumulado = 0;
            double umbralTransacciones = 0;
            for (int i = 1; i <= transacciones; i++)
            {
                Console.WriteLine($"\nTransacción {i}");
                Console.Write($"Ingrese el tiempo de respuesta (ms): ");
                double tiempoRespuesta = double.Parse(Console.ReadLine());
                
                if (tiempoRespuesta > 500)
                {
                    umbralTransacciones++;
                }
               
                tiempoAcumulado += tiempoRespuesta;
            }

            double promedioRespuesta = tiempoAcumulado / transacciones;
            double porcentajeUmbral = (umbralTransacciones / transacciones) * 100;

            Console.WriteLine($"\nCantidad de transacciones: {transacciones}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Tiempo acumulado: {tiempoAcumulado} ms");
            Console.WriteLine($"Tiempo promedio de respuesta: {promedioRespuesta} ms");
            Console.WriteLine($"Porcentaje de transacciones que superan el umbral (500 ms): {porcentajeUmbral}%");
        }
    }
}
