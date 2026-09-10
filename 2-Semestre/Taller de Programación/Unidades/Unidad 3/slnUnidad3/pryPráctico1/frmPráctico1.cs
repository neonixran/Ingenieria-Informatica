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

namespace pryPráctico1
{
    public partial class frmPráctico1 : Form
    {
        public frmPráctico1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter Salida = new StreamWriter("..\\..\\datos-guardados.txt");

                Salida.WriteLine("Primera línea");
                Salida.WriteLine(txtDato1.Text);
                Salida.WriteLine(txtDato2.Text);
                Salida.WriteLine("Última línea");
                Salida.Close();
                txtDato1.Clear();
                txtDato2.Clear();
                MessageBox.Show("Datos guardados");
                txtDato1.Focus();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
