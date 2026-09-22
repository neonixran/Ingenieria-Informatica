using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPractico6
{
    public partial class frmPractico6 : Form
    {
        public frmPractico6()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInicial.Text != "" && txtFinal.Text != "" && txtSalto.Text != "")
                {
                    lstSalida.Items.Clear();

                    int Inicial = int.Parse(txtInicial.Text);
                    int Final = int.Parse(txtFinal.Text);
                    int Salto = int.Parse(txtSalto.Text);

                    if (Inicial > Final)
                    {
                        MessageBox.Show("El valor inicial no puede ser mayor al valor final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Salto < 0)
                    {
                        MessageBox.Show("El salto no puede ser menor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    for (int i = Inicial; i <= Final; i = i + Salto)
                    {
                        lstSalida.Items.Add(i);
                    }
                }
            } catch
            {
                MessageBox.Show("Ingrese un dato valido");
            }
        }
    }
}
