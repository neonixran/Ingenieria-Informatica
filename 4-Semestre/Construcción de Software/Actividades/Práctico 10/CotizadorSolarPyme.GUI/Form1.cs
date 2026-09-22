using System.Globalization;

namespace CotizadorSolarPyme.GUI
{
    public partial class FormCotizador : Form
    {
        public FormCotizador()
        {
            InitializeComponent();
            ConfigurarEntornoInicial();
        }
        private void ConfigurarEntornoInicial()
        {
            // Estandarizar formato de punto decimal (.) regional
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Cargar comunas de la Región del Biobío en el ComboBox
            cboComuna.Items.Clear();
            cboComuna.Items.Add("Concepción");
            cboComuna.Items.Add("Chillán");
            cboComuna.Items.Add("Los Ángeles");
            cboComuna.Items.Add("Coronel");
            cboComuna.Items.Add("Talcahuano");
            cboComuna.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePyme.Clear();
            txtCantidadPaneles.Clear();
            txtPrecioPanel.Clear();
            chkDescuentoFomento.Checked = false;
            lblTotalNeto.Text = "Total neto: $0.00 USD";
            txtNombrePyme.Focus();
        }

    }
}
