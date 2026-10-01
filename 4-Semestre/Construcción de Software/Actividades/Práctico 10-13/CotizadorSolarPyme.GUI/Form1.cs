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
            LimpiarFormulario();
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

        private void chkFomento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFomento.Checked)
            {
                MessageBox.Show("Se aplicará el subsidio estatal con un descuento del 15%", "Subsidio estatal", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas(out int paneles, out double tarifa, out double inversor, out double presupuesto))
            {
                return; // Detener si la validación falla
            }

            // Cálculos
            double subtotal = CalcularSubtotal(paneles, tarifa, inversor);
            double descuento = CalcularDescuentoFomento(subtotal, chkFomento.Checked);
            double netoConDescuento = subtotal - descuento;
            double iva = CalcularIvaChileno(netoConDescuento);
            double total = netoConDescuento + iva;

            bool esViable = EvaluarViabilidad(total, presupuesto);

            // Renderizado en controles de la interfaz
            lblResSubtotal.Text = $"$ {subtotal:F2} USD";
            lblResDescuento.Text = $"$ {descuento:F2} USD";
            lblResIva.Text = $"$ {iva:F2} USD";
            lblResTotal.Text = $"$ {total:F2} USD";

            if (esViable)
            {
                lblResViabilidad.Text = "PROYECTO VIABLE";
                lblResViabilidad.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblResViabilidad.Text = "PRESUPUESTO INSUFICIENTE";
                lblResViabilidad.ForeColor = Color.Firebrick;
            }

            grpResultados.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir del Cotizador Solar?",
                "Confirmación de Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LimpiarFormulario()
        {
            txtPyme.Clear();
            cboComuna.SelectedIndex = 0;
            txtPaneles.Clear();
            txtTarifaPanel.Clear();
            txtInversor.Clear();
            chkFomento.Checked = false;
            txtPresupuesto.Clear();

            // Resetear labels de resultados
            lblResSubtotal.Text = "$ 0.00 USD";
            lblResDescuento.Text = "$ 0.00 USD";
            lblResIva.Text = "$ 0.00 USD";
            lblResTotal.Text = "$ 0.00 USD";
            lblResViabilidad.Text = "PENDIENTE";
            lblResViabilidad.ForeColor = Color.DarkGray;

            grpResultados.Enabled = false;
            txtPyme.Focus();
        }

        private bool ValidarEntradas(out int paneles, out double tarifa, out double inversor, out double presupuesto)
        {
            paneles = 0;
            tarifa = 0.0;
            inversor = 0.0;
            presupuesto = 0.0;

            if (string.IsNullOrWhiteSpace(txtPyme.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la Pyme", "Pyme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPyme.Focus();

                return false;
            }

            if (!int.TryParse(txtPaneles.Text, out paneles) || (paneles < 1 || paneles > 200))
            {
                MessageBox.Show("Debe ingresar un número válido entre 1 y 200 paneles", "Cantidad paneles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPaneles.Focus();

                return false;
            }

            if (!double.TryParse(txtTarifaPanel.Text, out tarifa) || (tarifa < 50.0 || tarifa > 1500.0))
            {
                MessageBox.Show("Debe ingresar una tarifa válida entre $50 y $1.500 USD", "Tarifa por panel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTarifaPanel.Focus();

                return false;
            }

            if (!double.TryParse(txtInversor.Text, out inversor) || (inversor < 100.0 || inversor > 10000.0))
            {
                MessageBox.Show("Debe ingresar un costo de inversor válido entre $100 y $10.000 USD", "Inversor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInversor.Focus();

                return false;
            }

            if (!double.TryParse(txtPresupuesto.Text, out presupuesto) || (presupuesto < 500.0 || presupuesto > 100000.0))
            {
                MessageBox.Show("Debe ingresar un presupuesto válido entre $500 y $100.000 USD", "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPresupuesto.Focus();

                return false;
            }

            return true;
        }

        private double CalcularSubtotal(int paneles, double tarifa, double inversor)
        {
            return (paneles * tarifa) + inversor;
        }

        private double CalcularDescuentoFomento(double subtotal, bool aplicaFomento)
        {
            return aplicaFomento ? subtotal * 0.15 : 0.0;
        }

        private double CalcularIvaChileno(double netoAfecto)
        {
            return netoAfecto * 0.19;
        }

        private bool EvaluarViabilidad(double totalCotizado, double presupuestoCliente)
        {
            // Margen de tolerancia del 10% adicional con crédito verde
            return totalCotizado <= (presupuestoCliente * 1.10);
        }
    }
}
