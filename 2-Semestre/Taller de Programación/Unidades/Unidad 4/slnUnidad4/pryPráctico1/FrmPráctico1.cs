using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryString1_Simple
{
    public partial class FrmPráctico1 : Form
    {
        public FrmPráctico1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text.ToUpper();
            switch(ciudad)
            {
                case "ARICA":
                    txtCosto.Text = "$6.500";
                    break;
                case "STGO":
                case "SANTIAGO":
                case "SCL":
                    txtCosto.Text = "$0";
                    break;
                case "CONCE":
                case "CCP":
                case "CONCEPCIÓN":
                case "CONCEPCION":
                    txtCosto.Text = "$4.200";
                    break;
                case "TEMUCO":
                case txtCosto.Text:

            }

            if (ciudad == "SANTIAGO")
            {
                txtCosto.Text = "$0";
            } else if (ciudad == "ARICA")
            {
                txtCosto.Text = "$6.500";
            } else
            {
                txtCosto.Text = "$3.800";
            }
        }
    }
}
