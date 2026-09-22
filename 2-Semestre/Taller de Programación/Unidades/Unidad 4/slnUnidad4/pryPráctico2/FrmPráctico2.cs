using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryString2_Metodos
{
    public partial class FrmPráctico2 : Form
    {
        public FrmPráctico2()
        {
            InitializeComponent();
        }

        private void btnVerifica1_Click(object sender, EventArgs e)
        {
            if (txtEntrada.Text.Contains("de"))
            {
                MessageBox.Show("Existe el proposición");
            } else
            {
                MessageBox.Show("No existe el proposición");
            }
        }

        private void btnVerifica2_Click(object sender, EventArgs e)
        {
            int pos = txtEntrada.Text.IndexOf("p");

            if (pos != -1)
            {
                MessageBox.Show(String.Format("La posición de \"p\" es {0}", pos));
            } else
            {
                MessageBox.Show("No hay ninguna \"p\" en el texto.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblSalida.Text = txtEntrada.Text.Length.ToString();
        }
    }
}
