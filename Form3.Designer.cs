﻿
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
            this.dgvHistorialRegistros = new System.Windows.Forms.DataGridView();
            this.cDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCreditDiponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVigenciaTarjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialRegistros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir3
            // 
            this.btnSalir3.Location = new System.Drawing.Point(588, 455);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(75, 23);
            this.btnSalir3.TabIndex = 0;
            this.btnSalir3.Text = "CERRAR";
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // dgvHistorialRegistros
            // 
            this.dgvHistorialRegistros.AllowUserToAddRows = false;
            this.dgvHistorialRegistros.AllowUserToDeleteRows = false;
            this.dgvHistorialRegistros.AllowUserToResizeColumns = false;
            this.dgvHistorialRegistros.AllowUserToResizeRows = false;
            this.dgvHistorialRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDui,
            this.cNombre,
            this.CodTarjeta,
            this.cTipoTarjeta,
            this.cCreditDiponible,
            this.cFVencimiento,
            this.cFApertura,
            this.cVigenciaTarjet});
            this.dgvHistorialRegistros.Location = new System.Drawing.Point(250, 50);
            this.dgvHistorialRegistros.Name = "dgvHistorialRegistros";
            this.dgvHistorialRegistros.ReadOnly = true;
            this.dgvHistorialRegistros.RowHeadersWidth = 51;
            this.dgvHistorialRegistros.Size = new System.Drawing.Size(815, 250);
            this.dgvHistorialRegistros.TabIndex = 1;
            // 
            // cDui
            // 
            this.cDui.HeaderText = "DUI";
            this.cDui.MinimumWidth = 6;
            this.cDui.Name = "cDui";
            this.cDui.ReadOnly = true;
            this.cDui.Width = 125;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 6;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 125;
            // 
            // CodTarjeta
            // 
            this.CodTarjeta.HeaderText = "Codigo de la Tarjeta";
            this.CodTarjeta.MinimumWidth = 6;
            this.CodTarjeta.Name = "CodTarjeta";
            this.CodTarjeta.ReadOnly = true;
            this.CodTarjeta.Width = 115;
            // 
            // cTipoTarjeta
            // 
            this.cTipoTarjeta.HeaderText = "Tipo de Tarjeta";
            this.cTipoTarjeta.MinimumWidth = 6;
            this.cTipoTarjeta.Name = "cTipoTarjeta";
            this.cTipoTarjeta.ReadOnly = true;
            this.cTipoTarjeta.Width = 125;
            // 
            // cCreditDiponible
            // 
            this.cCreditDiponible.FillWeight = 50F;
            this.cCreditDiponible.HeaderText = "Cred. Disponible";
            this.cCreditDiponible.MinimumWidth = 6;
            this.cCreditDiponible.Name = "cCreditDiponible";
            this.cCreditDiponible.ReadOnly = true;
            this.cCreditDiponible.Width = 50;
            // 
            // cFVencimiento
            // 
            this.cFVencimiento.HeaderText = "f. Vencimiento";
            this.cFVencimiento.MinimumWidth = 6;
            this.cFVencimiento.Name = "cFVencimiento";
            this.cFVencimiento.ReadOnly = true;
            this.cFVencimiento.Width = 125;
            // 
            // cFApertura
            // 
            this.cFApertura.HeaderText = "f. Apertura";
            this.cFApertura.MinimumWidth = 6;
            this.cFApertura.Name = "cFApertura";
            this.cFApertura.ReadOnly = true;
            this.cFApertura.Width = 125;
            // 
            // cVigenciaTarjet
            // 
            this.cVigenciaTarjet.HeaderText = "Vigente";
            this.cVigenciaTarjet.MinimumWidth = 6;
            this.cVigenciaTarjet.Name = "cVigenciaTarjet";
            this.cVigenciaTarjet.ReadOnly = true;
            this.cVigenciaTarjet.Width = 125;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(34, 206);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(159, 23);
            this.btnModificarCliente.TabIndex = 2;
            this.btnModificarCliente.Text = "MODIFICAR CLIENTE";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(46, 236);
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
            this.label1.Location = new System.Drawing.Point(358, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HISTORIAL Y LISTA DE CLIENTES DE LA EMPRESA DE JUEGOS GAMESIVAR";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(464, 393);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(464, 417);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(464, 455);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(113, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar por fechas";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEliminarCliente);
            this.groupBox1.Controls.Add(this.btnModificarCliente);
            this.groupBox1.Location = new System.Drawing.Point(2, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(232, 291);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Clientes GameSivar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 99);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(105, 65);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DUI";
            // 
            // fmrVerInfoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1077, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorialRegistros);
            this.Controls.Add(this.btnSalir3);
            this.Name = "fmrVerInfoClientes";
            this.Text = "VER INFORMACION DE CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialRegistros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir3;
        private System.Windows.Forms.DataGridView dgvHistorialRegistros;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDui;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCreditDiponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVigenciaTarjet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}