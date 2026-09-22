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

namespace pryArchivo
{
    public partial class frmArchivo : Form
    {
        public frmArchivo()
        {
            InitializeComponent();
        }

        double registros = 0;
        int mayores = 0;

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNúmero.Text != "")
                {
                    if (int.Parse(txtNúmero.Text) < 80 || int.Parse(txtNúmero.Text) > 110)
                    {
                        MessageBox.Show("Debe ser un número desde 80 hasta 110", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNúmero.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un número", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNúmero.Focus();
                    return;
                }

                btnLimpiar.PerformClick(); // Simula el click en el botón de limpiar para recargar los datos y resultados

                StreamReader datos = new StreamReader("..//..//valores.txt");
                string número = datos.ReadLine();

                while (número != null)
                {
                    if (int.Parse(número) > double.Parse(txtNúmero.Text))
                    {
                        mayores += 1;
                    }

                    registros += int.Parse(número);

                    lstDatos.Items.Add(número);
                    número = datos.ReadLine();
                }
                datos.Close();

                txtRegistros.Text = lstDatos.Items.Count.ToString();
                txtPromedio.Text = (registros / lstDatos.Items.Count).ToString("N2");
                txtMayorRegistros.Text = mayores.ToString();
            } catch
            {
                MessageBox.Show("Ocurrió un error inesperado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            txtRegistros.Clear();
            txtPromedio.Clear();
            txtMayorRegistros.Clear();

            registros = 0;
            mayores = 0;

            btnLeer.Focus();
        }
    }
}
