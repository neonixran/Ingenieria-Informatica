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

namespace pryTriangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método para validar si los tres valores de a, b y c forman un triángulo.
        static bool esTriángulo(double a, double b, double c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        // Método para calcular el área de un triángulo.
        static double calcularArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        // Método para determinar el tipo de triángulo.
        static string tipoTriángulo(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Equilátero";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isósceles";
            }
            else
            {
               return "Escaleno";
            }
        }

        static int cantidadEscalenos()
        {
            StreamReader triángulos = new StreamReader("../../Triángulos.txt");
            string registros = triángulos.ReadLine();

            int triángulosEscalenos = 0;

            while (registros != null)
            {
                /*
                 * [0]: ladoA
                 * [1]: ladoB
                 * [2]: ladoC
                 */
                string[] lados = registros.Split(';');

                double ladoA = double.Parse(lados[0]);
                double ladoB = double.Parse(lados[1]);
                double ladoC = double.Parse(lados[2]);

                if (esTriángulo(ladoA, ladoB, ladoC))
                {
                    if (tipoTriángulo(ladoA, ladoB, ladoC) == "Escaleno")
                    {

                        triángulosEscalenos++;
                    }
                }

                registros = triángulos.ReadLine();
            }

            triángulos.Close();

            return triángulosEscalenos;
        }


        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = double.Parse(txtLadoA.Text);
                double ladoB = double.Parse(txtLadoB.Text);
                double ladoC = double.Parse(txtLadoC.Text);

                if (esTriángulo(ladoA, ladoB, ladoC))
                {
                    double area = calcularArea(ladoA, ladoB, ladoC);
                    txtResultado.Text = area.ToString("N1");

                    MessageBox.Show(tipoTriángulo(ladoA, ladoB, ladoC), "TIPO TRIÁNGULO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    txtResultado.Text = "NO ES VÁLIDO";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Leer el archivo de triángulos
            StreamReader triángulos = new StreamReader("../../Triángulos.txt");
            string registros = triángulos.ReadLine();

            // Crear un arreglo para almacenar las áreas de los triángulos escalenos
            int triángulosEscalenos = cantidadEscalenos();
            double[] áreas = new double[triángulosEscalenos];
            int contador = 0;

            // Leer los triángulos y calcular las áreas de los escalenos
            while (registros != null)
            {
                /*
                 * [0]: ladoA
                 * [1]: ladoB
                 * [2]: ladoC
                 */
                string[] lados = registros.Split(';');

                double ladoA = double.Parse(lados[0]);
                double ladoB = double.Parse(lados[1]);
                double ladoC = double.Parse(lados[2]);


                if (esTriángulo(ladoA, ladoB, ladoC))
                {
                    if (tipoTriángulo(ladoA, ladoB, ladoC) == "Escaleno")
                    {
                        double área = calcularArea(ladoA, ladoB, ladoC);
                        áreas[contador] = área;

                        contador++;
                    }
                }

                registros = triángulos.ReadLine();
            }

            triángulos.Close();

            // Imprimir cantidad de triángulos escalenos
            txtCantEscalenos.Text = triángulosEscalenos.ToString();

            // Ordenar las áreas de los triángulos escalenos de mayor a menor
            Array.Sort(áreas);
            Array.Reverse(áreas); // Se hace un reverse, ya que sort ordena de menor a mayor

            // Guardar las áreas almacenadas en el arreglo en un archivo
            StreamWriter escalenos = new StreamWriter("..//..//escalenos.txt");

            for (int i = 0; i < áreas.Length; i++)
            {
                escalenos.WriteLine(áreas[i].ToString("N1"));
            }

            escalenos.Close();
        }
    }
}

