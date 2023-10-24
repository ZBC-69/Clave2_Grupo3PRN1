
namespace Clave2_Grupo
{
    partial class fmrVenderJuegos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(364, 383);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(75, 23);
            this.btnSalir2.TabIndex = 2;
            this.btnSalir2.Text = "CERRAR";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // fmrVenderJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 418);
            this.Controls.Add(this.btnSalir2);
            this.Name = "fmrVenderJuegos";
            this.Text = "FOMUARIO VENTA DE JUEGOS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir2;
    }
}