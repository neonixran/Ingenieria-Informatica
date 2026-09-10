using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPractico7v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            double Nota;

            if (!double.TryParse(txtNota.Text, out Nota)) // Validar que la nota sea numérica
            {
                MessageBox.Show("Ingrese una nota válida.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNota.Clear();
                return;
            }

            if (Nota < 1 || Nota > 7)
            {
                MessageBox.Show("Ingrese una nota de 1.0 a 7.0 ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNota.Clear();
                return;
            }

            lstNotas.Items.Add(txtNota.Text);
            txtNota.Clear();
            contador++;
            txtCantidad.Text = contador.ToString();
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("No hay notas para promediar.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double suma = 0;
            foreach (var item in lstNotas.Items)
            {
                double nota = double.Parse(item.ToString());
                suma += nota;
            }

            txtPromedio.Text = (suma / contador).ToString("0.00");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstNotas.Items.Clear();
            txtCantidad.Clear();
            txtPromedio.Clear();
            contador = 0;
        }
    }
}
