using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPractico5
{
    public partial class frmPractico5 : Form
    {
        public frmPractico5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = int.Parse(txbEdad.Text);
                
                if (edad < 0 || edad > 123)
                {
                    throw new Exception(); // Lanza una excepción si la edad es negativa
                }
                else if (edad < 18)
                {
                    MessageBox.Show("Usted es menor de edad", "Atención");
                }
                else if (edad < 29)
                {
                    MessageBox.Show("Usted es joven", "Aviso");
                }
                else if (edad < 60)
                {
                    MessageBox.Show("Usted es adulto", "Aviso");
                }
                else
                {
                    MessageBox.Show("Usted es adulto mayor", "Aviso");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese edad válida", "ERROR");
                txbEdad.Clear();
                txbEdad.Focus();
            }
        }
    }
}
