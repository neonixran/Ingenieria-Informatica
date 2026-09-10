using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdades
{
    public partial class Form1 : Form
    {
        //Arreglo con valores de las duraciones de todas las llamadas del último mes.
        int[] llamadas = {14,68,81,136,103,7,0,114,184,98,46,82,0,25,95,92,178,32,6,122,7,
                0,89,73,87,98,126,49,15,19,24,192,31,0,144,76,0,56,164,88,114,68,159,85,18,
                9,0,185,0,42,143,86,72,46,5,16,0,9,71,24,5,0,36,39,100,48,3,15,13,28,71,
                8,17,22,8,19,30,10,19,48,2,0,0,0,47,17,101,82,88,10,14,0,99,56,35,41,11};
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Definir variables para las llamadas corregidas, el costo total (con el descuento) y el descuento total aplicado
            int corregidas = 0;
            double costoTotal = 0;
            double descuentoTotal = 0;

            // Iterar por las llamadas hechas durante el mes
            for (int i = 0; i < llamadas.Length; i++)
            {
                if (i < 50) // Iterar hasta las primeras 50 llamadas
                {
                    if (llamadas[i] > 10) // Comprobar si el segundo es mayor a 10
                    {
                        llamadas[i] -= 5; // Descontar 5 segundos, esto es lo mismo que: llamadas[i] = llamadas[i] - 5
                        corregidas++; // Sumar +1 a la variable 
                    }
                }

                // Ignore el calculo de si es segundo es menor o igual a 20, ya que no se hacen calculos xd

                if (llamadas[i] >= 21 && llamadas[i] <= 60) // Comprobar si el segundo es mayor o igual a 21 y menores a 60
                {
                    double cobro = llamadas[i] * 1.65;
                    costoTotal += cobro; // Esto es lo mismo que: costoTotal = costoTotal + cobro
                } else if (llamadas[i] > 60) // Comprobar si el segundo es mayor o igual a 60
                {
                    double cobro = llamadas[i] * 1.65;
                    double descuento = cobro * 0.20; // Obtener el descuento del 20%

                    cobro -= descuento; // Restarle al cobro el descuento, esto es lo mismo que: cobro = cobro - descuento

                    descuentoTotal += descuento;
                    costoTotal += cobro;
                }
            }
            
            txtCorregidas.Text = corregidas.ToString();
            txtCostoTotal.Text = costoTotal.ToString("N0");
            txtDescuentoTotal.Text = descuentoTotal.ToString("N0"); // N0 para no agregar los decimales
        }
    }
}
