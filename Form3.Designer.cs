
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrVerInfoClientes));
            this.btnSalir3 = new System.Windows.Forms.Button();
            this.dgvHistorialRegistros = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialRegistros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir3
            // 
            this.btnSalir3.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalir3.Location = new System.Drawing.Point(1309, 575);
            this.btnSalir3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(132, 28);
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
            this.dgvHistorialRegistros.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvHistorialRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dgvHistorialRegistros.Location = new System.Drawing.Point(384, 44);
            this.dgvHistorialRegistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHistorialRegistros.Name = "dgvHistorialRegistros";
            this.dgvHistorialRegistros.ReadOnly = true;
            this.dgvHistorialRegistros.RowHeadersWidth = 51;
            this.dgvHistorialRegistros.Size = new System.Drawing.Size(1267, 308);
            this.dgvHistorialRegistros.TabIndex = 1;
            this.dgvHistorialRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialRegistros_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Clave2_Grupo.Properties.Resources.EditIco;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Width = 60;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.ForeColor = System.Drawing.Color.Maroon;
            this.btnModificarCliente.Location = new System.Drawing.Point(45, 254);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(212, 28);
            this.btnModificarCliente.TabIndex = 2;
            this.btnModificarCliente.Text = "MODIFICAR CLIENTE";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.Maroon;
            this.btnEliminarCliente.Location = new System.Drawing.Point(61, 290);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(180, 28);
            this.btnEliminarCliente.TabIndex = 3;
            this.btnEliminarCliente.Text = "ELIIMINAR CLIENTE";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(691, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "HISTORIAL Y LISTA DE CLIENTES DE LA EMPRESA DE JUEGOS \"GAMESIVAR\"\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDui);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEliminarCliente);
            this.groupBox1.Controls.Add(this.btnModificarCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(15, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(345, 358);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Clientes GameSivar";
            // 
            // txtDui
            // 
            this.txtDui.BackColor = System.Drawing.SystemColors.Info;
            this.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDui.Enabled = false;
            this.txtDui.Location = new System.Drawing.Point(133, 85);
            this.txtDui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(132, 15);
            this.txtDui.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(134, 134);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 15);
            this.txtNombre.TabIndex = 6;
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
            this.label3.Location = new System.Drawing.Point(5, 132);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Clave2_Grupo.Properties.Resources.DeleteIco;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::Clave2_Grupo.Properties.Resources.EditIco;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // fmrVerInfoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1667, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorialRegistros);
            this.Controls.Add(this.btnSalir3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmrVerInfoClientes";
            this.Text = "VER INFORMACION DE CLIENTES";
            this.Load += new System.EventHandler(this.fmrVerInfoClientes_Load);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.TextBox txtDui;
    }
}