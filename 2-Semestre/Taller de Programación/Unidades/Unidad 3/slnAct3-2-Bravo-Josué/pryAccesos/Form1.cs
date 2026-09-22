using System;
using System.IO;
using System.Windows.Forms;

namespace pryAccesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string tipo = "";

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedItem != null)
                {
                    // Req. 2: Lista de empleados que ingresaron, salieron o les denegaron el acceso. el tipo de acceso es ingresado por el usuario.
                    StreamWriter salida = new StreamWriter("..//..//salida.txt");

                    StreamReader accesos = new StreamReader("..//..//accesos-2024-2025.txt");
                    string dato = accesos.ReadLine();

                    switch (cmbTipo.SelectedItem)
                    {
                        case "Ingreso":
                            tipo = "0";
                            break;
                        case "Salida":
                            tipo = "1";
                            break;
                        case "Acceso denegado":
                            tipo = "7";
                            break;

                    }

                    salida.WriteLine("Corr\tInt/Out\tNum\tFecha\tHora"); // Titulo

                    while (dato != null)
                    {
                        string[] campo = dato.Split();
                        /* 
                            Campo[0]: Número de operación
                            Campo[1]: Tipo de acceso (0: ingreso, 1: salida, 7: acceso denegado)
                            Campo[2]: Número de la tarjeta
                            Campo[3]: Fecha
                            Campo[4]: Hora
                        */

                        if (campo[1] == tipo)
                        {
                            salida.WriteLine(dato);
                        }

                        dato = accesos.ReadLine();
                    }

                    accesos.Close();
                    salida.Close();

                    MessageBox.Show("Datos de " + cmbTipo.SelectedItem + " guardados en salida.txt\n\nSi había datos guardados previamente, estos fueron reemplazados por los nuevos datos.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un tipo de acceso!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Req. 1: Cantidad de empleados que se les denegó el acceso a la empresa.

            try
            {
                double cantidad = 0;

                StreamReader accesos = new StreamReader("..//..//accesos-2024-2025.txt");
                string dato = accesos.ReadLine();

                while (dato != null)
                {
                    string[] campo = dato.Split();
                    /* 
                        Campo[0]: Número de operación
                        Campo[1]: Tipo de acceso (0: ingreso, 1: salida, 7: acceso denegado)
                        Campo[2]: Número de la tarjeta
                        Campo[3]: Fecha
                        Campo[4]: Hora
                    */

                    if (campo[1] == "7")
                    {
                        cantidad++;
                    }

                    dato = accesos.ReadLine();
                }

                accesos.Close();

                txtCantidad.Text = cantidad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
