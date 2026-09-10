using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySalud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método para calcular el porcentaje de salud (e: edad; a: altura; p: peso)
        static double porcentajeSalud(int e, double a, int p) {
            double I = p / Math.Pow(a, 2);
            double R = Math.Exp(-0.08 * Math.Pow((I-22), 2));
            double Q = Math.Exp(-0.0015 * Math.Pow((e - 30), 2));

            return (100 * (0.65 * R + 0.35 * Q));
        }

        // Método para obtener el estado de salud según el porcentaje
        static string estadoSalud(double porcentaje) {
            string estado = "";

            if (porcentaje >= 80)
            {
                estado = "Muy bueno";
            }
            else if (porcentaje >= 60)
            {
                estado = "Bueno";
            }
            else if (porcentaje >= 40)
            {
                estado = "Regular";
            }
            else if (porcentaje >= 20)
            {
                estado = "Bajo";
            }
            else {
                estado = "Muy bajo";
            }

            return estado;
        }

        // Método para contar la cantidad total de inscritos en el archivo
        static int cantidadInscritos()
        {
            StreamReader archivo = new StreamReader("../../inscritos.txt");
            string registros = archivo.ReadLine();

            int cantidad = 0;

            while (registros != null)
            {
                cantidad++;
                registros = archivo.ReadLine();
            }
            archivo.Close();

            return cantidad;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = int.Parse(txtEdad.Text);
                double altura = double.Parse(txtAltura.Text);
                int peso = int.Parse(txtPeso.Text);

                double porcentaje = porcentajeSalud(edad, altura, peso);
                txtEstado.Text = estadoSalud(porcentaje);
            }
            catch {
                MessageBox.Show("SE ACEPTAN SÓLO VALORES NUMÉRICOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cantidad total de inscritos.
                int cantidad = cantidadInscritos(); // En este certamen no era necesario crear un método para esto, ya que especificaba que habían 41 registros.

                // Crear un arreglo para guardar los porcentajes de salud de los inscritos.
                double[] inscritos = new double[cantidad]; // Forma correcta: new double[41];

                // Leer el archivo y calcular el porcentaje de salud de cada inscrito.
                StreamReader Inscritos = new StreamReader("../../inscritos.txt");
                string registros = Inscritos.ReadLine();

                int i = 0;
                while (registros != null)
                {
                    /*
                     * Campo[0]: Edad
                     * Campo[1]: Peso
                     * Campo[2]: Altura
                     */
                    string[] campo = registros.Split(';');

                    // Calcular el porcentaje de salud y guardarlo en el arreglo.
                    inscritos[i] = porcentajeSalud(int.Parse(campo[0]), double.Parse(campo[2]), int.Parse(campo[1]));
                    i++;
                    registros = Inscritos.ReadLine();
                }

                Inscritos.Close();

                // Mostrar los inscritos en condiciones aceptables y no aceptables
                int inscritosAceptables = 0;
                int inscritosNoAceptables = 0;

                for (int j = 0; j < inscritos.Length; j++)
                {
                    // Evaluar el estado de salud de cada inscrito.
                    if (estadoSalud(inscritos[j]) == "Muy bueno" || estadoSalud(inscritos[j]) == "Bueno" || estadoSalud(inscritos[j]) == "Regular")
                    {
                        inscritosAceptables++;
                    } else if (estadoSalud(inscritos[j]) == "Muy bajo")
                    {
                        inscritosNoAceptables++;
                    }
                }

                // Mostrar los resultados en los textbox.
                txtAceptables.Text = inscritosAceptables.ToString();
                txtNoAceptables.Text = inscritosNoAceptables.ToString();

                // Crear un archivo con los inscritos en condición baja
                Inscritos = new StreamReader("../../inscritos.txt");
                registros = Inscritos.ReadLine();

                int ck = 0;
                while (registros != null)
                {
                    string[] campo = registros.Split(';');
                    double porcentaje = porcentajeSalud(int.Parse(campo[0]), double.Parse(campo[2]), int.Parse(campo[1]));

                    if (estadoSalud(porcentaje) == "Bajo")
                    {
                        ck++;
                    }

                    registros = Inscritos.ReadLine();
                }

                Inscritos.Close();

                double[] porcentajesBajos = new double[ck];

                Inscritos = new StreamReader("../../inscritos.txt");
                registros = Inscritos.ReadLine();

                int ci = 0;
                while (registros != null)
                {
                    string[] campo = registros.Split(';');
                    double porcentaje = porcentajeSalud(int.Parse(campo[0]), double.Parse(campo[2]), int.Parse(campo[1]));

                    if (estadoSalud(porcentaje) == "Bajo")
                    {
                        porcentajesBajos[ci] = porcentaje;
                        ci++;
                    }

                    registros = Inscritos.ReadLine();
                }

                Inscritos.Close();

                // Guardar en un arreglo los que tienen condición baja
                StreamWriter bajosInscritos = new StreamWriter("../../Bajos.txt");

                for (int n = 0; n < porcentajesBajos.Length; n++)
                {
                    bajosInscritos.WriteLine(porcentajesBajos[n].ToString());
                }

                bajosInscritos.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
