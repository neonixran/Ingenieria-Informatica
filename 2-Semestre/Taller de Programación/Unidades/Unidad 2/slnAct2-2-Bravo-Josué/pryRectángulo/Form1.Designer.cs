namespace pryRectángulo
{
    partial class formRectángulo
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
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(25, 38);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(52, 16);
            this.lblLadoA.TabIndex = 0;
            this.lblLadoA.Text = "Lado a:";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(25, 69);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(52, 16);
            this.lblLadoB.TabIndex = 0;
            this.lblLadoB.Text = "Lado b:";
            // 
            // txtLadoA
            // 
            this.txtLadoA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLadoA.Location = new System.Drawing.Point(83, 35);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(54, 22);
            this.txtLadoA.TabIndex = 1;
            this.txtLadoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLadoA.Click += new System.EventHandler(this.txtLadoA_Click);
            // 
            // txtLadoB
            // 
            this.txtLadoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLadoB.Location = new System.Drawing.Point(83, 66);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(54, 22);
            this.txtLadoB.TabIndex = 2;
            this.txtLadoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLadoB.Click += new System.EventHandler(this.txtLadoB_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(226, 21);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(65, 16);
            this.lblPerimetro.TabIndex = 0;
            this.lblPerimetro.Text = "Perímetro";
            this.lblPerimetro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Location = new System.Drawing.Point(225, 46);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(70, 22);
            this.txtPerimetro.TabIndex = 1;
            this.txtPerimetro.TabStop = false;
            this.txtPerimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(335, 21);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Area";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(319, 46);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(70, 22);
            this.txtArea.TabIndex = 1;
            this.txtArea.TabStop = false;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Location = new System.Drawing.Point(267, 91);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 29);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // formRectángulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 142);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Name = "formRectángulo";
            this.Text = "Rectángulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCalcular;
    }
}

