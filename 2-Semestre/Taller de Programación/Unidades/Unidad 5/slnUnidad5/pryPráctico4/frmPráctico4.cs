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
    public partial class frmPráctico4 : Form
    {
        public frmPráctico4()
        {
            InitializeComponent();
        }

        static int ObtenerMayor(int[] v)
        {
            int mayor = v[0];
            for (int i = 1; i < v.Length; i++)
                if (mayor < v[i])
                    mayor = v[i];
            return mayor;
        }

        static int ObtenerMenor(int[] v)
        {
            int menor = v[0];
            for (int i = 1; i < v.Length; i++)
                if (menor > v[i])
                    menor = v[i];
            return menor;
        }

        static double ObtenerPromedio(int[] v)
        {
            double suma = v[0];

            for (int i = 1; i < v.Length; i++)
            {
                suma += v[i];
            }

            double promedio = suma / v.Length;
            return promedio;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ValoresTexto = txtValores.Text.Split();
                int[] valores = new int[ValoresTexto.Length];
                for (int i = 0; i < ValoresTexto.Length; i++)
                {
                    valores[i] = int.Parse(ValoresTexto[i]);
                }
                txtMayor.Text = ObtenerMayor(valores).ToString();
                txtMenor.Text = ObtenerMenor(valores).ToString();
                txtPromedio.Text = ObtenerPromedio(valores).ToString("N2");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
