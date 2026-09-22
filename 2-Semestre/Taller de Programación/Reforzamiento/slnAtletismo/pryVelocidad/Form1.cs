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

namespace pryVelocidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lst200m.Items.Add("PAIS ATLETA");
            lst400m.Items.Add("PAIS ATLETA");
        }

        static double calcularVelocidad(double distancia, double tiempo)
        {
            double kilometros = distancia / 1000;
            double horas = tiempo / 3600;

            double velocidad = kilometros / horas;


            return velocidad;
        }

        static int cantidadRegistros(string distancia = null)
        {
            StreamReader datos = new StreamReader("../../../atletismo.txt");

            string dato = datos.ReadLine();

            int contador = -1;
            while (dato != null)
            {
                string[] campos = dato.Split(';');

                if (distancia == campos[2])
                {
                    contador++;
                }

                dato = datos.ReadLine();
            }

            datos.Close();

            return contador;
        }

        static string[] obtenerFinalistas(string distacia)
        {

            StreamReader datos = new StreamReader("../../../atletismo.txt");

            string dato = datos.ReadLine();

            int contador = -1;
            int cantidadFinalistas = cantidadRegistros(distacia);
            string[] finalistas = new string[cantidadFinalistas];

            while (dato != null)
            {
                string[] campos = dato.Split(';');

                if (distacia == campos[2] && contador <= 5)
                {
                    finalistas[contador] = String.Format("{0}; {1}; {2}", campos[0], campos[1], calcularVelocidad(double.Parse(distacia), double.Parse(campos[3])));
                }

                contador++;
                dato = datos.ReadLine();
            }
                
            datos.Close();

            Array.Sort(finalistas);

            return finalistas;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int distancia = int.Parse(txtDistancia.Text);
                double tiempo = double.Parse(txtTiempo.Text);
                
                double velocidad = calcularVelocidad(distancia, tiempo);
                txtVelocidad.Text = velocidad.ToString("N1");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObtenerVeloces_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < cantidadRegistros("200"); i++)
                {
                   lst200m.Items.Add(obtenerFinalistas("200")[i]);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
