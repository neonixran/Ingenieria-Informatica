using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico3
{
    public partial class ImpuestoApp : Form
    {
        public ImpuestoApp()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double Cantidad = Convert.ToDouble(txtCantidadTotal.Text);
            double Porcentaje = Convert.ToDouble(txtImpuesto.Text.Split('%')[0]);

            txtTotal.Text = "$" + (Cantidad + (Cantidad * Porcentaje / 100)).ToString();
        }
    }
}
