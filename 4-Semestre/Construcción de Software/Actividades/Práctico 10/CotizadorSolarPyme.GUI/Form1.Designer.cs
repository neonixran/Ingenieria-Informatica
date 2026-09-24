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
            components = new System.ComponentModel.Container();
            grpDatosCliente = new GroupBox();
            txtPyme = new TextBox();
            lblPyme = new Label();
            cboComuna = new ComboBox();
            lblComuna = new Label();
            grpEspecificaciones = new GroupBox();
            lblPresupuesto = new Label();
            txtPresupuesto = new TextBox();
            lblInversor = new Label();
            txtInversor = new TextBox();
            lblPaneles = new Label();
            txtPaneles = new TextBox();
            chkFomento = new CheckBox();
            lblTarifaPanel = new Label();
            txtTarifaPanel = new TextBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            grpResultados = new GroupBox();
            lblTotalNeto = new Label();
            lblIva = new Label();
            lblSubtotal = new Label();
            btnSalir = new Button();
            toolTip1 = new ToolTip(components);
            grpDatosCliente.SuspendLayout();
            grpEspecificaciones.SuspendLayout();
            grpResultados.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosCliente
            // 
            grpDatosCliente.Controls.Add(txtPyme);
            grpDatosCliente.Controls.Add(lblPyme);
            grpDatosCliente.Controls.Add(cboComuna);
            grpDatosCliente.Controls.Add(lblComuna);
            grpDatosCliente.Location = new Point(12, 12);
            grpDatosCliente.Name = "grpDatosCliente";
            grpDatosCliente.Size = new Size(350, 171);
            grpDatosCliente.TabIndex = 0;
            grpDatosCliente.TabStop = false;
            grpDatosCliente.Text = "Datos de la PYME Cliente";
            // 
            // txtPyme
            // 
            txtPyme.Location = new Point(20, 48);
            txtPyme.Name = "txtPyme";
            txtPyme.PlaceholderText = "Ej: Agrícola El Roble Ltda.";
            txtPyme.Size = new Size(157, 23);
            txtPyme.TabIndex = 0;
            // 
            // lblPyme
            // 
            lblPyme.AutoSize = true;
            lblPyme.Location = new Point(20, 30);
            lblPyme.Name = "lblPyme";
            lblPyme.Size = new Size(112, 15);
            lblPyme.TabIndex = 0;
            lblPyme.Text = "Nombre de la Pyme";
            // 
            // cboComuna
            // 
            cboComuna.DropDownStyle = ComboBoxStyle.DropDownList;
            cboComuna.FormattingEnabled = true;
            cboComuna.Location = new Point(20, 103);
            cboComuna.Name = "cboComuna";
            cboComuna.Size = new Size(157, 23);
            cboComuna.TabIndex = 1;
            // 
            // lblComuna
            // 
            lblComuna.AutoSize = true;
            lblComuna.Location = new Point(20, 85);
            lblComuna.Name = "lblComuna";
            lblComuna.Size = new Size(160, 15);
            lblComuna.TabIndex = 6;
            lblComuna.Text = "Comuna (Región del Biobío):";
            // 
            // grpEspecificaciones
            // 
            grpEspecificaciones.Controls.Add(lblPresupuesto);
            grpEspecificaciones.Controls.Add(txtPresupuesto);
            grpEspecificaciones.Controls.Add(lblInversor);
            grpEspecificaciones.Controls.Add(txtInversor);
            grpEspecificaciones.Controls.Add(lblPaneles);
            grpEspecificaciones.Controls.Add(txtPaneles);
            grpEspecificaciones.Controls.Add(chkFomento);
            grpEspecificaciones.Controls.Add(lblTarifaPanel);
            grpEspecificaciones.Controls.Add(txtTarifaPanel);
            grpEspecificaciones.Location = new Point(368, 12);
            grpEspecificaciones.Name = "grpEspecificaciones";
            grpEspecificaciones.Size = new Size(379, 171);
            grpEspecificaciones.TabIndex = 1;
            grpEspecificaciones.TabStop = false;
            grpEspecificaciones.Text = "Dimensionamiento Técnico";
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Location = new Point(203, 85);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(72, 15);
            lblPresupuesto.TabIndex = 11;
            lblPresupuesto.Text = "Presupuesto";
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Location = new Point(203, 103);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.PlaceholderText = "500.0 - 100000.0 USD";
            txtPresupuesto.Size = new Size(157, 23);
            txtPresupuesto.TabIndex = 6;
            // 
            // lblInversor
            // 
            lblInversor.AutoSize = true;
            lblInversor.Location = new Point(20, 85);
            lblInversor.Name = "lblInversor";
            lblInversor.Size = new Size(83, 15);
            lblInversor.TabIndex = 9;
            lblInversor.Text = "Costo inversor";
            // 
            // txtInversor
            // 
            txtInversor.Location = new Point(20, 103);
            txtInversor.Name = "txtInversor";
            txtInversor.PlaceholderText = "100.0 - 10000.0 USD";
            txtInversor.Size = new Size(157, 23);
            txtInversor.TabIndex = 4;
            // 
            // lblPaneles
            // 
            lblPaneles.AutoSize = true;
            lblPaneles.Location = new Point(20, 30);
            lblPaneles.Name = "lblPaneles";
            lblPaneles.Size = new Size(114, 15);
            lblPaneles.TabIndex = 2;
            lblPaneles.Text = "Cantidad de Paneles";
            // 
            // txtPaneles
            // 
            txtPaneles.Location = new Point(20, 48);
            txtPaneles.Name = "txtPaneles";
            txtPaneles.PlaceholderText = "1 - 200";
            txtPaneles.Size = new Size(157, 23);
            txtPaneles.TabIndex = 2;
            // 
            // chkFomento
            // 
            chkFomento.AutoSize = true;
            chkFomento.Font = new Font("Segoe UI", 8F);
            chkFomento.Location = new Point(18, 142);
            chkFomento.Name = "chkFomento";
            chkFomento.Size = new Size(355, 17);
            chkFomento.TabIndex = 5;
            chkFomento.Text = "Aplicar subsidio estatal de fomento (Ley Generación Distribuida)";
            toolTip1.SetToolTip(chkFomento, "Aplica un 10% de descuento directo sobre el total neto según la Ley 20.571");
            chkFomento.UseVisualStyleBackColor = true;
            // 
            // lblTarifaPanel
            // 
            lblTarifaPanel.AutoSize = true;
            lblTarifaPanel.Location = new Point(203, 30);
            lblTarifaPanel.Name = "lblTarifaPanel";
            lblTarifaPanel.Size = new Size(93, 15);
            lblTarifaPanel.TabIndex = 4;
            lblTarifaPanel.Text = "Precio por Panel";
            // 
            // txtTarifaPanel
            // 
            txtTarifaPanel.Location = new Point(203, 48);
            txtTarifaPanel.Name = "txtTarifaPanel";
            txtTarifaPanel.PlaceholderText = "50.0 - 1500.0 USD";
            txtTarifaPanel.Size = new Size(157, 23);
            txtTarifaPanel.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(100, 116, 139);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(340, 196);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(135, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "\U0001f9f9 Limpiar Formulario";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 47, 108);
            btnCalcular.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(116, 189);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(191, 34);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "\U0001f9ee Calcular Cotización";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // grpResultados
            // 
            grpResultados.Controls.Add(lblTotalNeto);
            grpResultados.Controls.Add(lblIva);
            grpResultados.Controls.Add(lblSubtotal);
            grpResultados.Enabled = false;
            grpResultados.Location = new Point(16, 229);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new Size(731, 132);
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
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(220, 38, 38);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(508, 196);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(135, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "❌ Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // FormCotizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 373);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpResultados);
            Controls.Add(grpEspecificaciones);
            Controls.Add(grpDatosCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCotizador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Cotización Solar - IPVG 2026";
            Load += FormCotizador_Load;
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
        private TextBox txtTarifaPanel;
        private Label lblTarifaPanel;
        private TextBox txtPaneles;
        private Label lblPaneles;
        private TextBox txtPyme;
        private Label lblPyme;
        private ComboBox cboComuna;
        private Label lblComuna;
        private CheckBox chkFomento;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox grpResultados;
        private Label lblTotalNeto;
        private Label lblIva;
        private Label lblSubtotal;
        private Label lblInversor;
        private TextBox txtInversor;
        private Label lblPresupuesto;
        private TextBox txtPresupuesto;
        private Button btnSalir;
        private ToolTip toolTip1;
    }
}
