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

namespace pryCertamen2_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int obtenerRegistros(string archivo)
        {
            StreamReader registros = new StreamReader("../../" + archivo);
            string registro = registros.ReadLine();

            int contador = 0;

            while (registro != null)
            {
                contador++;
                registro = registros.ReadLine();
            }

            registros.Close();

            return contador;
        }

        static int[] guardarVotos(string archivo, int tamaño)
        {
            StreamReader registros = new StreamReader("../../" + archivo);
            string registro = registros.ReadLine();

            int i = 0;
            int[] v = new int[tamaño];

            while (registro != null)
            {
                v[i] = int.Parse(registro);
                i++;
                registro = registros.ReadLine();
            }

            registros.Close();

            return v;
        }

        static void guardarResultados(int blancos, int nulos, int convertidos)
        {
            StreamWriter resultados = new StreamWriter("../../resultados.txt");

            resultados.WriteLine("Votos blancos:\t" + blancos.ToString());
            resultados.WriteLine("Votos nulos:\t" + nulos.ToString());
            resultados.WriteLine("Votos convertidos:\t" + convertidos.ToString());

            resultados.Close();
        }

        private void btnLeerMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadRegistros = obtenerRegistros("votos.txt");

                int[] votos = new int[cantidadRegistros];
                votos = guardarVotos("votos.txt", cantidadRegistros);

                int votosBlancos = 0;
                int votosCan1 = 0;
                int votosCan2 = 0;
                int votosNulos = 0;
                int votosIncorrectos = 0;

                for (int i = 0; i < votos.Length; i++)
                {
                    if (votos[i] == 0) // Voto en blanco
                    {
                        votosBlancos++;
                    } else if (votos[i] == 1) // Voto candidato 1
                    {
                        votosCan1++;
                    } else if (votos[i] == 2) // Voto candidato 2
                    {
                        votosCan2++;
                    } else if (votos[i] == 3) // Voto nulo
                    {
                        votosNulos++;
                    } else // Voto incorrecto
                    {
                        votosIncorrectos++;
                        votos[i] = 3;
                    }
                }

                txtRegistros.Text = cantidadRegistros.ToString();
                txtCan1.Text = votosCan1.ToString();
                txtCan2.Text = votosCan2.ToString();

                votosNulos += votosIncorrectos;
                guardarResultados(votosBlancos, votosNulos, votosIncorrectos);

                if (votosCan1 > votosCan2)
                {
                    MessageBox.Show("Ganó el candidato 1", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (votosCan2 > votosCan1)
                {
                    MessageBox.Show("Ganó el candidato 2", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Hubo un empate entre los candidatos", "EMPATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
