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
        
        //  Aquí se declara y se programa el método que 
        //  calcula el perímetro de un círculo de radio r
        static double calcularPerímetro(double r)
        {
            double p = 2 * 3.1416 * r;
            return p;
        }

        static double calcularArea(double r)
        {
            double a = 3.1416 * Math.Pow(r, 2);
            return a;
        }

        public void Error(TextBox obj)
        {
            MessageBox.Show("Dato Incorrecto", "ERROR");
            obj.Clear();
            obj.Focus();
        }

        private void btnPerímetro_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(txtRadio.Text);
                double perímetro = calcularPerímetro(r);
                txtPerimetro.Text = perímetro.ToString("N1");
            }
            catch (Exception)
            {
                Error(txtRadio);
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(txtRadio.Text);
                double área = calcularArea(r);
                txtArea.Text = área.ToString("N1");
            }
            catch (Exception)
            {
                Error(txtRadio);
            }
        }
    }
}
