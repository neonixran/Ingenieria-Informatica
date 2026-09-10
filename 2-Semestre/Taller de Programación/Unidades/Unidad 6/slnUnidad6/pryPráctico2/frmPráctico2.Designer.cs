
namespace pryPráctico2
{
    partial class frmPráctico2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gboxNombre = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNúmero = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.gboxDireccion = new System.Windows.Forms.GroupBox();
            this.gboxNombre.SuspendLayout();
            this.gboxDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Calle:";
            // 
            // gboxNombre
            // 
            this.gboxNombre.BackColor = System.Drawing.Color.Ivory;
            this.gboxNombre.Controls.Add(this.txtNombre);
            this.gboxNombre.Controls.Add(this.txtApellido);
            this.gboxNombre.Controls.Add(this.label1);
            this.gboxNombre.Controls.Add(this.label2);
            this.gboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gboxNombre.Location = new System.Drawing.Point(18, 24);
            this.gboxNombre.Name = "gboxNombre";
            this.gboxNombre.Size = new System.Drawing.Size(289, 120);
            this.gboxNombre.TabIndex = 1;
            this.gboxNombre.TabStop = false;
            this.gboxNombre.Text = "Nombre del Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(88, 72);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(165, 26);
            this.txtApellido.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(111, 37);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(142, 26);
            this.txtCalle.TabIndex = 3;
            // 
            // txtNúmero
            // 
            this.txtNúmero.Location = new System.Drawing.Point(111, 75);
            this.txtNúmero.Name = "txtNúmero";
            this.txtNúmero.Size = new System.Drawing.Size(64, 26);
            this.txtNúmero.TabIndex = 4;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(18, 298);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(289, 34);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // gboxDireccion
            // 
            this.gboxDireccion.BackColor = System.Drawing.Color.AliceBlue;
            this.gboxDireccion.Controls.Add(this.txtCalle);
            this.gboxDireccion.Controls.Add(this.txtNúmero);
            this.gboxDireccion.Controls.Add(this.label3);
            this.gboxDireccion.Controls.Add(this.label4);
            this.gboxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDireccion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gboxDireccion.Location = new System.Drawing.Point(18, 162);
            this.gboxDireccion.Name = "gboxDireccion";
            this.gboxDireccion.Size = new System.Drawing.Size(289, 120);
            this.gboxDireccion.TabIndex = 2;
            this.gboxDireccion.TabStop = false;
            this.gboxDireccion.Text = "Dirección del Cliente";
            // 
            // frmPráctico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 353);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.gboxDireccion);
            this.Controls.Add(this.gboxNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPráctico2";
            this.Text = "Ingreso de Datos";
            this.gboxNombre.ResumeLayout(false);
            this.gboxNombre.PerformLayout();
            this.gboxDireccion.ResumeLayout(false);
            this.gboxDireccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gboxNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNúmero;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.GroupBox gboxDireccion;
    }
}

