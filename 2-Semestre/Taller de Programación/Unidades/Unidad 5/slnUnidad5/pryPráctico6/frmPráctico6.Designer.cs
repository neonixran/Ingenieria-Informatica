
namespace pryPráctico6
{
    partial class frmPráctico6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.picDisparo = new System.Windows.Forms.PictureBox();
            this.picCañon = new System.Windows.Forms.PictureBox();
            this.picOvni = new System.Windows.Forms.PictureBox();
            this.movTimer = new System.Windows.Forms.Timer(this.components);
            this.picBala1 = new System.Windows.Forms.PictureBox();
            this.picBala2 = new System.Windows.Forms.PictureBox();
            this.picBala3 = new System.Windows.Forms.PictureBox();
            this.picBala4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisparo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCañon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOvni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puntaje: ";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(91, 16);
            this.lblPuntaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(14, 16);
            this.lblPuntaje.TabIndex = 1;
            this.lblPuntaje.Text = "0";
            // 
            // picDisparo
            // 
            this.picDisparo.BackColor = System.Drawing.Color.Red;
            this.picDisparo.Location = new System.Drawing.Point(184, 286);
            this.picDisparo.Margin = new System.Windows.Forms.Padding(4);
            this.picDisparo.Name = "picDisparo";
            this.picDisparo.Size = new System.Drawing.Size(11, 18);
            this.picDisparo.TabIndex = 4;
            this.picDisparo.TabStop = false;
            this.picDisparo.Visible = false;
            // 
            // picCañon
            // 
            this.picCañon.Image = global::pryPráctico6.Properties.Resources.LaserCannon;
            this.picCañon.Location = new System.Drawing.Point(177, 288);
            this.picCañon.Margin = new System.Windows.Forms.Padding(4);
            this.picCañon.Name = "picCañon";
            this.picCañon.Size = new System.Drawing.Size(18, 15);
            this.picCañon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCañon.TabIndex = 3;
            this.picCañon.TabStop = false;
            // 
            // picOvni
            // 
            this.picOvni.Image = global::pryPráctico6.Properties.Resources.ufo;
            this.picOvni.Location = new System.Drawing.Point(27, 43);
            this.picOvni.Margin = new System.Windows.Forms.Padding(4);
            this.picOvni.Name = "picOvni";
            this.picOvni.Size = new System.Drawing.Size(39, 27);
            this.picOvni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOvni.TabIndex = 2;
            this.picOvni.TabStop = false;
            // 
            // movTimer
            // 
            this.movTimer.Enabled = true;
            this.movTimer.Tick += new System.EventHandler(this.movTimer_Tick);
            // 
            // picBala1
            // 
            this.picBala1.BackColor = System.Drawing.Color.Red;
            this.picBala1.Location = new System.Drawing.Point(27, 290);
            this.picBala1.Margin = new System.Windows.Forms.Padding(4);
            this.picBala1.Name = "picBala1";
            this.picBala1.Size = new System.Drawing.Size(11, 18);
            this.picBala1.TabIndex = 4;
            this.picBala1.TabStop = false;
            // 
            // picBala2
            // 
            this.picBala2.BackColor = System.Drawing.Color.Red;
            this.picBala2.Location = new System.Drawing.Point(42, 290);
            this.picBala2.Margin = new System.Windows.Forms.Padding(4);
            this.picBala2.Name = "picBala2";
            this.picBala2.Size = new System.Drawing.Size(11, 18);
            this.picBala2.TabIndex = 4;
            this.picBala2.TabStop = false;
            // 
            // picBala3
            // 
            this.picBala3.BackColor = System.Drawing.Color.Red;
            this.picBala3.Location = new System.Drawing.Point(57, 290);
            this.picBala3.Margin = new System.Windows.Forms.Padding(4);
            this.picBala3.Name = "picBala3";
            this.picBala3.Size = new System.Drawing.Size(11, 18);
            this.picBala3.TabIndex = 4;
            this.picBala3.TabStop = false;
            // 
            // picBala4
            // 
            this.picBala4.BackColor = System.Drawing.Color.Red;
            this.picBala4.Location = new System.Drawing.Point(73, 290);
            this.picBala4.Margin = new System.Windows.Forms.Padding(4);
            this.picBala4.Name = "picBala4";
            this.picBala4.Size = new System.Drawing.Size(11, 18);
            this.picBala4.TabIndex = 4;
            this.picBala4.TabStop = false;
            // 
            // frmPráctico6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.picBala4);
            this.Controls.Add(this.picBala3);
            this.Controls.Add(this.picBala2);
            this.Controls.Add(this.picBala1);
            this.Controls.Add(this.picDisparo);
            this.Controls.Add(this.picCañon);
            this.Controls.Add(this.picOvni);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPráctico6";
            this.Tag = "Bala";
            this.Text = "                            OVNI";
            this.Load += new System.EventHandler(this.frmPráctico6_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPráctico6_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picDisparo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCañon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOvni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.PictureBox picOvni;
        private System.Windows.Forms.PictureBox picCañon;
        private System.Windows.Forms.PictureBox picDisparo;
        private System.Windows.Forms.Timer movTimer;
        private System.Windows.Forms.PictureBox picBala1;
        private System.Windows.Forms.PictureBox picBala2;
        private System.Windows.Forms.PictureBox picBala3;
        private System.Windows.Forms.PictureBox picBala4;
    }
}

