using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGato
{
    public partial class Gato : Form
    {
        public Gato()
        {
            InitializeComponent();
        }

        /// Fila 1, Columna 1
        private void lbl_11_Click(object sender, EventArgs e)
        {
            lbl_11.Text = "";
        }
        private void lblx11_Click(object sender, EventArgs e)
        {
            if (lbl_11.Text == "")
            {
                lbl_11.Text = "X";
            }
        }
        private void lblo11_Click(object sender, EventArgs e)
        {
            if (lbl_11.Text == "") {
                lbl_11.Text = "O";
            }
        }

        /// Fila 1, Columna 2
        private void lbl_12_Click(object sender, EventArgs e)
        {
            lbl_12.Text = "";
        }
        private void lblx12_Click(object sender, EventArgs e)
        {
            if (lbl_12.Text == "")
            {
                lbl_12.Text = "X";
            }
        }
        private void lblo12_Click(object sender, EventArgs e)
        {
            if (lbl_12.Text == "")
            {
                lbl_12.Text = "O";
            }
        }

        /// Fila 1, Columna 3
        private void lbl_13_Click(object sender, EventArgs e)
        {
            lbl_13.Text = "";
        }
        private void lblx13_Click(object sender, EventArgs e)
        {
            if (lbl_13.Text == "")
            {
                lbl_13.Text = "X";
            }
        }
        private void lblo13_Click(object sender, EventArgs e)
        {
            if (lbl_13.Text == "")
            {
                lbl_13.Text = "O";
            }
        }

        // Fila 2, Columna 1
        private void lbl_21_Click(object sender, EventArgs e)
        {
            lbl_21.Text = "";
        }
        private void lblx21_Click(object sender, EventArgs e)
        {

            if (lbl_21.Text == "") {
                lbl_21.Text = "X";
            }

        }
        private void lblo21_Click(object sender, EventArgs e)
        {
            if (lbl_21.Text == "")
            {
                lbl_21.Text = "O";
            }
        }

        // Fila 2, Columna 2
        private void lbl_22_Click(object sender, EventArgs e)
        {
            lbl_22.Text = "";
        }
        private void lblx22_Click(object sender, EventArgs e)
        {
            if (lbl_22.Text == "")
            {
                lbl_22.Text = "X";
            }
        }
        private void lblo22_Click(object sender, EventArgs e)
        {
            if (lbl_22.Text == "")
            {
                lbl_22.Text = "O";
            }
        }

        // Fila 2, Columna 3
        private void lbl_23_Click(object sender, EventArgs e)
        {
            lbl_23.Text = "";
        }
        private void lblx23_Click(object sender, EventArgs e)
        {
            if (lbl_23.Text == "")
            {
                lbl_23.Text = "X";
            }
        }
        private void lblo23_Click(object sender, EventArgs e)
        {
            if (lbl_23.Text == "")
            {
                lbl_23.Text = "O";
            }
        }

        // Fila 3, Columna 1
        private void lbl_31_Click(object sender, EventArgs e)
        {
            lbl_31.Text = "";
        }
        private void lblx31_Click(object sender, EventArgs e)
        {
            if (lbl_31.Text == "")
            {
                lbl_31.Text = "X";
            }
        }
        private void lblo31_Click(object sender, EventArgs e)
        {
            if (lbl_31.Text == "")
            {
                lbl_31.Text = "O";
            }
        }

        // Fila 3, Columna 2
        private void lbl_32_Click(object sender, EventArgs e)
        {
            lbl_32.Text = "";
        }
        private void lblx32_Click(object sender, EventArgs e)
        {

            if (lbl_32.Text == "")
            {
                lbl_32.Text = "X";
            }
        }
        private void lblo32_Click(object sender, EventArgs e)
        {
            if (lbl_32.Text == "")
            {
                lbl_32.Text = "O";
            }
        }

        // Fila 3, Columna 3
        private void lbl_33_Click(object sender, EventArgs e)
        {
            lbl_33.Text = "";
        }
        private void lblx33_Click(object sender, EventArgs e)
        {
            if (lbl_33.Text == "")
            {
                lbl_33.Text = "X";
            }
        }
        private void lblo33_Click(object sender, EventArgs e)
        {
            if (lbl_33.Text == "")
            {
                lbl_33.Text = "O";
            }
        }
    }
}
