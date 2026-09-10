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
    public partial class frmPráctico5 : Form
    {
        public frmPráctico5()
        {
            InitializeComponent();
        }
        static bool ValidaCorreo(string email)
        {
            int arroba = 0;
            int punto = 0;
            int espacioBlanco = 0;
            int eñe = 0;
            int mayúsculas = 0;
            int simboloPuntuación = 0;

            foreach (char Char in email)
            {
                if (Char == '@')
                {
                    arroba++;
                } else if (Char == '.')
                {
                    punto++;
                } else if (char.IsWhiteSpace(Char))
                {
                    espacioBlanco++;
                } else if (Char == 'ñ')
                {
                    eñe++;
                } else if (char.IsUpper(Char))
                {
                    mayúsculas++;
                } else if (Char == '-' )
                {

                }
            }

            if (email.Length > 5 && arroba == 1 && punto > 0 && espacioBlanco == 0 && eñe == 0 && mayúsculas == 0 && simboloPuntuación == 0 && char.IsLetter(email[0]))
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (ValidaCorreo(txtEmail.Text))
            {
                MessageBox.Show("Email OK", "BIEN");
            }
            else
                MessageBox.Show("Email incorrecto", "MAL");
        }
    }
}
