using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico5
{
    public partial class frmPráctico4 : Form
    {
        public frmPráctico4()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                lstSaldos.Items.Add("$0");
            }
        }

        int[] cuentas = new int[5];
        int[,] trans = new int[100, 2];

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try
            {
                int num_cuenta = cmbCuentas.SelectedIndex;

                if (num_cuenta != -1)
                {
                    if (!String.IsNullOrEmpty(txtMonto.Text))
                    {
                        cuentas[num_cuenta] += int.Parse(txtMonto.Text);
                        lstSaldos.Items[num_cuenta] = cuentas[num_cuenta].ToString("C");

                        for (int i = 0; i < 100; i++)
                        {
                            trans[i, 0] = num_cuenta + 1;
                            trans[i, 1] = int.Parse(txtMonto.Text);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un monto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una cuenta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch
            {

            }
        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            try
            {
                int num_cuenta = cmbCuentas.SelectedIndex;

                if (num_cuenta != -1)
                {
                    int saldo = int.Parse(lstSaldos.Items[num_cuenta].ToString());
                    int giro = int.Parse(txtMonto.Text);

                    if (giro <= saldo)
                    {
                        cuentas[num_cuenta] -= giro;
                        lstSaldos.Items[num_cuenta] = cuentas[num_cuenta].ToString("C");

                        for (int i = 0; i < 100; i++)
                        {
                            trans[i, 0] = num_cuenta + 1;
                            trans[i, 1] = -int.Parse(txtMonto.Text);
                        }
                    } else
                    {
                        MessageBox.Show("El monto a girar supera el saldo disponible", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    MessageBox.Show("Debe seleccionar una cuenta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch
            {

            }
        }
    }
}

