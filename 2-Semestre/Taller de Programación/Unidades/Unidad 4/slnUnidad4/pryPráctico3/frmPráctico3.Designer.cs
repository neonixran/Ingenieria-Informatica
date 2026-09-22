namespace pryPráctico4
{
    partial class frmPráctico3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstValores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(28, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(151, 27);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Valores";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstValores
            // 
            this.lstValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstValores.FormattingEnabled = true;
            this.lstValores.ItemHeight = 18;
            this.lstValores.Location = new System.Drawing.Point(64, 45);
            this.lstValores.Name = "lstValores";
            this.lstValores.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstValores.Size = new System.Drawing.Size(81, 166);
            this.lstValores.TabIndex = 1;
            this.lstValores.TabStop = false;
            // 
            // frmPráctico4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 223);
            this.Controls.Add(this.lstValores);
            this.Controls.Add(this.btnMostrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPráctico4";
            this.Text = "Valores de un arreglo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstValores;
    }
}

