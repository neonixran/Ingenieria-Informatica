namespace pryCertamen2_2025
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLeerMostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCandidato2 = new System.Windows.Forms.TextBox();
            this.txtCandidato1 = new System.Windows.Forms.TextBox();
            this.txtRegistros = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeerMostrar
            // 
            this.btnLeerMostrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLeerMostrar.Location = new System.Drawing.Point(30, 34);
            this.btnLeerMostrar.Name = "btnLeerMostrar";
            this.btnLeerMostrar.Size = new System.Drawing.Size(221, 49);
            this.btnLeerMostrar.TabIndex = 2;
            this.btnLeerMostrar.Text = "Leer datos del archivo y obtener los resultados";
            this.btnLeerMostrar.UseVisualStyleBackColor = false;
            this.btnLeerMostrar.Click += new System.EventHandler(this.btnLeerMostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad de registros:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.txtRegistros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLeerMostrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Candidato 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Candidato 2";
            // 
            // txtCandidato2
            // 
            this.txtCandidato2.Enabled = false;
            this.txtCandidato2.Location = new System.Drawing.Point(176, 264);
            this.txtCandidato2.Name = "txtCandidato2";
            this.txtCandidato2.Size = new System.Drawing.Size(84, 24);
            this.txtCandidato2.TabIndex = 8;
            this.txtCandidato2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCandidato1
            // 
            this.txtCandidato1.Enabled = false;
            this.txtCandidato1.Location = new System.Drawing.Point(31, 264);
            this.txtCandidato1.Name = "txtCandidato1";
            this.txtCandidato1.Size = new System.Drawing.Size(84, 24);
            this.txtCandidato1.TabIndex = 8;
            this.txtCandidato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRegistros
            // 
            this.txtRegistros.Enabled = false;
            this.txtRegistros.Location = new System.Drawing.Point(185, 109);
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.Size = new System.Drawing.Size(84, 24);
            this.txtRegistros.TabIndex = 8;
            this.txtRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLeerMostrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 313);
            this.Controls.Add(this.txtCandidato1);
            this.Controls.Add(this.txtCandidato2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Elecciones 2024";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLeerMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCandidato2;
        private System.Windows.Forms.TextBox txtRegistros;
        private System.Windows.Forms.TextBox txtCandidato1;
    }
}

