
namespace Clave2_Grupo
{
    partial class fmrNuevoCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrNuevoCliente));
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mskDUI = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvRegistroClientes = new System.Windows.Forms.DataGridView();
            this.btnIrACompras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.SystemColors.Info;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalir2.Location = new System.Drawing.Point(748, 471);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(100, 28);
            this.btnSalir2.TabIndex = 1;
            this.btnSalir2.Text = "CERRAR";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClienteNombre.Location = new System.Drawing.Point(59, 82);
            this.lblClienteNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(136, 17);
            this.lblClienteNombre.TabIndex = 2;
            this.lblClienteNombre.Text = "Nombre Completo";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDUI.Location = new System.Drawing.Point(59, 127);
            this.lblDUI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(273, 17);
            this.lblDUI.TabIndex = 3;
            this.lblDUI.Text = "Documento Unico de Identidad (DUI)";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(364, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomCompleto_KeyPress);
            // 
            // mskDUI
            // 
            this.mskDUI.Location = new System.Drawing.Point(364, 127);
            this.mskDUI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskDUI.Mask = "00000000-0";
            this.mskDUI.Name = "mskDUI";
            this.mskDUI.Size = new System.Drawing.Size(132, 22);
            this.mskDUI.TabIndex = 5;
            this.mskDUI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktxtDUI_MaskInputRejected);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(659, 242);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Registrar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvRegistroClientes
            // 
            this.dgvRegistroClientes.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvRegistroClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroClientes.Location = new System.Drawing.Point(149, 178);
            this.dgvRegistroClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRegistroClientes.Name = "dgvRegistroClientes";
            this.dgvRegistroClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRegistroClientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistroClientes.Size = new System.Drawing.Size(457, 185);
            this.dgvRegistroClientes.TabIndex = 7;
            // 
            // btnIrACompras
            // 
            this.btnIrACompras.BackColor = System.Drawing.SystemColors.Info;
            this.btnIrACompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrACompras.ForeColor = System.Drawing.Color.Maroon;
            this.btnIrACompras.Location = new System.Drawing.Point(444, 471);
            this.btnIrACompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIrACompras.Name = "btnIrACompras";
            this.btnIrACompras.Size = new System.Drawing.Size(273, 28);
            this.btnIrACompras.TabIndex = 8;
            this.btnIrACompras.Text = "IR A COMPRAR TARJETAS";
            this.btnIrACompras.UseVisualStyleBackColor = false;
            this.btnIrACompras.Click += new System.EventHandler(this.btnIrACompras_Click);
            // 
            // fmrNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(851, 514);
            this.Controls.Add(this.btnIrACompras);
            this.Controls.Add(this.dgvRegistroClientes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mskDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.btnSalir2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmrNuevoCliente";
            this.Text = "FORMULARIO DE NUEVO CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mskDUI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvRegistroClientes;
        private System.Windows.Forms.Button btnIrACompras;
    }
}