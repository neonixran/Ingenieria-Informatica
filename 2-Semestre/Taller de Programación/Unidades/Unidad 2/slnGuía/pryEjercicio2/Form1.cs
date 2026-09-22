using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double arista = Convert.ToDouble(txtArista.Text);
                double radio = Convert.ToDouble(txtRadio.Text);

                double volumenCaja = arista * arista * arista;
                double volumenPelota = 1.333 * 3.14 * radio * radio * radio;

                double cantidad = Convert.ToInt32(volumenCaja / volumenPelota);
                double sobrante = volumenCaja - (cantidad * volumenPelota);

                if (radio * 2 >= arista)
                {
                    MessageBox.Show("El tamaño de la pelota es muy grande", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtArista.Clear();
                    txtRadio.Clear();

                    txtCantidad.Clear();
                    txtSobrante.Clear();

                    txtArista.Focus();
                } else
                {
                    txtCantidad.Text = cantidad.ToString();
                    txtSobrante.Text = sobrante.ToString("0.000");

                    if (sobrante < 0 )
                    {
                        MessageBox.Show(String.Format("Las {0} pelotas no caben en la caja", cantidad), "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtArista.Clear();
                        txtRadio.Clear();
                        txtCantidad.Clear();
                        txtSobrante.Clear();
                        txtArista.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error en el ingreso de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
