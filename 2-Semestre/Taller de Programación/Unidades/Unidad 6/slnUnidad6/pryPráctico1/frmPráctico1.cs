using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico1
{
    public partial class frmPráctico1 : Form
    {
        public frmPráctico1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Auto autito = new Auto();
            autito.Marca = txtMarca.Text;
            autito.Modelo = txtModelo.Text;
            autito.Año = 2020;

            txtAño.Text = autito.Año.ToString();

            MessageBox.Show(String.Format("MARCA: {0}\nMODELO: {1}\nAÑO: {2}", autito.Marca, autito.Modelo, autito.Año.ToString()));
        }
    }
}
