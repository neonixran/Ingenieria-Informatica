using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCertamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Asistencia
                int Asistencia = int.Parse(txtAsistencia.Text);


                if (Asistencia <= 1 || Asistencia >= 100)
                {
                    MessageBox.Show("Ingrese solo porcentaje de asistencia dentro del rango 1 a 100", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAsistencia.Focus();
                    return;
                }

                // Asignatura 1
                double Eval1_1 = double.Parse(txtEval1_1.Text);
                double Eval2_1 = double.Parse(txtEval2_1.Text);
                double Eval3_1 = double.Parse(txtEval3_1.Text);

                double NotaFinal_1 = Eval1_1 * 0.25 + Eval2_1 * 0.35 + Eval3_1 * 0.4;
                txtFinal1.Text = NotaFinal_1.ToString("N1");

                if (NotaFinal_1 >= 4.0 && NotaFinal_1 < 5.5 && Asistencia < 70 || NotaFinal_1 < 4.0)
                {
                    txtEstado1.Text = "EXAMEN";
                }
                else if (NotaFinal_1 >= 5.5 || NotaFinal_1 >= 4.0 && NotaFinal_1 <= 5.5 && Asistencia >= 70)
                {
                    txtEstado1.Text = "EXIMIDO";
                }

                // Asignatura 2
                double Eval1_2 = double.Parse(txtEval1_2.Text);
                double Eval2_2 = double.Parse(txtEval2_2.Text);
                double Eval3_2 = double.Parse(txtEval3_2.Text);

                double NotaFinal_2 = Eval1_2 * 0.25 + Eval2_2 * 0.35 + Eval3_2 * 0.4;
                txtFinal2.Text = NotaFinal_2.ToString("N1");

                if (NotaFinal_2 >= 4.0 && NotaFinal_2 < 5.5 && Asistencia < 70 || NotaFinal_2 < 4.0)
                {
                    txtEstado2.Text = "EXAMEN";
                } else if (NotaFinal_2 >= 5.5 || NotaFinal_2 >= 4.0 && NotaFinal_2 <= 5.5 && Asistencia >= 70)
                {
                    txtEstado2.Text = "EXIMIDO";
                }

                //Promedio
                double PromedioFinal = (NotaFinal_1 + NotaFinal_2) / 2;
                txtPromedio.Text = PromedioFinal.ToString("N2");

                if (PromedioFinal > 6.0)
                {
                    MessageBox.Show("Felicitaciones " + txtNombre.Text);
                }

            } catch (Exception)
            {
                MessageBox.Show("Ocurrió un error en el ingreso de datos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtAsistencia.Clear();
            
            txtAsignatura1.Clear();
            txtEval1_1.Clear();
            txtEval2_1.Clear();
            txtEval3_1.Clear();
            txtFinal1.Clear();
            txtEstado1.Clear();

            txtAsignatura2.Clear();
            txtEval1_2.Clear();
            txtEval2_2.Clear();
            txtEval3_2.Clear();
            txtFinal2.Clear();
            txtEstado2.Clear();

            txtPromedio.Clear();

            txtNombre.Focus();
        }
    }
}
