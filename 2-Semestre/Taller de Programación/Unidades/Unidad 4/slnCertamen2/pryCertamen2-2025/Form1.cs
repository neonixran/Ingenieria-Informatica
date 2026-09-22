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
using System.Net.Http.Headers;

namespace pryCertamen2_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Contabilizar registros
                StreamReader registros = new StreamReader("../../votos.txt");

                string registro = registros.ReadLine();
                int contador = 0;

                while (registro != null)
                {
                    contador++;
                    registro = registros.ReadLine();
                }

                registros.Close();

                // Guardar votos en el arreglo
                registros = new StreamReader("../../votos.txt");

                registro = registros.ReadLine();

                int indice = 0;
                int[] votos = new int[contador];

                while (registro != null)
                {
                    votos[indice] = int.Parse(registro);

                    registro = registros.ReadLine();
                    indice++;
                }

                registros.Close();

                /*
                 * Contar votos por categoría:
                     * Valor 0: Voto en blanco
                     * Valor 1: Candidato 1
                     * Valor 2: Candidato 2
                     * Valor 3: Voto nulo
                     * Cualquier valor: Valor incorrecto
                 */

                int cantidato1 = 0;
                int cantidato2 = 0;

                int votosBlanco = 0;
                int votoNulo = 0;
                int valorIncorrecto = 0;

                for (int i = 0; i < votos.Length; i++)
                {
                    if (votos[i] == 0)
                    {
                        votosBlanco++;
                    } else if (votos[i] == 1)
                    {
                        cantidato1++;
                    } else if (votos[i] == 2)
                    {
                        cantidato2++;
                    }else if (votos[i] == 3)
                    {
                        votoNulo++;
                    } else
                    {
                        valorIncorrecto++;
                        votos[i] = 3; // Convertir valor incorrecto a voto nulo
                    }
                }

                // Mostrar en pantalla los votos y registros totales
                txtRegistros.Text = votos.Length.ToString();
                txtCandidato1.Text = cantidato1.ToString();
                txtCandidato2.Text = cantidato2.ToString();

                // Guardar votos a resultados.txt
                StreamWriter resultados = new StreamWriter("../../resultados.txt");

                votoNulo += valorIncorrecto; // Suma de votos nulos y valores incorrectos.
                resultados.WriteLine("Votos blancos:\t" + votosBlanco);
                resultados.WriteLine("Votos nulos\t" + votoNulo);
                resultados.WriteLine("Votos convertidos\t" + valorIncorrecto);

                resultados.Close();

                // Mostrar candidato ganador
                if (cantidato1 > cantidato2)
                {
                    MessageBox.Show("Ganó el candidato 1");
                } else if (cantidato2 > cantidato1)
                {
                    MessageBox.Show("Ganó el candidato 2");
                } else
                {
                    MessageBox.Show("Hubo un empate");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
