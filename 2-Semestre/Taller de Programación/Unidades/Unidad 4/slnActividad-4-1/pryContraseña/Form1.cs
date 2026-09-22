using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryContraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            /*
                Requisitos:
                - Longitud desde 8 caracteres.
                - Debe tener números.
                - Debe tener mayúsculas o minúsculas.
             */
            if (txtContraseña.Text.Length < 8)
            {
                MessageBox.Show("La longitud debe ser mayor a 8 caracteres", "Longitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtOtravez.Clear();
                txtContraseña.Focus();
                return;
            }

            if (txtContraseña.Text != txtOtravez.Text)
            {
                MessageBox.Show("Las contraseñas no son las mismas", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtOtravez.Clear();
                txtContraseña.Focus();
                return;
            }

            int números = 0;
            int mayúsculas_minúsculas = 0;

            foreach (char ch in txtContraseña.Text)
            {
                if (Char.IsNumber(ch))
                {
                    números++;
                }

                if (Char.IsUpper(ch) || Char.IsLower(ch))
                {
                    mayúsculas_minúsculas++;
                }
            }

            if (números <= 0)
            {
                MessageBox.Show("Debe contener números", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (mayúsculas_minúsculas <= 0)
            {
                MessageBox.Show("Debe contener mayúsculas o minúsculas", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (números > 0 && mayúsculas_minúsculas > 0)
            {
                MessageBox.Show("Contraseña robusta", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Contraseña débil", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
