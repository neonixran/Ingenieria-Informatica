using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPractico4
{
    public partial class frmPractico4 : Form
    {
        public frmPractico4()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double resultado = num1 + num2;

                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el ingreso de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double resultado = num1 - num2;

                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el ingreso de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
                try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double resultado = num1 * num2;

                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el ingreso de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double resultado = num1 / num2;

                txtResultado.Text = resultado.ToString("N2"); // Formateo a 2 decimales
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el ingreso de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMódulo_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double resultado = num1 % num2;

                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el ingreso de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarRes_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }
    }
}
