using System.Globalization;

namespace BellaItalia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Estandarización regional de decimales
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Poblar ComboBoxes de forma dinámica
            cboTamano.Items.Clear();
            cboTamano.Items.Add("Personal ($5.000)");
            cboTamano.Items.Add("Mediana ($8.500)");
            cboTamano.Items.Add("Familiar ($12.000)");
            cboTamano.SelectedIndex = 1; // Mediana por defecto

            cboMasa.Items.Clear();
            cboMasa.Items.Add("Tradicional");
            cboMasa.Items.Add("Delgada");
            cboMasa.Items.Add("Borde de Queso (+$1.500)");
            cboMasa.SelectedIndex = 0; // Tradicional por defecto

            rdbRetiro.Checked = true;
            LimpiarResumen();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validación de entradas obligatorias
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, ingrese un número telefónico de contacto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            // Instanciación del objeto de Dominio
            PedidoPizza pedido = new PedidoPizza(
                txtCliente.Text,
                txtTelefono.Text,
                cboTamano.Text.Split(" ")[0],
                cboMasa.Text.Split(" ")[0],
                chkQuesoExtra.Checked,
                chkPepperoni.Checked,
                chkChampinones.Checked,
                chkAceitunas.Checked,
                chkTocino.Checked,
                rdbDelivery.Checked,
                chkConvenioEstudiante.Checked
            );

            // Determinar tamaño seleccionado
            double precioTamano = pedido.CalcularPrecioTamano();

            // Determinar tipo de masa
            double costoMasa = pedido.CalcularCostoMasa();

            // Asignar adicionales
            double costoIngredientesAdicionales = pedido.CalcularCostoIngredientes();

            // Entrega y descuento
            double subtotal = pedido.CalcularSubtotalPizza();
            double montoDescuento = pedido.CalcularMontoDescuento();
            double costoDelivery = pedido.CalcularCostoDelivery();
            double montoIva = pedido.CalcularMontoIva();

            double totalPagar = pedido.CalcularTotalPagar();

            // Renderizar resultados financieros formateados en CLP
            txtSubtotalValor.Text = $"${subtotal.ToString()}";
            txtDescuentoValor.Text = $"-${montoDescuento.ToString()}";
            txtDeliveryValor.Text = $"${costoDelivery.ToString()}";
            txtIvaValor.Text = $"${montoIva.ToString()}";

            txtTotalValor.Text = $"${totalPagar.ToString()}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtTelefono.Clear();
            cboTamano.SelectedIndex = 1;
            cboMasa.SelectedIndex = 0;

            chkQuesoExtra.Checked = false;
            chkPepperoni.Checked = false;
            chkChampinones.Checked = false;
            chkAceitunas.Checked = false;
            chkTocino.Checked = false;

            rdbRetiro.Checked = true;
            chkConvenioEstudiante.Checked = false;

            LimpiarResumen();
            txtCliente.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                $"¿Desea registrar y enviar el pedido de {txtCliente.Text.Trim()} por un total de {lblTotalValor.Text}?",
                "Confirmación de Pedido",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("¡Pedido registrado exitosamente! Se ha enviado a la cocina.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiar_Click(sender, e);
            }
        }

        private void LimpiarResumen()
        {
            txtSubtotalValor.Text = "$ 0 CLP";
            txtDescuentoValor.Text = "$ 0 CLP";
            txtDeliveryValor.Text = "$ 0 CLP";
            txtIvaValor.Text = "$ 0 CLP";
            lblTotalValor.Text = "$ 0 CLP";
            btnConfirmar.Enabled = false;
        }
    }
}
