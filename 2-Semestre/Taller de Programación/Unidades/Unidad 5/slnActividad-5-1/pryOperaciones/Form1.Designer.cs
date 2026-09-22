namespace pryOperaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbArreglo3 = new System.Windows.Forms.RadioButton();
            this.rdbArreglo2 = new System.Windows.Forms.RadioButton();
            this.rdbArreglo1 = new System.Windows.Forms.RadioButton();
            this.btnAncho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rdbArreglo3);
            this.groupBox1.Controls.Add(this.rdbArreglo2);
            this.groupBox1.Controls.Add(this.rdbArreglo1);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(200, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el Arreglo";
            // 
            // rdbArreglo3
            // 
            this.rdbArreglo3.AutoSize = true;
            this.rdbArreglo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbArreglo3.Location = new System.Drawing.Point(44, 124);
            this.rdbArreglo3.Margin = new System.Windows.Forms.Padding(4);
            this.rdbArreglo3.Name = "rdbArreglo3";
            this.rdbArreglo3.Size = new System.Drawing.Size(107, 24);
            this.rdbArreglo3.TabIndex = 3;
            this.rdbArreglo3.Text = "Arreglo 3";
            this.rdbArreglo3.UseVisualStyleBackColor = true;
            // 
            // rdbArreglo2
            // 
            this.rdbArreglo2.AutoSize = true;
            this.rdbArreglo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbArreglo2.Location = new System.Drawing.Point(44, 82);
            this.rdbArreglo2.Margin = new System.Windows.Forms.Padding(4);
            this.rdbArreglo2.Name = "rdbArreglo2";
            this.rdbArreglo2.Size = new System.Drawing.Size(107, 24);
            this.rdbArreglo2.TabIndex = 2;
            this.rdbArreglo2.Text = "Arreglo 2";
            this.rdbArreglo2.UseVisualStyleBackColor = true;
            // 
            // rdbArreglo1
            // 
            this.rdbArreglo1.AutoSize = true;
            this.rdbArreglo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbArreglo1.Location = new System.Drawing.Point(44, 37);
            this.rdbArreglo1.Margin = new System.Windows.Forms.Padding(4);
            this.rdbArreglo1.Name = "rdbArreglo1";
            this.rdbArreglo1.Size = new System.Drawing.Size(107, 24);
            this.rdbArreglo1.TabIndex = 1;
            this.rdbArreglo1.Text = "Arreglo 1";
            this.rdbArreglo1.UseVisualStyleBackColor = true;
            // 
            // btnAncho
            // 
            this.btnAncho.BackColor = System.Drawing.Color.Yellow;
            this.btnAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAncho.ForeColor = System.Drawing.Color.Blue;
            this.btnAncho.Location = new System.Drawing.Point(21, 219);
            this.btnAncho.Margin = new System.Windows.Forms.Padding(4);
            this.btnAncho.Name = "btnAncho";
            this.btnAncho.Size = new System.Drawing.Size(200, 42);
            this.btnAncho.TabIndex = 1;
            this.btnAncho.Text = "OBTENER ANCHO";
            this.btnAncho.UseVisualStyleBackColor = false;
            this.btnAncho.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ancho de Valor:";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(148, 285);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(4);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(53, 26);
            this.txtAncho.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 339);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAncho);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Cálculo de Mediana";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbArreglo3;
        private System.Windows.Forms.RadioButton rdbArreglo2;
        private System.Windows.Forms.RadioButton rdbArreglo1;
        private System.Windows.Forms.Button btnAncho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAncho;
    }
}

