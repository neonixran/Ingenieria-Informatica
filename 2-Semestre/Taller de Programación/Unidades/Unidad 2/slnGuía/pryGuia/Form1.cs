using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGuia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Puntos P1(a, b) y P2(c, d)
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);
                double d = Convert.ToDouble(txtD.Text);

                if (a == c && b == d)
                {
                    MessageBox.Show("Los puntos ingresados son iguales, por favor ingrese puntos diferentes.");
                    txtA.Clear();
                    txtB.Clear();
                    txtC.Clear();
                    txtD.Clear();

                    txtDistancia.Clear();
                    txtPendiente.Clear();
                    txtTipo.Clear();

                    return;
                }

                // Distancia, Pendiente y Tipo
                double Distancia = Math.Sqrt(Math.Pow(a - c, 2) + Math.Pow(b - d, 2));
                double Pendiente = (d - b) / (c - a);

                txtDistancia.Text = Distancia.ToString("N2");
                txtPendiente.Text = Convert.ToString(Pendiente);

                if (double.IsInfinity(Pendiente))
                {
                    txtTipo.Text = "La recta es vertical.";
                }
                else if (Pendiente < 0)
                {
                    txtTipo.Text = "La recta se inclina hacia abajo de izquierda a derecha.";
                }
                else if (Pendiente > 0)
                {
                    txtTipo.Text = "La recta se inclina hacia arriba de izquierda a derecha.";
                }
                else if (Pendiente == 0)
                {
                    txtTipo.Text = "La recta es horizontal.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error con los datos ingresados!");
            }
        }
    }
}
