using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico2
{
    public partial class frmPráctico2 : Form
    {
        public frmPráctico2()
        {
            InitializeComponent();
        }

        static double calcularPerímetro(double ladoA, double ladoB)
        {
            double p = 2 * (ladoA + ladoB);
            return p;
        }

        static double calcularÁrea(double ladoA, double ladoB)
        {
            double a = ladoA + ladoB;
            return a;
        }

        static void mostrarMensaje(TextBox ladoA, TextBox ladoB, Exception ex)
        {
            MessageBox.Show("Ocurrió un error\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ladoA.Clear();
            ladoA.Focus();

            ladoB.Clear();
            ladoB.Focus();
        }

        private void btnPerímetro_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = double.Parse(txtA.Text);
                double ladoB = double.Parse(txtB.Text);

                double perímetro = calcularPerímetro(ladoA, ladoB);
                txtPerímetro.Text = perímetro.ToString("N1");
            } catch(Exception ex)
            {
                mostrarMensaje(txtA, txtB, ex);
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = double.Parse(txtA.Text);
                double ladoB = double.Parse(txtB.Text);

                double área = calcularÁrea(ladoA, ladoB);
                txtArea.Text = área.ToString("N1");
            } catch (Exception ex)
            {
                mostrarMensaje(txtA, txtB, ex);
            }
        }
    }
}
