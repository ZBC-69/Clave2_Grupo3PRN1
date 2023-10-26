
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
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.txtNomCompleto = new System.Windows.Forms.TextBox();
            this.msktxtDUI = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAddClientePrueba = new System.Windows.Forms.DataGridView();
            this.btnIrACompras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddClientePrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(561, 383);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(75, 23);
            this.btnSalir2.TabIndex = 1;
            this.btnSalir2.Text = "CERRAR";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(64, 67);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(91, 13);
            this.lblClienteNombre.TabIndex = 2;
            this.lblClienteNombre.Text = "Nombre Completo";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(64, 103);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(177, 13);
            this.lblDUI.TabIndex = 3;
            this.lblDUI.Text = "Documento Unico de Identidad DUI";
            // 
            // txtNomCompleto
            // 
            this.txtNomCompleto.Location = new System.Drawing.Point(273, 67);
            this.txtNomCompleto.Name = "txtNomCompleto";
            this.txtNomCompleto.Size = new System.Drawing.Size(100, 20);
            this.txtNomCompleto.TabIndex = 4;
            this.txtNomCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomCompleto_KeyPress);
            // 
            // msktxtDUI
            // 
            this.msktxtDUI.Location = new System.Drawing.Point(273, 103);
            this.msktxtDUI.Mask = "00000000-0";
            this.msktxtDUI.Name = "msktxtDUI";
            this.msktxtDUI.Size = new System.Drawing.Size(100, 20);
            this.msktxtDUI.TabIndex = 5;
            this.msktxtDUI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktxtDUI_MaskInputRejected);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(285, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Registrar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAddClientePrueba
            // 
            this.dgvAddClientePrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddClientePrueba.Location = new System.Drawing.Point(77, 184);
            this.dgvAddClientePrueba.Name = "dgvAddClientePrueba";
            this.dgvAddClientePrueba.Size = new System.Drawing.Size(505, 150);
            this.dgvAddClientePrueba.TabIndex = 7;
            // 
            // btnIrACompras
            // 
            this.btnIrACompras.Location = new System.Drawing.Point(285, 383);
            this.btnIrACompras.Name = "btnIrACompras";
            this.btnIrACompras.Size = new System.Drawing.Size(205, 23);
            this.btnIrACompras.TabIndex = 8;
            this.btnIrACompras.Text = "IR A COMPRAR TARJETAS";
            this.btnIrACompras.UseVisualStyleBackColor = true;
            this.btnIrACompras.Click += new System.EventHandler(this.btnIrACompras_Click);
            // 
            // fmrNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 418);
            this.Controls.Add(this.btnIrACompras);
            this.Controls.Add(this.dgvAddClientePrueba);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.msktxtDUI);
            this.Controls.Add(this.txtNomCompleto);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.btnSalir2);
            this.Name = "fmrNuevoCliente";
            this.Text = "FORMULARIO DE NUEVO CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddClientePrueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.TextBox txtNomCompleto;
        private System.Windows.Forms.MaskedTextBox msktxtDUI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAddClientePrueba;
        private System.Windows.Forms.Button btnIrACompras;
    }
}