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
    public partial class frmPráctico3 : Form
    {
        public frmPráctico3()
        {
            InitializeComponent();
        }

        static int calcularMCD(int a, int b)
        {
            int resto;

            do
            {
                resto = a % b;

                if (resto != 0)
                {
                    a = b;
                    b = resto;
                }
            } while (resto > 0);

            return b;
        }

        private void btnCalcularMCD_Click(object sender, EventArgs e)
        {
            int númeroA = int.Parse(txbNumA.Text);
            int númeroB = int.Parse(txbNumB.Text);

            int MCD = calcularMCD(númeroA, númeroB);
            txtmcm.Text = MCD.ToString();
        }
    }
}
