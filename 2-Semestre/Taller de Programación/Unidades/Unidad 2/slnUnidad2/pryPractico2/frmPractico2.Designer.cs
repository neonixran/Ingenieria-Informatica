namespace pryMueveLabel
{
    partial class frmPractico2
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
            this.lblMuéveme = new System.Windows.Forms.Label();
            this.btn0_0 = new System.Windows.Forms.Button();
            this.btn200_0 = new System.Windows.Forms.Button();
            this.btn0_200 = new System.Windows.Forms.Button();
            this.btn200_200 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMuéveme
            // 
            this.lblMuéveme.AutoSize = true;
            this.lblMuéveme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuéveme.Location = new System.Drawing.Point(180, 177);
            this.lblMuéveme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuéveme.Name = "lblMuéveme";
            this.lblMuéveme.Size = new System.Drawing.Size(166, 39);
            this.lblMuéveme.TabIndex = 0;
            this.lblMuéveme.Text = "Muéveme";
            // 
            // btn0_0
            // 
            this.btn0_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0_0.Location = new System.Drawing.Point(19, 340);
            this.btn0_0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn0_0.Name = "btn0_0";
            this.btn0_0.Size = new System.Drawing.Size(115, 46);
            this.btn0_0.TabIndex = 1;
            this.btn0_0.Text = "(0,0)";
            this.btn0_0.UseVisualStyleBackColor = true;
            this.btn0_0.Click += new System.EventHandler(this.btn0_0_Click);
            // 
            // btn200_0
            // 
            this.btn200_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200_0.Location = new System.Drawing.Point(385, 340);
            this.btn200_0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn200_0.Name = "btn200_0";
            this.btn200_0.Size = new System.Drawing.Size(115, 46);
            this.btn200_0.TabIndex = 1;
            this.btn200_0.Text = "(200,0)";
            this.btn200_0.UseVisualStyleBackColor = true;
            this.btn200_0.Click += new System.EventHandler(this.btn200_0_Click);
            // 
            // btn0_200
            // 
            this.btn0_200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0_200.Location = new System.Drawing.Point(263, 340);
            this.btn0_200.Margin = new System.Windows.Forms.Padding(4);
            this.btn0_200.Name = "btn0_200";
            this.btn0_200.Size = new System.Drawing.Size(115, 46);
            this.btn0_200.TabIndex = 1;
            this.btn0_200.Text = "(0, 200)";
            this.btn0_200.UseVisualStyleBackColor = true;
            this.btn0_200.Click += new System.EventHandler(this.btn0_200_Click);
            // 
            // btn200_200
            // 
            this.btn200_200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200_200.Location = new System.Drawing.Point(141, 340);
            this.btn200_200.Margin = new System.Windows.Forms.Padding(4);
            this.btn200_200.Name = "btn200_200";
            this.btn200_200.Size = new System.Drawing.Size(115, 46);
            this.btn200_200.TabIndex = 1;
            this.btn200_200.Text = "(200,200)";
            this.btn200_200.UseVisualStyleBackColor = true;
            this.btn200_200.Click += new System.EventHandler(this.btn200_200_Click);
            // 
            // frmPractico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 426);
            this.Controls.Add(this.btn200_200);
            this.Controls.Add(this.btn0_200);
            this.Controls.Add(this.btn200_0);
            this.Controls.Add(this.btn0_0);
            this.Controls.Add(this.lblMuéveme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPractico2";
            this.Text = "Mueve un label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMuéveme;
        private System.Windows.Forms.Button btn0_0;
        private System.Windows.Forms.Button btn200_0;
        private System.Windows.Forms.Button btn0_200;
        private System.Windows.Forms.Button btn200_200;
    }
}

