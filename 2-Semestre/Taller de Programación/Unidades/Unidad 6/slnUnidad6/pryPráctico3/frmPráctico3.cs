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
        CuentaBancaria cuenta = new CuentaBancaria();

        public frmPráctico3()
        {
            InitializeComponent();
            txtSaldo.Text = cuenta.Saldo.ToString();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            try
            {
                cuenta.Retirar(long.Parse(txtMonto.Text));
                txtSaldo.Text = cuenta.Saldo.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbono_Click(object sender, EventArgs e)
        {
            try
            {
                cuenta.Depositar(long.Parse(txtMonto.Text));
                txtSaldo.Text = cuenta.Saldo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
