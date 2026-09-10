using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico4
{
    public partial class frmPráctico3 : Form
    {
        public frmPráctico3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int[] edad = new int[7];
            edad[0] = 41;
            edad[1] = 22;
            edad[3] = 19;
            edad[6] = 57;
            for (int i = 0; i < edad.Length; i++)
            {
                lstValores.Items.Add(edad[i]);
            }
        }
    }
}
