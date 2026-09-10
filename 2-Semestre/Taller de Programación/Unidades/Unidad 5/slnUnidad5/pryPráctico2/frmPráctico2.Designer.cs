
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPráctico2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnPerímetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerímetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lado b:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(350, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(74, 29);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(350, 64);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(74, 29);
            this.txtB.TabIndex = 2;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPerímetro
            // 
            this.btnPerímetro.BackColor = System.Drawing.Color.Bisque;
            this.btnPerímetro.Location = new System.Drawing.Point(270, 128);
            this.btnPerímetro.Name = "btnPerímetro";
            this.btnPerímetro.Size = new System.Drawing.Size(83, 45);
            this.btnPerímetro.TabIndex = 3;
            this.btnPerímetro.Text = "Calcular Perímetro";
            this.btnPerímetro.UseVisualStyleBackColor = false;
            this.btnPerímetro.Click += new System.EventHandler(this.btnPerímetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.LightCyan;
            this.btnArea.Location = new System.Drawing.Point(359, 128);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(83, 45);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Calcular Área";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Perímetro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Área:";
            // 
            // txtPerímetro
            // 
            this.txtPerímetro.BackColor = System.Drawing.Color.Wheat;
            this.txtPerímetro.Location = new System.Drawing.Point(350, 197);
            this.txtPerímetro.Name = "txtPerímetro";
            this.txtPerímetro.ReadOnly = true;
            this.txtPerímetro.Size = new System.Drawing.Size(92, 29);
            this.txtPerímetro.TabIndex = 1;
            this.txtPerímetro.TabStop = false;
            this.txtPerímetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.LightCyan;
            this.txtArea.Location = new System.Drawing.Point(350, 229);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(92, 29);
            this.txtArea.TabIndex = 1;
            this.txtArea.TabStop = false;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmPráctico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerímetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerímetro);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPráctico2";
            this.Text = "Rectángulo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnPerímetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerímetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

