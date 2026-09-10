using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryPráctico2
{
    public partial class frmPráctico2 : Form
    {
        public frmPráctico2()
        {
            InitializeComponent();
        }

        StreamWriter Frase = new StreamWriter("..\\..\\frases.txt", true);
        bool guardado = false;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                Frase.WriteLine(txtFrase.Text); // Se escribe el dato en el archivo (aún no está guardado)
                txtFrase.ReadOnly = true; // Se deja escrito 
                guardado = true; // Se cambia el estado de la variable "guardado" a verdadero
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (guardado) {
                txtFrase.Clear();
                txtFrase.Focus();

                txtFrase.ReadOnly = false;
                guardado = false;
            } else
            {
                MessageBox.Show("Debe guardar primero los datos en el archivo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Frase.Close();
            MessageBox.Show("Los datos quedaron guardados en el archivo", "MISH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
