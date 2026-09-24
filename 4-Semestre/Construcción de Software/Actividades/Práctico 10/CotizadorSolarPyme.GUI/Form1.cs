using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CotizadorSolarPyme.GUI
{
    public partial class FormCotizador : Form
    {
        public FormCotizador()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPyme.Clear();
            txtPaneles.Clear();
            txtTarifaPanel.Clear();
            chkFomento.Checked = false;
            lblTotalNeto.Text = "Total neto: $0.00 USD";
            txtPyme.Focus();
        }

        private void FormCotizador_Load(object sender, EventArgs e)
        {
            // Configurar el formato decimal regional a nivel de hilo ejecutor
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Poblamiento dinámico del ComboBox de comunas de la Región del Biobío
            cboComuna.Items.Clear();
            cboComuna.Items.Add("Concepción");
            cboComuna.Items.Add("Talcahuano");
            cboComuna.Items.Add("San Pedro de la Paz");
            cboComuna.Items.Add("Chiguayante");
            cboComuna.Items.Add("Coronel");
            cboComuna.Items.Add("Lota");
            cboComuna.Items.Add("Los Ángeles");
            cboComuna.Items.Add("Chillán");

            // Seleccionar la primera comuna por defecto
            if (cboComuna.Items.Count > 0)
            {
                cboComuna.SelectedIndex = 0;
            }
        }
    }
}
