namespace pryLaboratorio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.btnAnalizarMezcla = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHielos = new System.Windows.Forms.TextBox();
            this.txtVapores = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados Fahrenheit:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAnalizarMezcla);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperatura y estado de una mezcla";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEstado.Location = new System.Drawing.Point(147, 145);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(91, 26);
            this.txtEstado.TabIndex = 1;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ESTADO:";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtC.Location = new System.Drawing.Point(176, 107);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(62, 26);
            this.txtC.TabIndex = 1;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "GRADOS CELSIUS:";
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtF.Location = new System.Drawing.Point(159, 26);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(62, 26);
            this.txtF.TabIndex = 1;
            this.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAnalizarMezcla
            // 
            this.btnAnalizarMezcla.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAnalizarMezcla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizarMezcla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnalizarMezcla.Location = new System.Drawing.Point(28, 57);
            this.btnAnalizarMezcla.Name = "btnAnalizarMezcla";
            this.btnAnalizarMezcla.Size = new System.Drawing.Size(236, 35);
            this.btnAnalizarMezcla.TabIndex = 2;
            this.btnAnalizarMezcla.Text = "Calcular estado de una mezcla";
            this.btnAnalizarMezcla.UseVisualStyleBackColor = false;
            this.btnAnalizarMezcla.Click += new System.EventHandler(this.btnAnalizarMezcla_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtHielos);
            this.groupBox2.Controls.Add(this.txtVapores);
            this.groupBox2.Controls.Add(this.btnProcesar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 222);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesar datos del arreglo";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 54);
            this.label4.TabIndex = 4;
            this.label4.Text = "Promedio de mezclas que tienen el estado de hielo:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantidad de mezclas que tienen  el estado de vapor:";
            // 
            // txtHielos
            // 
            this.txtHielos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHielos.ForeColor = System.Drawing.Color.Blue;
            this.txtHielos.Location = new System.Drawing.Point(216, 164);
            this.txtHielos.Name = "txtHielos";
            this.txtHielos.ReadOnly = true;
            this.txtHielos.Size = new System.Drawing.Size(62, 34);
            this.txtHielos.TabIndex = 1;
            this.txtHielos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVapores
            // 
            this.txtVapores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVapores.ForeColor = System.Drawing.Color.Blue;
            this.txtVapores.Location = new System.Drawing.Point(216, 110);
            this.txtVapores.Name = "txtVapores";
            this.txtVapores.ReadOnly = true;
            this.txtVapores.Size = new System.Drawing.Size(62, 34);
            this.txtVapores.TabIndex = 1;
            this.txtVapores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.Green;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.Yellow;
            this.btnProcesar.Location = new System.Drawing.Point(60, 32);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(194, 53);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "PROCESAR LAS MEZCLAS DEL ARREGLO";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CorpoSano";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Button btnAnalizarMezcla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVapores;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHielos;
    }
}

