
namespace Clave2_Grupo
{
    partial class fmrVerInfoClientes
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
            this.btnSalir3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir3
            // 
            this.btnSalir3.Location = new System.Drawing.Point(551, 383);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(75, 23);
            this.btnSalir3.TabIndex = 0;
            this.btnSalir3.Text = "CERRAR";
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // fmrVerInfoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 418);
            this.Controls.Add(this.btnSalir3);
            this.Name = "fmrVerInfoClientes";
            this.Text = "VER INFORMACION DE CLIENTES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir3;
    }
}