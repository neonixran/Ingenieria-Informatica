using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPloblema1
{
    public partial class frmProblema1 : Form
    {
        public frmProblema1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                Fecha fecha = new Fecha();
                fecha.día = int.Parse(txtDía.Text);
                fecha.mes = int.Parse(txtMes.Text);
                fecha.año = int.Parse(txtAño.Text);

                string fecha1 = fecha.mostrarFecha();
                string fecha2 = fecha.mostrarFecha2();

                MessageBox.Show(fecha1);
                MessageBox.Show(fecha2);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
