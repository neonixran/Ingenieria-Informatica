using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico2
{
    public partial class frmPráctico2 : Form
    {
        public frmPráctico2()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente usuario = new Cliente();
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;

                usuario.Calle = txtCalle.Text;
                usuario.Número = int.Parse(txtNúmero.Text);

                MessageBox.Show(String.Format("Nombre del cliente: {0} {1}", usuario.Nombre, usuario.Apellido));

                if (usuario.Número <= 0)
                {
                    MessageBox.Show("El número de la calle debe ser mayor a cero", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    MessageBox.Show("Los datos ingresados están bien", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
