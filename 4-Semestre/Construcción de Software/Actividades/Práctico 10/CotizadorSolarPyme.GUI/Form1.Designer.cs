namespace CotizadorSolarPyme.GUI
{
    partial class FormCotizador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDatosCliente = new GroupBox();
            grpEspecificaciones = new GroupBox();
            lblNombrePyme = new Label();
            txtNombrePyme = new TextBox();
            lblNombrePyme = new Label();
            cboComuna = new ComboBox();
            lblComuna = new Label();
            grpEspecificaciones = new GroupBox();
            lblCantidadPaneles = new Label();
            txtCantidadPaneles = new TextBox();
            chkDescuentoFomento = new CheckBox();
            lblPrecioPanel = new Label();
            txtPrecioPanel = new TextBox();
            btnLimpiarFormulario = new Button();
            btnCalcularCotizacion = new Button();
            grpResultados = new GroupBox();
            lblTotalNeto = new Label();
            lblIva = new Label();
            lblSubtotal = new Label();
            grpDatosCliente.SuspendLayout();
            grpEspecificaciones.SuspendLayout();
            grpResultados.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosCliente
            // 
            grpDatosCliente.Controls.Add(txtNombrePyme);
            grpDatosCliente.Controls.Add(lblNombrePyme);
            grpDatosCliente.Controls.Add(cboComuna);
            grpDatosCliente.Controls.Add(lblComuna);
            grpDatosCliente.Location = new Point(12, 12);
            grpDatosCliente.Name = "grpDatosCliente";
            grpDatosCliente.Size = new Size(350, 174);
            grpDatosCliente.TabIndex = 0;
            grpDatosCliente.TabStop = false;
            grpDatosCliente.Text = "Datos de la PYME Cliente";
            // 
            // txtNombrePyme
            // 
            txtNombrePyme.Location = new Point(20, 48);
            txtNombrePyme.Name = "txtNombrePyme";
            txtNombrePyme.Size = new Size(157, 23);
            txtNombrePyme.TabIndex = 1;
            // 
            // lblNombrePyme
            // 
            lblNombrePyme.AutoSize = true;
            lblNombrePyme.Location = new Point(20, 30);
            lblNombrePyme.Name = "lblNombrePyme";
            lblNombrePyme.Size = new Size(84, 15);
            lblNombrePyme.TabIndex = 0;
            lblNombrePyme.Text = "Nombre Pyme";
            // 
            // cboComuna
            // 
            cboComuna.FormattingEnabled = true;
            cboComuna.Location = new Point(20, 103);
            cboComuna.Name = "cboComuna";
            cboComuna.Size = new Size(157, 23);
            cboComuna.TabIndex = 7;
            // 
            // lblComuna
            // 
            lblComuna.AutoSize = true;
            lblComuna.Location = new Point(20, 85);
            lblComuna.Name = "lblComuna";
            lblComuna.Size = new Size(53, 15);
            lblComuna.TabIndex = 6;
            lblComuna.Text = "Comuna";
            // 
            // grpEspecificaciones
            // 
            grpEspecificaciones.Controls.Add(lblCantidadPaneles);
            grpEspecificaciones.Controls.Add(txtCantidadPaneles);
            grpEspecificaciones.Controls.Add(chkDescuentoFomento);
            grpEspecificaciones.Controls.Add(lblPrecioPanel);
            grpEspecificaciones.Controls.Add(txtPrecioPanel);
            grpEspecificaciones.Location = new Point(368, 12);
            grpEspecificaciones.Name = "grpEspecificaciones";
            grpEspecificaciones.Size = new Size(350, 174);
            grpEspecificaciones.TabIndex = 1;
            grpEspecificaciones.TabStop = false;
            grpEspecificaciones.Text = "Dimensionamiento Técnico";
            // 
            // lblCantidadPaneles
            // 
            lblCantidadPaneles.AutoSize = true;
            lblCantidadPaneles.Location = new Point(20, 30);
            lblCantidadPaneles.Name = "lblCantidadPaneles";
            lblCantidadPaneles.Size = new Size(114, 15);
            lblCantidadPaneles.TabIndex = 2;
            lblCantidadPaneles.Text = "Cantidad de Paneles";
            // 
            // txtCantidadPaneles
            // 
            txtCantidadPaneles.Location = new Point(20, 48);
            txtCantidadPaneles.Name = "txtCantidadPaneles";
            txtCantidadPaneles.Size = new Size(157, 23);
            txtCantidadPaneles.TabIndex = 3;
            // 
            // chkDescuentoFomento
            // 
            chkDescuentoFomento.AutoSize = true;
            chkDescuentoFomento.Font = new Font("Segoe UI", 8F);
            chkDescuentoFomento.Location = new Point(20, 138);
            chkDescuentoFomento.Name = "chkDescuentoFomento";
            chkDescuentoFomento.Size = new Size(299, 17);
            chkDescuentoFomento.TabIndex = 8;
            chkDescuentoFomento.Text = "Aplicar Descuento Estatal por Generación Distribuida";
            chkDescuentoFomento.UseVisualStyleBackColor = true;
            // 
            // lblPrecioPanel
            // 
            lblPrecioPanel.AutoSize = true;
            lblPrecioPanel.Location = new Point(20, 80);
            lblPrecioPanel.Name = "lblPrecioPanel";
            lblPrecioPanel.Size = new Size(93, 15);
            lblPrecioPanel.TabIndex = 4;
            lblPrecioPanel.Text = "Precio por Panel";
            // 
            // txtPrecioPanel
            // 
            txtPrecioPanel.Location = new Point(20, 98);
            txtPrecioPanel.Name = "txtPrecioPanel";
            txtPrecioPanel.Size = new Size(157, 23);
            txtPrecioPanel.TabIndex = 5;
            // 
            // btnLimpiarFormulario
            // 
            btnLimpiarFormulario.Location = new Point(388, 192);
            btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            btnLimpiarFormulario.Size = new Size(125, 23);
            btnLimpiarFormulario.TabIndex = 9;
            btnLimpiarFormulario.Text = "Limpiar Formulario";
            btnLimpiarFormulario.UseVisualStyleBackColor = true;
            btnLimpiarFormulario.Click += btnLimpiar_Click;
            // 
            // btnCalcularCotizacion
            // 
            btnCalcularCotizacion.Location = new Point(219, 192);
            btnCalcularCotizacion.Name = "btnCalcularCotizacion";
            btnCalcularCotizacion.Size = new Size(125, 23);
            btnCalcularCotizacion.TabIndex = 10;
            btnCalcularCotizacion.Text = "Calcular Cotización";
            btnCalcularCotizacion.UseVisualStyleBackColor = true;
            // 
            // grpResultados
            // 
            grpResultados.Controls.Add(lblTotalNeto);
            grpResultados.Controls.Add(lblIva);
            grpResultados.Controls.Add(lblSubtotal);
            grpResultados.Location = new Point(16, 221);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new Size(702, 140);
            grpResultados.TabIndex = 2;
            grpResultados.TabStop = false;
            grpResultados.Text = "Resultados";
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Location = new Point(21, 76);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(118, 15);
            lblTotalNeto.TabIndex = 2;
            lblTotalNeto.Text = "Total neto: $0.00 USD";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(21, 52);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(115, 15);
            lblIva.TabIndex = 1;
            lblIva.Text = "IVA (19%): $0.00 USD";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(21, 28);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(109, 15);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal: $0.00 USD";
            // 
            // FormCotizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 373);
            Controls.Add(btnLimpiarFormulario);
            Controls.Add(btnCalcularCotizacion);
            Controls.Add(grpResultados);
            Controls.Add(grpEspecificaciones);
            Controls.Add(grpDatosCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCotizador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Cotización Solar - IPVG 2026";
            grpDatosCliente.ResumeLayout(false);
            grpDatosCliente.PerformLayout();
            grpEspecificaciones.ResumeLayout(false);
            grpEspecificaciones.PerformLayout();
            grpResultados.ResumeLayout(false);
            grpResultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosCliente;
        private GroupBox grpEspecificaciones;
        private TextBox txtPrecioPanel;
        private Label lblPrecioPanel;
        private TextBox txtCantidadPaneles;
        private Label lblCantidadPaneles;
        private TextBox txtNombrePyme;
        private Label lblNombrePyme;
        private ComboBox cboComuna;
        private Label lblComuna;
        private CheckBox chkDescuentoFomento;
        private Button btnCalcularCotizacion;
        private Button btnLimpiarFormulario;
        private GroupBox grpResultados;
        private Label lblTotalNeto;
        private Label lblIva;
        private Label lblSubtotal;
    }
}
