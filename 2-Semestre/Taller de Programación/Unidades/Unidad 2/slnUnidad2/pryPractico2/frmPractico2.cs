using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMueveLabel
{
    public partial class frmPractico2 : Form
    {
        public frmPractico2()
        {
            InitializeComponent();
        }

        private void btn0_0_Click(object sender, EventArgs e)
        {
            lblMuéveme.Left = 0;
            lblMuéveme.Top = 0;
            lblMuéveme.ForeColor = Color.Red;
        }

        private void btn200_0_Click(object sender, EventArgs e)
        {
            lblMuéveme.Left = 200;
            lblMuéveme.Top = 0;
            lblMuéveme.ForeColor = Color.Blue;
        }

        private void btn200_200_Click(object sender, EventArgs e)
        {
            lblMuéveme.Left = 200;
            lblMuéveme.Top = 200;
            lblMuéveme.ForeColor = Color.Green;
        }

        private void btn0_200_Click(object sender, EventArgs e)
        {
            lblMuéveme.Left = 0;
            lblMuéveme.Top = 200;
            lblMuéveme.ForeColor = Color.Yellow;
        }
    }
}
