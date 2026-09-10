using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string invertirArreglo(string[] arreglo)
        {
            Array.Reverse(arreglo);

            string elementos = "";
            for (int i = 0; i < arreglo.Length; i++)
            {
                elementos += arreglo[i] + " ";
            }

            return elementos;
        }

        static bool positivos(string[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (int.Parse(arreglo[i]) < 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int mayoresA(int N, string[] arreglo)
        {
            int cantidadMayores = 0;
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (N > int.Parse(arreglo[i]))
                {
                    cantidadMayores++;
                }
            }

            return cantidadMayores;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string[] arreglo = txtArreglo.Text.Split(' ');

            if (!positivos(arreglo))
            {
                MessageBox.Show("Los números deben ser positivos!");
            }

            MessageBox.Show(String.Format("Hay {0} números mayores a {1}", mayoresA(int.Parse(txtN.Text), arreglo), txtN.Text));

            txtInverso.Text = invertirArreglo(arreglo);
        }
    }
}
