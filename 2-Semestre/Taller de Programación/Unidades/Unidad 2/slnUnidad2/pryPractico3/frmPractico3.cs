using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPractico3
{
    public partial class frmPractico3 : Form
    {
        public frmPractico3()
        {
            InitializeComponent();
        }
        
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Nombre:\t{0}\nEdad:\t{1}\nPeso:\t{2}", txtNombre.Text, txtEdad.Text, txtPeso.Text), "Datos obtenidos");
        }
    }
}
