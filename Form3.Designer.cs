
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantCompras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPuntosAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCreditDiponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantTarjets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVigenciaTarjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir3
            // 
            this.btnSalir3.Location = new System.Drawing.Point(719, 383);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(75, 23);
            this.btnSalir3.TabIndex = 0;
            this.btnSalir3.Text = "CERRAR";
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDui,
            this.cNombre,
            this.cCantCompras,
            this.cPuntosAcum,
            this.cTipoTarjeta,
            this.cCreditDiponible,
            this.cFVencimiento,
            this.cFApertura,
            this.cCantTarjets,
            this.cVigenciaTarjet});
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(788, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(113, 359);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(159, 23);
            this.btnModificarCliente.TabIndex = 2;
            this.btnModificarCliente.Text = "MODIFICAR CLIENTE";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(325, 359);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(135, 23);
            this.btnEliminarCliente.TabIndex = 3;
            this.btnEliminarCliente.Text = "ELIIMINAR CLIENTE";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(235, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HISTORIAL Y LISTA DE CLIENTES DE LA EMPRESA DE JUEGOS GAMESILVER";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(520, 334);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(520, 360);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(575, 383);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(113, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar por fechas";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // cDui
            // 
            this.cDui.HeaderText = "DUI";
            this.cDui.Name = "cDui";
            this.cDui.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cCantCompras
            // 
            this.cCantCompras.HeaderText = "Cant. Compras";
            this.cCantCompras.Name = "cCantCompras";
            this.cCantCompras.ReadOnly = true;
            this.cCantCompras.Width = 50;
            // 
            // cPuntosAcum
            // 
            this.cPuntosAcum.HeaderText = "Puntos Acum.";
            this.cPuntosAcum.Name = "cPuntosAcum";
            this.cPuntosAcum.ReadOnly = true;
            this.cPuntosAcum.Width = 50;
            // 
            // cTipoTarjeta
            // 
            this.cTipoTarjeta.HeaderText = "Tarjeta";
            this.cTipoTarjeta.Name = "cTipoTarjeta";
            this.cTipoTarjeta.ReadOnly = true;
            // 
            // cCreditDiponible
            // 
            this.cCreditDiponible.FillWeight = 50F;
            this.cCreditDiponible.HeaderText = "Cred. Disponible";
            this.cCreditDiponible.Name = "cCreditDiponible";
            this.cCreditDiponible.ReadOnly = true;
            this.cCreditDiponible.Width = 50;
            // 
            // cFVencimiento
            // 
            this.cFVencimiento.HeaderText = "f. Vencimiento";
            this.cFVencimiento.Name = "cFVencimiento";
            this.cFVencimiento.ReadOnly = true;
            // 
            // cFApertura
            // 
            this.cFApertura.HeaderText = "f. Apertura";
            this.cFApertura.Name = "cFApertura";
            this.cFApertura.ReadOnly = true;
            // 
            // cCantTarjets
            // 
            this.cCantTarjets.HeaderText = "N° Trjts. Compradas";
            this.cCantTarjets.Name = "cCantTarjets";
            this.cCantTarjets.ReadOnly = true;
            this.cCantTarjets.Width = 60;
            // 
            // cVigenciaTarjet
            // 
            this.cVigenciaTarjet.HeaderText = "Estado Tarjeta";
            this.cVigenciaTarjet.Name = "cVigenciaTarjet";
            this.cVigenciaTarjet.ReadOnly = true;
            // 
            // fmrVerInfoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(812, 418);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir3);
            this.Name = "fmrVerInfoClientes";
            this.Text = "VER INFORMACION DE CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDui;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPuntosAcum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCreditDiponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantTarjets;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVigenciaTarjet;
    }
}