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
            this.cDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCreditDiponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVigenciaTarjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialRegistros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir3
            // 
            this.btnSalir3.Location = new System.Drawing.Point(1083, 471);
            this.btnSalir3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(100, 28);
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
            this.CodTarjeta,
            this.cTipoTarjeta,
            this.cCreditDiponible,
            this.cFVencimiento,
            this.cFApertura,
            this.cVigenciaTarjet});
            this.dgvHistorialRegistros.Location = new System.Drawing.Point(389, 62);
            this.dgvHistorialRegistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHistorialRegistros.Name = "dgvHistorialRegistros";
            this.dgvHistorialRegistros.ReadOnly = true;
            this.dgvHistorialRegistros.RowHeadersWidth = 51;
            this.dgvHistorialRegistros.Size = new System.Drawing.Size(843, 308);
            this.dgvHistorialRegistros.TabIndex = 1;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(45, 254);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(212, 28);
            this.btnModificarCliente.TabIndex = 2;
            this.btnModificarCliente.Text = "MODIFICAR CLIENTE";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(61, 290);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(180, 28);
            this.btnEliminarCliente.TabIndex = 3;
            this.btnEliminarCliente.Text = "ELIIMINAR CLIENTE";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(691, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "HISTORIAL Y LISTA DE CLIENTES DE LA EMPRESA DE JUEGOS GAMESIVAR";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(899, 395);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(899, 425);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(860, 471);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(151, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(345, 358);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Clientes GameSivar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 127);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(157, 85);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "DUI";
            // 
            // cDui
            // 
            this.cDui.HeaderText = "DUI";
            this.cDui.MinimumWidth = 6;
            this.cDui.Name = "cDui";
            this.cDui.ReadOnly = true;
            this.cDui.Width = 125;
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
            // fmrVerInfoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1247, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorialRegistros);
            this.Controls.Add(this.btnSalir3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDui;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCreditDiponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVigenciaTarjet;
    }
}