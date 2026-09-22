namespace pryPráctico1
{
    partial class frmPráctico1
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
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnPerímetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.picCirculo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCirculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese radio (r):";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(345, 44);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(59, 29);
            this.txtRadio.TabIndex = 1;
            this.txtRadio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPerímetro
            // 
            this.btnPerímetro.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPerímetro.Location = new System.Drawing.Point(217, 107);
            this.btnPerímetro.Name = "btnPerímetro";
            this.btnPerímetro.Size = new System.Drawing.Size(86, 48);
            this.btnPerímetro.TabIndex = 2;
            this.btnPerímetro.Text = "Calcular Perímetro";
            this.btnPerímetro.UseVisualStyleBackColor = false;
            this.btnPerímetro.Click += new System.EventHandler(this.btnPerímetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.GreenYellow;
            this.btnArea.Location = new System.Drawing.Point(217, 195);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(86, 48);
            this.btnArea.TabIndex = 3;
            this.btnArea.Text = "Calcular Área";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // picCirculo
            // 
            this.picCirculo.Image = global::pryPráctico1.Properties.Resources.img0;
            this.picCirculo.Location = new System.Drawing.Point(21, 42);
            this.picCirculo.Name = "picCirculo";
            this.picCirculo.Size = new System.Drawing.Size(180, 233);
            this.picCirculo.TabIndex = 0;
            this.picCirculo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perímetro (P):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Área (A):";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(340, 131);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(74, 29);
            this.txtPerimetro.TabIndex = 2;
            this.txtPerimetro.TabStop = false;
            this.txtPerimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(340, 219);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(78, 29);
            this.txtArea.TabIndex = 2;
            this.txtArea.TabStop = false;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmPráctico1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 313);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerímetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCirculo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPráctico1";
            this.Text = "Perímetro y Área de un Círculo";
            ((System.ComponentModel.ISupportInitialize)(this.picCirculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCirculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnPerímetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
    }
}

