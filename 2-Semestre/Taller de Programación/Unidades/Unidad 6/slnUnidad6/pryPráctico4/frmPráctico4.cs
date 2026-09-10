using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico4
{
    public partial class frmPráctico4 : Form
    {
        public frmPráctico4()
        {
            InitializeComponent();
        }

        static Fracción Sumar(Fracción f1, Fracción f2)
        {
            Fracción resultado = new Fracción();
            resultado.Numerador = f1.Numerador * f2.Denominador + f2.Numerador * f1.Denominador;
            resultado.Denominador = f1.Denominador * f2.Denominador;

            resultado.Simplificar();

            return resultado;
        }

        static Fracción Multiplicar(Fracción f1, Fracción f2)
        {
            Fracción resultado = new Fracción();
            resultado.Numerador = f1.Numerador * f2.Numerador;
            resultado.Denominador = f1.Denominador * f2.Denominador;

            resultado.Simplificar();

            return resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(txtNumA.Text);
                int d1 = int.Parse(txtDenA.Text);

                int n2 = int.Parse(txtNumB.Text);
                int d2 = int.Parse(txtDenB.Text);

                Fracción f1 = new Fracción(n1, d1);
                Fracción f2 = new Fracción(n2, d2);

                Fracción adición = Sumar(f1, f2);
                Fracción multiplicación = Multiplicar(f1, f2);

                f1.Simplificar();
                f2.Simplificar();

                txtNumSuma.Text = adición.Numerador.ToString();
                txtDenSuma.Text = adición.Denominador.ToString();

                txtNumMult.Text = multiplicación.Numerador.ToString();
                txtDenMult.Text = multiplicación.Denominador.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumA_TextChanged(object sender, EventArgs e)
        {
            txtNAm.Text = txtNumA.Text;
            txtNAs.Text = txtNumA.Text;
        }

        private void txtDenA_TextChanged(object sender, EventArgs e)
        {
            txtDAs.Text = txtDenA.Text;
            txtDAm.Text = txtDenA.Text;
        }

        private void txtNumB_TextChanged(object sender, EventArgs e)
        {
            txtNBm.Text = txtNumB.Text;
            txtNBs.Text = txtNumB.Text;
        }

        private void txtDenB_TextChanged(object sender, EventArgs e)
        {
            txtDBm.Text = txtDenB.Text;
            txtDBs.Text = txtDenB.Text;
        }
    }
}
