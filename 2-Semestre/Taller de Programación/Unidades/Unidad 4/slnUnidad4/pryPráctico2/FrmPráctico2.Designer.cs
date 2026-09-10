namespace pryString2_Metodos
{
    partial class FrmPráctico2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnVerifica1 = new System.Windows.Forms.Button();
            this.btnVerifica2 = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un refrán:";
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.Moccasin;
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.ForeColor = System.Drawing.Color.Maroon;
            this.txtEntrada.Location = new System.Drawing.Point(18, 40);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(329, 29);
            this.txtEntrada.TabIndex = 1;
            // 
            // btnVerifica1
            // 
            this.btnVerifica1.BackColor = System.Drawing.Color.Khaki;
            this.btnVerifica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica1.Location = new System.Drawing.Point(23, 108);
            this.btnVerifica1.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerifica1.Name = "btnVerifica1";
            this.btnVerifica1.Size = new System.Drawing.Size(172, 83);
            this.btnVerifica1.TabIndex = 2;
            this.btnVerifica1.Text = "Verificar si está la  proposición \"de\"";
            this.btnVerifica1.UseVisualStyleBackColor = false;
            this.btnVerifica1.Click += new System.EventHandler(this.btnVerifica1_Click);
            // 
            // btnVerifica2
            // 
            this.btnVerifica2.BackColor = System.Drawing.Color.Khaki;
            this.btnVerifica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica2.Location = new System.Drawing.Point(203, 108);
            this.btnVerifica2.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerifica2.Name = "btnVerifica2";
            this.btnVerifica2.Size = new System.Drawing.Size(152, 83);
            this.btnVerifica2.TabIndex = 2;
            this.btnVerifica2.Text = "Indicar la posición de la letra \"p\"";
            this.btnVerifica2.UseVisualStyleBackColor = false;
            this.btnVerifica2.Click += new System.EventHandler(this.btnVerifica2_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(23, 209);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(144, 82);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar cantidad de caracteres que tiene el refrán";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de Caracteres";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(260, 262);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(27, 29);
            this.lblSalida.TabIndex = 5;
            this.lblSalida.Text = "0";
            // 
            // FrmPráctico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 323);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnVerifica2);
            this.Controls.Add(this.btnVerifica1);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPráctico2";
            this.Text = "Métodos de Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnVerifica1;
        private System.Windows.Forms.Button btnVerifica2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSalida;
    }
}

