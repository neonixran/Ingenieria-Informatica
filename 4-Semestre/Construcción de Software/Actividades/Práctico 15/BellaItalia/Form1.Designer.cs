namespace BellaItalia
{
    partial class Form1
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
            grpCliente = new GroupBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCliente = new TextBox();
            lblCliente = new Label();
            grpIngredientes = new GroupBox();
            chkTocino = new CheckBox();
            chkChampinones = new CheckBox();
            chkPepperoni = new CheckBox();
            chkAceitunas = new CheckBox();
            chkQuesoExtra = new CheckBox();
            groupBox1 = new GroupBox();
            txtTotalValor = new Label();
            txtIvaValor = new Label();
            txtDeliveryValor = new Label();
            txtDescuentoValor = new Label();
            txtSubtotalValor = new Label();
            lblTotalValor = new Label();
            lblSeparador = new Label();
            lblIvaValor = new Label();
            lblDeliveryValor = new Label();
            lblDescuentoValor = new Label();
            lblSubtotalValor = new Label();
            rdbDelivery = new RadioButton();
            grpEntrega = new GroupBox();
            chkConvenioEstudiante = new CheckBox();
            rdbRetiro = new RadioButton();
            grpPizza = new GroupBox();
            lblMasa = new Label();
            cboMasa = new ComboBox();
            lblTamano = new Label();
            cboTamano = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnConfirmar = new Button();
            grpCliente.SuspendLayout();
            grpIngredientes.SuspendLayout();
            groupBox1.SuspendLayout();
            grpEntrega.SuspendLayout();
            grpPizza.SuspendLayout();
            SuspendLayout();
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(txtTelefono);
            grpCliente.Controls.Add(lblTelefono);
            grpCliente.Controls.Add(txtCliente);
            grpCliente.Controls.Add(lblCliente);
            grpCliente.Location = new Point(12, 12);
            grpCliente.Name = "grpCliente";
            grpCliente.Size = new Size(405, 90);
            grpCliente.TabIndex = 0;
            grpCliente.TabStop = false;
            grpCliente.Text = "Datos del Cliente";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(267, 33);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(207, 37);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(66, 33);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(130, 23);
            txtCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(6, 37);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Nombre:";
            // 
            // grpIngredientes
            // 
            grpIngredientes.Controls.Add(chkTocino);
            grpIngredientes.Controls.Add(chkChampinones);
            grpIngredientes.Controls.Add(chkPepperoni);
            grpIngredientes.Controls.Add(chkAceitunas);
            grpIngredientes.Controls.Add(chkQuesoExtra);
            grpIngredientes.Location = new Point(433, 12);
            grpIngredientes.Name = "grpIngredientes";
            grpIngredientes.Size = new Size(291, 90);
            grpIngredientes.TabIndex = 1;
            grpIngredientes.TabStop = false;
            grpIngredientes.Text = "Adicionales ($800 c/u)";
            // 
            // chkTocino
            // 
            chkTocino.AutoSize = true;
            chkTocino.Location = new Point(95, 46);
            chkTocino.Name = "chkTocino";
            chkTocino.Size = new Size(62, 19);
            chkTocino.TabIndex = 4;
            chkTocino.Text = "Tocino";
            chkTocino.UseVisualStyleBackColor = true;
            // 
            // chkChampinones
            // 
            chkChampinones.AutoSize = true;
            chkChampinones.Location = new Point(185, 22);
            chkChampinones.Name = "chkChampinones";
            chkChampinones.Size = new Size(100, 19);
            chkChampinones.TabIndex = 3;
            chkChampinones.Text = "Champiñones";
            chkChampinones.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            chkPepperoni.AutoSize = true;
            chkPepperoni.Location = new Point(99, 22);
            chkPepperoni.Name = "chkPepperoni";
            chkPepperoni.Size = new Size(80, 19);
            chkPepperoni.TabIndex = 2;
            chkPepperoni.Text = "Pepperoni";
            chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkAceitunas
            // 
            chkAceitunas.AutoSize = true;
            chkAceitunas.Location = new Point(11, 46);
            chkAceitunas.Name = "chkAceitunas";
            chkAceitunas.Size = new Size(78, 19);
            chkAceitunas.TabIndex = 1;
            chkAceitunas.Text = "Aceitunas";
            chkAceitunas.UseVisualStyleBackColor = true;
            // 
            // chkQuesoExtra
            // 
            chkQuesoExtra.AutoSize = true;
            chkQuesoExtra.Location = new Point(11, 21);
            chkQuesoExtra.Name = "chkQuesoExtra";
            chkQuesoExtra.Size = new Size(88, 19);
            chkQuesoExtra.TabIndex = 0;
            chkQuesoExtra.Text = "Queso extra";
            chkQuesoExtra.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotalValor);
            groupBox1.Controls.Add(txtIvaValor);
            groupBox1.Controls.Add(txtDeliveryValor);
            groupBox1.Controls.Add(txtDescuentoValor);
            groupBox1.Controls.Add(txtSubtotalValor);
            groupBox1.Controls.Add(lblTotalValor);
            groupBox1.Controls.Add(lblSeparador);
            groupBox1.Controls.Add(lblIvaValor);
            groupBox1.Controls.Add(lblDeliveryValor);
            groupBox1.Controls.Add(lblDescuentoValor);
            groupBox1.Controls.Add(lblSubtotalValor);
            groupBox1.Location = new Point(11, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 162);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Pago";
            // 
            // txtTotalValor
            // 
            txtTotalValor.AutoSize = true;
            txtTotalValor.Location = new Point(212, 131);
            txtTotalValor.Name = "txtTotalValor";
            txtTotalValor.Size = new Size(19, 15);
            txtTotalValor.TabIndex = 10;
            txtTotalValor.Text = "$0";
            txtTotalValor.TextAlign = ContentAlignment.TopRight;
            // 
            // txtIvaValor
            // 
            txtIvaValor.AutoSize = true;
            txtIvaValor.Location = new Point(212, 92);
            txtIvaValor.Name = "txtIvaValor";
            txtIvaValor.Size = new Size(19, 15);
            txtIvaValor.TabIndex = 9;
            txtIvaValor.Text = "$0";
            // 
            // txtDeliveryValor
            // 
            txtDeliveryValor.AutoSize = true;
            txtDeliveryValor.Location = new Point(212, 72);
            txtDeliveryValor.Name = "txtDeliveryValor";
            txtDeliveryValor.Size = new Size(19, 15);
            txtDeliveryValor.TabIndex = 8;
            txtDeliveryValor.Text = "$0";
            // 
            // txtDescuentoValor
            // 
            txtDescuentoValor.AutoSize = true;
            txtDescuentoValor.Location = new Point(212, 52);
            txtDescuentoValor.Name = "txtDescuentoValor";
            txtDescuentoValor.Size = new Size(19, 15);
            txtDescuentoValor.TabIndex = 7;
            txtDescuentoValor.Text = "$0";
            txtDescuentoValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSubtotalValor
            // 
            txtSubtotalValor.AutoSize = true;
            txtSubtotalValor.Location = new Point(212, 32);
            txtSubtotalValor.Name = "txtSubtotalValor";
            txtSubtotalValor.Size = new Size(19, 15);
            txtSubtotalValor.TabIndex = 6;
            txtSubtotalValor.Text = "$0";
            txtSubtotalValor.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Location = new Point(10, 131);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(95, 15);
            lblTotalValor.TabIndex = 5;
            lblTotalValor.Text = "TOTAL A PAGAR:";
            // 
            // lblSeparador
            // 
            lblSeparador.AutoSize = true;
            lblSeparador.Location = new Point(9, 107);
            lblSeparador.Name = "lblSeparador";
            lblSeparador.Size = new Size(222, 15);
            lblSeparador.TabIndex = 4;
            lblSeparador.Text = "___________________________________________";
            // 
            // lblIvaValor
            // 
            lblIvaValor.AutoSize = true;
            lblIvaValor.Location = new Point(9, 92);
            lblIvaValor.Name = "lblIvaValor";
            lblIvaValor.Size = new Size(104, 15);
            lblIvaValor.TabIndex = 3;
            lblIvaValor.Text = "IVA Chileno (19%):";
            // 
            // lblDeliveryValor
            // 
            lblDeliveryValor.AutoSize = true;
            lblDeliveryValor.Location = new Point(9, 72);
            lblDeliveryValor.Name = "lblDeliveryValor";
            lblDeliveryValor.Size = new Size(98, 15);
            lblDeliveryValor.TabIndex = 2;
            lblDeliveryValor.Text = "Recargo Delivery:";
            // 
            // lblDescuentoValor
            // 
            lblDescuentoValor.AutoSize = true;
            lblDescuentoValor.Location = new Point(9, 52);
            lblDescuentoValor.Name = "lblDescuentoValor";
            lblDescuentoValor.Size = new Size(99, 15);
            lblDescuentoValor.TabIndex = 1;
            lblDescuentoValor.Text = "Descuento (10%):";
            // 
            // lblSubtotalValor
            // 
            lblSubtotalValor.AutoSize = true;
            lblSubtotalValor.Location = new Point(9, 32);
            lblSubtotalValor.Name = "lblSubtotalValor";
            lblSubtotalValor.Size = new Size(83, 15);
            lblSubtotalValor.TabIndex = 0;
            lblSubtotalValor.Text = "Subtotal Pizza:";
            // 
            // rdbDelivery
            // 
            rdbDelivery.AutoSize = true;
            rdbDelivery.Location = new Point(118, 23);
            rdbDelivery.Name = "rdbDelivery";
            rdbDelivery.Size = new Size(119, 19);
            rdbDelivery.TabIndex = 1;
            rdbDelivery.TabStop = true;
            rdbDelivery.Text = "Delivery (+$2.000)";
            rdbDelivery.UseVisualStyleBackColor = true;
            // 
            // grpEntrega
            // 
            grpEntrega.Controls.Add(chkConvenioEstudiante);
            grpEntrega.Controls.Add(rdbDelivery);
            grpEntrega.Controls.Add(rdbRetiro);
            grpEntrega.Location = new Point(433, 112);
            grpEntrega.Name = "grpEntrega";
            grpEntrega.Size = new Size(291, 90);
            grpEntrega.TabIndex = 3;
            grpEntrega.TabStop = false;
            grpEntrega.Text = "Servicio y Descuento";
            // 
            // chkConvenioEstudiante
            // 
            chkConvenioEstudiante.AutoSize = true;
            chkConvenioEstudiante.Location = new Point(9, 54);
            chkConvenioEstudiante.Name = "chkConvenioEstudiante";
            chkConvenioEstudiante.Size = new Size(226, 19);
            chkConvenioEstudiante.TabIndex = 2;
            chkConvenioEstudiante.Text = "Convenio Estudiante/IPVG (10% Dcto)";
            chkConvenioEstudiante.UseVisualStyleBackColor = true;
            // 
            // rdbRetiro
            // 
            rdbRetiro.AutoSize = true;
            rdbRetiro.Location = new Point(9, 23);
            rdbRetiro.Name = "rdbRetiro";
            rdbRetiro.Size = new Size(103, 19);
            rdbRetiro.TabIndex = 0;
            rdbRetiro.TabStop = true;
            rdbRetiro.Text = "Retiro en Local";
            rdbRetiro.UseVisualStyleBackColor = true;
            // 
            // grpPizza
            // 
            grpPizza.Controls.Add(lblMasa);
            grpPizza.Controls.Add(cboMasa);
            grpPizza.Controls.Add(lblTamano);
            grpPizza.Controls.Add(cboTamano);
            grpPizza.Location = new Point(12, 112);
            grpPizza.Name = "grpPizza";
            grpPizza.Size = new Size(405, 90);
            grpPizza.TabIndex = 4;
            grpPizza.TabStop = false;
            grpPizza.Text = "Tamaño y Masa";
            // 
            // lblMasa
            // 
            lblMasa.AutoSize = true;
            lblMasa.Location = new Point(9, 54);
            lblMasa.Name = "lblMasa";
            lblMasa.Size = new Size(65, 15);
            lblMasa.TabIndex = 6;
            lblMasa.Text = "Tipo Masa:";
            // 
            // cboMasa
            // 
            cboMasa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMasa.FormattingEnabled = true;
            cboMasa.Location = new Point(78, 50);
            cboMasa.Name = "cboMasa";
            cboMasa.Size = new Size(185, 23);
            cboMasa.TabIndex = 5;
            // 
            // lblTamano
            // 
            lblTamano.AutoSize = true;
            lblTamano.Location = new Point(9, 25);
            lblTamano.Name = "lblTamano";
            lblTamano.Size = new Size(53, 15);
            lblTamano.TabIndex = 4;
            lblTamano.Text = "Tamaño:";
            // 
            // cboTamano
            // 
            cboTamano.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTamano.FormattingEnabled = true;
            cboTamano.Location = new Point(66, 21);
            cboTamano.Name = "cboTamano";
            cboTamano.Size = new Size(197, 23);
            cboTamano.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(145, 217);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(136, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "⚡Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(286, 217);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(136, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "\U0001f9f9 Nuevo Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(427, 217);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(136, 23);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "✅ Confirmar Pedido";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 420);
            Controls.Add(btnConfirmar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpPizza);
            Controls.Add(grpEntrega);
            Controls.Add(groupBox1);
            Controls.Add(grpIngredientes);
            Controls.Add(grpCliente);
            Name = "Form1";
            Text = "🍕 Sistema de Pedidos - Pizzería Bella Italia (v1.0)";
            Load += Form1_Load;
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            grpIngredientes.ResumeLayout(false);
            grpIngredientes.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpEntrega.ResumeLayout(false);
            grpEntrega.PerformLayout();
            grpPizza.ResumeLayout(false);
            grpPizza.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCliente;
        private GroupBox grpIngredientes;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCliente;
        private Label lblCliente;
        private GroupBox groupBox1;
        private GroupBox grpEntrega;
        private GroupBox grpPizza;
        private Label lblTamano;
        private ComboBox cboTamano;
        private Label lblMasa;
        private ComboBox cboMasa;
        private CheckBox chkChampinones;
        private CheckBox chkPepperoni;
        private CheckBox chkAceitunas;
        private CheckBox chkQuesoExtra;
        private CheckBox chkTocino;
        private Label lblDescuentoValor;
        private Label lblSubtotalValor;
        private CheckBox chkConvenioEstudiante;
        private RadioButton rdbDelivery;
        private RadioButton rdbRetiro;
        private Label lblIvaValor;
        private Label lblDeliveryValor;
        private Label lblTotalValor;
        private Label lblSeparador;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnConfirmar;
        private Label txtTotalValor;
        private Label txtIvaValor;
        private Label txtDeliveryValor;
        private Label txtDescuentoValor;
        private Label txtSubtotalValor;
    }
}
