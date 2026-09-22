namespace pryColor
{
    partial class Form1
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
            this.hscRojo = new System.Windows.Forms.HScrollBar();
            this.txbRojo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hscVerde = new System.Windows.Forms.HScrollBar();
            this.txbVerde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hscAzul = new System.Windows.Forms.HScrollBar();
            this.txbAzul = new System.Windows.Forms.TextBox();
            this.picMuestraColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMuestraColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rojo";
            // 
            // hscRojo
            // 
            this.hscRojo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hscRojo.Location = new System.Drawing.Point(86, 53);
            this.hscRojo.Maximum = 264;
            this.hscRojo.Name = "hscRojo";
            this.hscRojo.Size = new System.Drawing.Size(190, 21);
            this.hscRojo.TabIndex = 1;
            this.hscRojo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscRojo_Scroll);
            // 
            // txbRojo
            // 
            this.txbRojo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRojo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRojo.Location = new System.Drawing.Point(298, 47);
            this.txbRojo.Name = "txbRojo";
            this.txbRojo.ReadOnly = true;
            this.txbRojo.Size = new System.Drawing.Size(50, 22);
            this.txbRojo.TabIndex = 2;
            this.txbRojo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Verde";
            // 
            // hscVerde
            // 
            this.hscVerde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hscVerde.Location = new System.Drawing.Point(86, 99);
            this.hscVerde.Maximum = 264;
            this.hscVerde.Name = "hscVerde";
            this.hscVerde.Size = new System.Drawing.Size(190, 21);
            this.hscVerde.TabIndex = 1;
            this.hscVerde.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscVerde_Scroll);
            // 
            // txbVerde
            // 
            this.txbVerde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbVerde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbVerde.Location = new System.Drawing.Point(298, 99);
            this.txbVerde.Name = "txbVerde";
            this.txbVerde.ReadOnly = true;
            this.txbVerde.Size = new System.Drawing.Size(50, 22);
            this.txbVerde.TabIndex = 2;
            this.txbVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Azul";
            // 
            // hscAzul
            // 
            this.hscAzul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hscAzul.Location = new System.Drawing.Point(86, 145);
            this.hscAzul.Maximum = 264;
            this.hscAzul.Name = "hscAzul";
            this.hscAzul.Size = new System.Drawing.Size(190, 21);
            this.hscAzul.TabIndex = 1;
            this.hscAzul.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscAzul_Scroll);
            // 
            // txbAzul
            // 
            this.txbAzul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAzul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAzul.Location = new System.Drawing.Point(298, 145);
            this.txbAzul.Name = "txbAzul";
            this.txbAzul.ReadOnly = true;
            this.txbAzul.Size = new System.Drawing.Size(50, 22);
            this.txbAzul.TabIndex = 2;
            this.txbAzul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picMuestraColor
            // 
            this.picMuestraColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMuestraColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMuestraColor.Location = new System.Drawing.Point(404, 50);
            this.picMuestraColor.Name = "picMuestraColor";
            this.picMuestraColor.Size = new System.Drawing.Size(125, 125);
            this.picMuestraColor.TabIndex = 3;
            this.picMuestraColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 220);
            this.Controls.Add(this.picMuestraColor);
            this.Controls.Add(this.txbAzul);
            this.Controls.Add(this.txbVerde);
            this.Controls.Add(this.txbRojo);
            this.Controls.Add(this.hscAzul);
            this.Controls.Add(this.hscVerde);
            this.Controls.Add(this.hscRojo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Muestra de Color";
            ((System.ComponentModel.ISupportInitialize)(this.picMuestraColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hscRojo;
        private System.Windows.Forms.TextBox txbRojo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hscVerde;
        private System.Windows.Forms.TextBox txbVerde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hscAzul;
        private System.Windows.Forms.TextBox txbAzul;
        private System.Windows.Forms.PictureBox picMuestraColor;
    }
}

