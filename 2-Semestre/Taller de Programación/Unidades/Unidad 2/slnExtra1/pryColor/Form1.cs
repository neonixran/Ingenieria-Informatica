using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hscRojo_Scroll(object sender, ScrollEventArgs e)
        {
            txbRojo.Text = hscRojo.Value.ToString();
            txbVerde.Text = hscVerde.Value.ToString();
            txbAzul.Text = hscAzul.Value.ToString();
            picMuestraColor.BackColor = Color.FromArgb(hscRojo.Value, hscVerde.Value, hscAzul.Value);
        }

        private void hscVerde_Scroll(object sender, ScrollEventArgs e)
        {
            txbRojo.Text = hscRojo.Value.ToString();
            txbVerde.Text = hscVerde.Value.ToString();
            txbAzul.Text = hscAzul.Value.ToString();
            picMuestraColor.BackColor = Color.FromArgb(hscRojo.Value, hscVerde.Value, hscAzul.Value);
        }

        private void hscAzul_Scroll(object sender, ScrollEventArgs e)
        {
            txbRojo.Text = hscRojo.Value.ToString();
            txbVerde.Text = hscVerde.Value.ToString();
            txbAzul.Text = hscAzul.Value.ToString();
            picMuestraColor.BackColor = Color.FromArgb(hscRojo.Value, hscVerde.Value, hscAzul.Value);
        }
    }
}
