using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRectángulo
{
    public partial class formRectángulo : Form
    {
        public formRectángulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = double.Parse(txtLadoA.Text);
                double ladoB = double.Parse(txtLadoB.Text);

                if (ladoA <= 0 || ladoB <= 0) // Validación de números negativos o cero
                {
                    MessageBox.Show("No puede ingresar números negativos", "Ingreso de lados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ladoA == ladoB) // Validación de cuadrado
                {
                    MessageBox.Show("Los lados ingresados corresponden a los de un cuadrado", "Ingreso de lados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    double perimetro = 2 * (ladoA + ladoB);
                    double area = ladoA * ladoB;

                    txtPerimetro.Text = perimetro.ToString();
                    txtArea.Text = area.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLadoA_Click(object sender, EventArgs e)
        {
            if (txtPerimetro.Text != "")
            {
                txtLadoA.Clear();
                txtPerimetro.Clear();
                txtArea.Clear();
            }
        }

        private void txtLadoB_Click(object sender, EventArgs e)
        {
            if (txtPerimetro.Text != "")
            {
                txtLadoB.Clear();
                txtPerimetro.Clear();
                txtArea.Clear();
            }
        }
    }
}
