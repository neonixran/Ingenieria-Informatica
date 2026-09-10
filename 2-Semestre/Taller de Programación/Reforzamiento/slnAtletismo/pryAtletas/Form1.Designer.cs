namespace pryAtletas
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
            cmbDistancias = new ComboBox();
            lblDistancias = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnObtener = new Button();
            lstAtletas = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbDistancias
            // 
            cmbDistancias.FormattingEnabled = true;
            cmbDistancias.Items.AddRange(new object[] { "200 metros", "400 metros" });
            cmbDistancias.Location = new Point(119, 42);
            cmbDistancias.Name = "cmbDistancias";
            cmbDistancias.Size = new Size(109, 28);
            cmbDistancias.TabIndex = 0;
            // 
            // lblDistancias
            // 
            lblDistancias.AutoSize = true;
            lblDistancias.Font = new Font("Segoe UI", 9.75F);
            lblDistancias.Location = new Point(36, 46);
            lblDistancias.Name = "lblDistancias";
            lblDistancias.Size = new Size(83, 23);
            lblDistancias.TabIndex = 1;
            lblDistancias.Text = "Distancia:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9.75F);
            lblCantidad.Location = new Point(36, 156);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 23);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(119, 153);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(59, 27);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // btnObtener
            // 
            btnObtener.BackColor = Color.Orange;
            btnObtener.Font = new Font("Segoe UI", 14.25F);
            btnObtener.Location = new Point(36, 94);
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(247, 40);
            btnObtener.TabIndex = 3;
            btnObtener.Text = "Obtener atletas";
            btnObtener.UseVisualStyleBackColor = false;
            btnObtener.Click += btnObtener_Click;
            // 
            // lstAtletas
            // 
            lstAtletas.FormattingEnabled = true;
            lstAtletas.Location = new Point(36, 228);
            lstAtletas.Name = "lstAtletas";
            lstAtletas.Size = new Size(247, 104);
            lstAtletas.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(36, 202);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 1;
            label1.Text = "Atletas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 360);
            Controls.Add(lstAtletas);
            Controls.Add(btnObtener);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(label1);
            Controls.Add(lblDistancias);
            Controls.Add(cmbDistancias);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDistancias;
        private Label lblDistancias;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnObtener;
        private ListBox lstAtletas;
        private Label label1;
    }
}
