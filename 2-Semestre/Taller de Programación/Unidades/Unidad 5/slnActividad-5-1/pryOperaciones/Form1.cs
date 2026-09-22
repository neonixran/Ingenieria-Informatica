using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOperaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Método que llena un arreglo de n, con N valores aleatorios entre 1000 y 9999
        static int[] LlenarArreglo(int n)
        { 
            int[] arreglo = new int[n];
            Random rnd = new Random(n);
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = rnd.Next(1000*(n/100), 9999-n*5);
            }
            return arreglo;
        }

        //AQUI CREAR MÉTODO QUE OBTIENE EL ANCHO DE UN ARREGLO
            static int obtenerAncho(int[] arreglo)
        {
            int menor = arreglo[0];
            int mayor = arreglo[0];

            int ancho = 0;

            for (int i=1; i < arreglo.Length; i++)
            {
                // Obtener el número menor del arreglo
                if (menor > arreglo[i])
                {
                    menor = arreglo[i];
                }

                // Obtener el número mayor del arreglo
                if (mayor < arreglo[i])
                {
                    mayor = arreglo[i];
                }
            }

            ancho = mayor - menor;

            return ancho;
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            //INICIO sección permite crear y llenar tres arreglos v1, v2 y v3 con valores aletorios.
            //*** NO MODIFICAR ESTA SECCIÓN ***
            Random rnd = new Random(202704);
            int x=rnd.Next(100,200);
            int[] v1= LlenarArreglo(x);
            int y=rnd.Next(150,250);
            int[] v2 = LlenarArreglo(y);
            int z=rnd.Next(300,400);
            int[] v3 = LlenarArreglo(z);
            //FIN sección que crea y llena los tres arreglos v1, v2 y v3

            //DESDE AQUI AGREGAR EL CÓDIGO NECESARIO
            if (rdbArreglo1.Checked)
            {
                txtAncho.Text = obtenerAncho(v1).ToString();
            } else if (rdbArreglo2.Checked)
            {
                txtAncho.Text = obtenerAncho(v2).ToString();
            } else if (rdbArreglo3.Checked)
            {
                txtAncho.Text = obtenerAncho(v3).ToString();
            } else
            {
                MessageBox.Show("No ha seleccionado ningun arreglo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
