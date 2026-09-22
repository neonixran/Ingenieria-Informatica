namespace pryAtletas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int obtenerCantidadAtletas(string distancia)
        {
            StreamReader atletismo = new StreamReader("../../../../atletismo.txt");
            int cantidad = 0;

            string atleta = atletismo.ReadLine();

            while (atleta != null)
            {
                string[] datos = atleta.Split(';');
                if (datos[2] == distancia.Split(' ')[0])
                {
                    cantidad++;
                }
                atleta = atletismo.ReadLine();
            }

            atletismo.Close();

            return cantidad;
        }

        static void mostrarAtletas(string distancia)
        {
            StreamReader atletismo = new StreamReader("../../../../atletismo.txt");
            string atleta = atletismo.ReadLine();

            int cantidad = obtenerCantidadAtletas(distancia);
            int[] tiempos = new int[cantidad];

            while (atleta != null)
            {
                string[] datos = atleta.Split(';');
            }
            atletismo.Close();

        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            try
            {
                Object distancia = cmbDistancias.SelectedItem;

                if (distancia != null)
                {
                    int cantidadAtletas = obtenerCantidadAtletas(distancia.ToString());
                    txtCantidad.Text = cantidadAtletas.ToString();


                } else
                {
                    MessageBox.Show("Debe seleccionar una distancia", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
