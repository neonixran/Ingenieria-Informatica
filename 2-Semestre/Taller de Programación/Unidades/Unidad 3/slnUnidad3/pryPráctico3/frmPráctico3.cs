using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico3
{
    public partial class frmPráctico3 : Form
    {
        public frmPráctico3()
        {
            InitializeComponent();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader archivo = new StreamReader(txtNombre.Text);
                string dato = archivo.ReadLine();

                while (dato != null)
                {
                    MessageBox.Show("while");
                    lstDatos.Items.Add(dato);
                    dato = archivo.ReadLine();
                }

                archivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
