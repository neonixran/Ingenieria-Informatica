namespace pryPráctico6
{
    partial class FrmPráctico6
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
            this.btnLeerDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.btnPromedios = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAsignatura = new System.Windows.Forms.Button();
            this.btnSinAsistencia = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrarListBox = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeerDatos
            // 
            this.btnLeerDatos.Location = new System.Drawing.Point(314, 12);
            this.btnLeerDatos.Name = "btnLeerDatos";
            this.btnLeerDatos.Size = new System.Drawing.Size(126, 27);
            this.btnLeerDatos.TabIndex = 0;
            this.btnLeerDatos.Text = "Leer Datos";
            this.btnLeerDatos.UseVisualStyleBackColor = true;
            this.btnLeerDatos.Click += new System.EventHandler(this.btnLeerDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de archivo:";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(155, 15);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(144, 24);
            this.txtNombreArchivo.TabIndex = 2;
            // 
            // btnPromedios
            // 
            this.btnPromedios.Location = new System.Drawing.Point(65, 34);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Size = new System.Drawing.Size(198, 26);
            this.btnPromedios.TabIndex = 3;
            this.btnPromedios.Text = "Promedio de Estudiantes";
            this.btnPromedios.UseVisualStyleBackColor = true;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromedios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.btnAsignatura);
            this.groupBox1.Controls.Add(this.btnSinAsistencia);
            this.groupBox1.Controls.Add(this.btnPromedios);
            this.groupBox1.Location = new System.Drawing.Point(69, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Análisis";
            // 
            // btnAsignatura
            // 
            this.btnAsignatura.Location = new System.Drawing.Point(45, 100);
            this.btnAsignatura.Name = "btnAsignatura";
            this.btnAsignatura.Size = new System.Drawing.Size(242, 26);
            this.btnAsignatura.TabIndex = 6;
            this.btnAsignatura.Text = "Asignatura y asistentes";
            this.btnAsignatura.UseVisualStyleBackColor = true;
            this.btnAsignatura.Click += new System.EventHandler(this.btnAsignaturaMenos_Click);
            // 
            // btnSinAsistencia
            // 
            this.btnSinAsistencia.Location = new System.Drawing.Point(65, 67);
            this.btnSinAsistencia.Name = "btnSinAsistencia";
            this.btnSinAsistencia.Size = new System.Drawing.Size(198, 27);
            this.btnSinAsistencia.TabIndex = 5;
            this.btnSinAsistencia.Text = "Estudiantes sin asistencia";
            this.btnSinAsistencia.UseVisualStyleBackColor = true;
            this.btnSinAsistencia.Click += new System.EventHandler(this.btnSinAsistencia_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 18;
            this.lstResultados.Location = new System.Drawing.Point(93, 227);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(277, 94);
            this.lstResultados.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultados:";
            // 
            // btnBorrarListBox
            // 
            this.btnBorrarListBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBorrarListBox.Location = new System.Drawing.Point(128, 327);
            this.btnBorrarListBox.Name = "btnBorrarListBox";
            this.btnBorrarListBox.Size = new System.Drawing.Size(209, 33);
            this.btnBorrarListBox.TabIndex = 7;
            this.btnBorrarListBox.Text = "Borrar Resultados";
            this.btnBorrarListBox.UseVisualStyleBackColor = false;
            this.btnBorrarListBox.Click += new System.EventHandler(this.btnBorrarListBox_Click);
            // 
            // FrmPráctico6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 372);
            this.Controls.Add(this.btnBorrarListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeerDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPráctico6";
            this.Text = "Asistencias";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeerDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Button btnPromedios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSinAsistencia;
        private System.Windows.Forms.Button btnAsignatura;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrarListBox;
    }
}

