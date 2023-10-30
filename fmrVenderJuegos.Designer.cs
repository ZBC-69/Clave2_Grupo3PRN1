
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radJuegElectronic = new System.Windows.Forms.RadioButton();
            this.radJuegMecanic = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarCompraJuego = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.Blue;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir2.Location = new System.Drawing.Point(513, 373);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(99, 33);
            this.btnSalir2.TabIndex = 2;
            this.btnSalir2.Text = "CERRAR";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elija tipo de juego:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarCompraJuego);
            this.groupBox1.Controls.Add(this.radJuegElectronic);
            this.groupBox1.Controls.Add(this.radJuegMecanic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 402);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el tipo de juego que desea el cliente";
            // 
            // radJuegElectronic
            // 
            this.radJuegElectronic.AutoSize = true;
            this.radJuegElectronic.Location = new System.Drawing.Point(71, 110);
            this.radJuegElectronic.Name = "radJuegElectronic";
            this.radJuegElectronic.Size = new System.Drawing.Size(140, 19);
            this.radJuegElectronic.TabIndex = 5;
            this.radJuegElectronic.TabStop = true;
            this.radJuegElectronic.Text = "Juego Electrónico";
            this.radJuegElectronic.UseVisualStyleBackColor = true;
            // 
            // radJuegMecanic
            // 
            this.radJuegMecanic.AutoSize = true;
            this.radJuegMecanic.Location = new System.Drawing.Point(71, 74);
            this.radJuegMecanic.Name = "radJuegMecanic";
            this.radJuegMecanic.Size = new System.Drawing.Size(130, 19);
            this.radJuegMecanic.TabIndex = 4;
            this.radJuegMecanic.TabStop = true;
            this.radJuegMecanic.Text = "Juego mecánico";
            this.radJuegMecanic.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Juego mecanico:          $3.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Juego Electrónico:        $2.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(446, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(412, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 119);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "       PRECIOS PARA JUEGOS:";
            // 
            // btnRegistrarCompraJuego
            // 
            this.btnRegistrarCompraJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompraJuego.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarCompraJuego.Location = new System.Drawing.Point(85, 364);
            this.btnRegistrarCompraJuego.Name = "btnRegistrarCompraJuego";
            this.btnRegistrarCompraJuego.Size = new System.Drawing.Size(159, 27);
            this.btnRegistrarCompraJuego.TabIndex = 9;
            this.btnRegistrarCompraJuego.Text = "REGISTRAR COMPRA";
            this.btnRegistrarCompraJuego.UseVisualStyleBackColor = true;
            this.btnRegistrarCompraJuego.Click += new System.EventHandler(this.btnRegistrarCompraJuego_Click);
            // 
            // fmrVenderJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(638, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir2);
            this.Name = "fmrVenderJuegos";
            this.Text = "FOMUARIO VENTA DE JUEGOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radJuegElectronic;
        private System.Windows.Forms.RadioButton radJuegMecanic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistrarCompraJuego;
    }
}