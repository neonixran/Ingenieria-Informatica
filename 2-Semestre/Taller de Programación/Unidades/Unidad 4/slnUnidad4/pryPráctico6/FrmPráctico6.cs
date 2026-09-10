using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace pryPráctico6
{
    public partial class FrmPráctico6 : Form
    {
        public FrmPráctico6()
        {
            InitializeComponent();
        }
        //Declaración de matriz de entero de 20 filas por 5 columnas
        int[,] asistencias = new int[20, 5];

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //Lectura de datos desde el archivo de texto y almacenamiento en la matriz
            try
            {
                //Apertura del archivo con los datos
                StreamReader Archivo_con_datos = new StreamReader("..\\..\\"+txtNombreArchivo.Text);
                //Lectura de titulos del archivo. El primer registro
                string titulos = Archivo_con_datos.ReadLine();
                //Ciclo para leer los 20 registros con 5 notas cada uno
                for (int i = 0; i < 20; i++)
                {
                    //Lectura del registro desde el archivo
                    string registro_valores = Archivo_con_datos.ReadLine();
                    if (registro_valores != null)
                    {
                       //Separación del registro en campos usando el espacio en blanco como separador
                       string[] valores = registro_valores.Split(' ');
                       //Se asigna el primer campo a la primera columna de la matriz
                       for (int j = 0; j < 5; j++)
                       {
                          if (!int.TryParse(valores[j], out asistencias[i, j]))
                          {
                             MessageBox.Show("Error en la lectura de datos. Verifique el contenido del archivo en registro:"+(i+1).ToString());
                             return;
                          }
                       }
                    }
                }
                //Cierre del archivo
                Archivo_con_datos.Close();
                MessageBox.Show("Todos los datos han sido leidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la lectura de datos. Verifique el archivo."+ex.Message);
            }
            
        }


        private void btnPromedios_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSinAsistencia_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAsignaturaMenos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBorrarListBox_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
        }
    }
}
