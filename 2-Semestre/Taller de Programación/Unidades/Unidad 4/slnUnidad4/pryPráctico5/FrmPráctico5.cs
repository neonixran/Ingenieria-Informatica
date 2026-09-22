using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico6
{
    public partial class FrmPráctico5 : Form
    {
        public FrmPráctico5()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                // Ingreso de números
                string[] ingresos = txtIngreso.Text.Split(' ');
                int[] datos = new int[ingresos.Length];

                for (int i = 0; i < ingresos.Length; i++)
                {
                    datos[i] = int.Parse(ingresos[i]);
                }

                // Ordenar los números
                txtOrdenados.Clear();

                Array.Sort(datos);

                for (int i = 0; i < datos.Length; i++)
                {
                    txtOrdenados.Text += String.Format("{0} ", datos[i].ToString());
                }

                // Obtener número mayor
                int mayor = datos[0];

                for (int i = 1; i < datos.Length; i++)
                {
                    if (datos[i] > mayor)
                    {
                        mayor = datos[i];
                    }
                }

                lblMayor.Text = mayor.ToString();

                // Obtener promedio
                double suma = 0;

                for (int i = 0; i < datos.Length; i++)
                {
                    suma += datos[i];
                }

                lblPromedio.Text = (suma / datos.Length).ToString("N2");
            } catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:\n" +  ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
x