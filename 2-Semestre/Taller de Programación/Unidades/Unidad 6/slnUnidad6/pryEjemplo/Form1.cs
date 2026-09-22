namespace pryEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Persona persona1 = new Persona(); // Llamar a la clase Persona

            // Definir sus atributos
            persona1.Nombre = "Pepito";
            persona1.Edad = 22;
            persona1.Rut = "12.234.544-5";


            // Usar el método esMayor
            string mayor = "";

            if (persona1.esMayor())
            {
                mayor = "Soy mayor";
            } else
            {
                mayor = "No soy mayor";
            }

                MessageBox.Show(String.Format("Mi nombre es {0}, tengo {1} y mi rut es {2}. {3}", persona1.Nombre, persona1.Edad, persona1.Rut, mayor));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
