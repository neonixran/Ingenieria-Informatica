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

namespace pryEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader eventos = new StreamReader("../../eventos.txt");

                /*
                 * Tipos de accesos:
                 *      0: Entrada
                 *      1: Salidas
                 *      7: Accesos denegados
                 * Número de tarjeta
                 * Fecha
                 * Hora
                 */

                // Leer ingresos
                string dato = eventos.ReadLine();
                int cantidad = 0;

                while (dato != null)
                {
                    string[] campos = dato.Split(';');

                    if (campos[0] == "0")
                    {
                        cantidad++;
                    }

                    dato = eventos.ReadLine();
                }

                eventos.Close();

                // Guardar horas
                int[] horas = new int[cantidad];

                eventos = new StreamReader("../../eventos.txt");

                dato = eventos.ReadLine();

                int indice = 0;

                while (dato != null)
                {
                    string[] campos = dato.Split(';');

                   if (campos[0] == "0")
                    {
                        horas[indice] = int.Parse(campos[3]);

                        indice++;
                    }

                    dato = eventos.ReadLine();
                }

                eventos.Close();

                //Ordenar horas de menor a mayor
                Array.Sort(horas);

                // Guardar las horas
                StreamWriter entradas = new StreamWriter("../../entradas.txt");

                for (int i = 0; i < horas.Length; i++)
                {
                    entradas.WriteLine(horas[i]);
                }

                entradas.Close();
            } catch (Exception ex)
            {

            }
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader eventos = new StreamReader("../../eventos.txt");
                StreamWriter tarjetas = new StreamWriter("../../tarjetas.txt");

                /*
                 * Tipos de accesos:
                 *      0: Entrada
                 *      1: Salidas
                 *      7: Accesos denegados
                 * Número de tarjeta
                 * Fecha
                 * Hora
                 */

                string dato = eventos.ReadLine();
                int numTarjeta = -1;

                while (dato != null)
                {
                    string[] campos = dato.Split(';');
                    int tarjeta = int.Parse(campos[1]);
                    
                    if (tarjeta > numTarjeta)
                    {
                        tarjetas.WriteLine(tarjeta);
                        numTarjeta = tarjeta;
                    }

                    dato = eventos.ReadLine();
                }

                eventos.Close();
                tarjetas.Close();
            } catch
            {

            }
        }
    }
}
