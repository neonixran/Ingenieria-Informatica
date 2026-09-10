using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLaboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] fah = { 171, 58, 104, 80, 87, 74, 84, 221, 190, 79, 31, 70, 209, 217, 159, 161,
            25, 176, 127, 122, 59, 42, 116, 81, 132, 191, 221, 149, 107, 223, 188, 36, 86,
            218, 222, 219, 106, 155, 47, 83, 201, 81, 124, 205, 20, 224, 111, 100, 24, 45,
            96, 18, 25, 91, 172, 83, 212, 182, 199, 82, 84, 98, 135, 159, 25, 134, 40, 52,
            24, 114, 199, 170, 81, 186, 31, 101, 154, 178, 221, 102, 129, 112, 93, 216, 23,
            110, 207, 50, 109, 190, 152, 180, 156, 188, 221, 156, 113, 149, 62, 65, 33, 58,
            122, 196, 153, 174, 215, 171, 139, 222, 21, 32, 102, 54, 180, 44, 49, 91, 135, 47,
            68, 206, 64, 104, 161, 34, 19, 96, 179, 59, 187, 163, 108, 78, 220, 57, 219, 188,
            216, 182, 185, 191, 23, 139, 121, 103, 102, 92, 171, 49, 61, 118, 30, 194, 205, 72,
            100, 89, 197, 137, 211, 209, 168, 160, 57, 101, 178, 121, 130, 152, 125, 203, 186,
            181, 138, 175, 191, 63, 182, 106, 163, 182, 137, 190, 207, 216, 101, 26 };
        //ESCRIBA AQUÍ LOS MÉTODOS

        // Método que calcule y entregue en grados Celcius dada la temperatura en grados Fahrenheit.
        static double calcularCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        // Método que permite obtener el estado de la mezcla.
        static string obtenerEstado(double celcius)
        {   
            if (celcius < 0)
            {
                return "Hielo";
            } else if (celcius < 100)
            {
                return "Líquido";
            } else
            {
                return "Vapor";
            }
        }

        // Botón "Calcular estado de una mezcla"
        private void btnAnalizarMezcla_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(txtF.Text); // Convertir el texto a double (decimal)
                
                if (fahrenheit >= 10 || fahrenheit <= 250) // Se debe permitir sólo valores de 10 hasta 250, muestra un error si esto no se cumple.
                {
                    double celcius = calcularCelcius(fahrenheit); // Llamar al método que convierte de grados Fahrenheit a Celcius, pasando como argumento los grados Fahrenheit.
                    string estado = obtenerEstado(celcius); // Llamar al método que obtiene el estado, pasando como argumento los grados Celcius.

                    txtC.Text = celcius.ToString("N3"); // Mostrar la temperatura en grados Celcius con 3 decimales.
                    txtEstado.Text = estado; // Mostrar el estado.
                } else
                {
                    MessageBox.Show("SOLO INGRESAR VALORES DESDE 10 HASTA 250", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje de error si la condición anterior no se cumple.
                }
            } catch
            {
                MessageBox.Show("SOLO INGRESAR VALORES NUMÉRICOS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje de error si los valores no son numéricos.
            }
        }

        // Botón "Procesar las mezclas del arreglo"
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Crear archivo que guarde las temperaturas que estén en estado líquido.
            StreamWriter líquidos = new StreamWriter("../../líquidos.txt");

            // Crear variables para el conteo y promedio.
            int cantidadVapor = 0; // Contador para el estado "Vapor".

            int cantidadHielo = 0; // Contador para el estado "Hielo".
            int sumaHielo = 0; // Suma de temperaturas que tengan el estado "Hielo".

            for (int i=0; i < fah.Length; i++) // Recorrer el arreglo para obtener una por una las temperaturas en Fahrenheit.
            {
                double celcius = calcularCelcius(fah[i]); // Llamar al método que convierte de grados Fahrenheit a Celcius, pasando como argumento cada temperatura en grados Fahrenheit del arreglo.
                string estado = obtenerEstado(celcius); // Llamar al método que obtiene el estado, pasando como argumento los grados Celcius.

                if (estado == "Vapor") // Comprobar si el estado es Vapor
                {
                    cantidadVapor++; // Sumar +1 si la condición se cumple.
                } else if (estado == "Hielo") // Comprobar si el estado es Hielo
                {
                    cantidadHielo++; // Sumar +1 si la condición se cumple.
                    sumaHielo += fah[i]; // Sumar cada temperatura si la condición se cumple.
                } else if (estado == "Líquido") // Comprobar si el estado es Líquido
                {
                    líquidos.WriteLine(celcius.ToString()); // Escribir en el archivo la temperatura en Celcius si la condición se cumple. 
                }
            }

            líquidos.Close(); // Cerrar el archivo.

            // Mostrar los valores obtenidos en su textbox correspondiente.
            txtVapores.Text = cantidadVapor.ToString();
            txtHielos.Text = (sumaHielo / cantidadHielo).ToString();
        }
    }
}
