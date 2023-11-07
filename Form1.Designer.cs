
namespace Clave2_Grupo
{
    partial class fmrPrincipal
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
            this.panelMenuMayorLateral = new System.Windows.Forms.Panel();
            this.btnConexion = new System.Windows.Forms.Button();
            this.panelSubMenuVentas = new System.Windows.Forms.Panel();
            this.btnVenderJuegos = new System.Windows.Forms.Button();
            this.btnVenderTarjetas = new System.Windows.Forms.Button();
            this.btnMenuVentasAbrir = new System.Windows.Forms.Button();
            this.panelSubMenuTarjetas = new System.Windows.Forms.Panel();
            this.panelSubMenuClientes = new System.Windows.Forms.Panel();
            this.btnConsultarInfoClientes = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnMenuClientesAbrir = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelAbajo = new System.Windows.Forms.Panel();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.panelContenedorDeFormularios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenuMayorLateral.SuspendLayout();
            this.panelSubMenuVentas.SuspendLayout();
            this.panelSubMenuClientes.SuspendLayout();
            this.panelAbajo.SuspendLayout();
            this.panelContenedorDeFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuMayorLateral
            // 
            this.panelMenuMayorLateral.AutoScroll = true;
            this.panelMenuMayorLateral.BackColor = System.Drawing.Color.Teal;
            this.panelMenuMayorLateral.Controls.Add(this.btnConexion);
            this.panelMenuMayorLateral.Controls.Add(this.panelSubMenuVentas);
            this.panelMenuMayorLateral.Controls.Add(this.btnMenuVentasAbrir);
            this.panelMenuMayorLateral.Controls.Add(this.panelSubMenuTarjetas);
            this.panelMenuMayorLateral.Controls.Add(this.panelSubMenuClientes);
            this.panelMenuMayorLateral.Controls.Add(this.btnMenuClientesAbrir);
            this.panelMenuMayorLateral.Controls.Add(this.panelLogo);
            this.panelMenuMayorLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuMayorLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMayorLateral.Name = "panelMenuMayorLateral";
            this.panelMenuMayorLateral.Size = new System.Drawing.Size(250, 518);
            this.panelMenuMayorLateral.TabIndex = 0;
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(53, 463);
            this.btnConexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(131, 19);
            this.btnConexion.TabIndex = 7;
            this.btnConexion.Text = "Comprobar Conexion";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // panelSubMenuVentas
            // 
            this.panelSubMenuVentas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelSubMenuVentas.Controls.Add(this.btnVenderJuegos);
            this.panelSubMenuVentas.Controls.Add(this.btnVenderTarjetas);
            this.panelSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVentas.Location = new System.Drawing.Point(0, 294);
            this.panelSubMenuVentas.Name = "panelSubMenuVentas";
            this.panelSubMenuVentas.Size = new System.Drawing.Size(250, 125);
            this.panelSubMenuVentas.TabIndex = 6;
            // 
            // btnVenderJuegos
            // 
            this.btnVenderJuegos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenderJuegos.FlatAppearance.BorderSize = 0;
            this.btnVenderJuegos.Location = new System.Drawing.Point(0, 35);
            this.btnVenderJuegos.Name = "btnVenderJuegos";
            this.btnVenderJuegos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVenderJuegos.Size = new System.Drawing.Size(250, 35);
            this.btnVenderJuegos.TabIndex = 2;
            this.btnVenderJuegos.Text = "VENTA DE JUEGOS";
            this.btnVenderJuegos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenderJuegos.UseVisualStyleBackColor = true;
            this.btnVenderJuegos.Click += new System.EventHandler(this.btnVenderJuegos_Click);
            // 
            // btnVenderTarjetas
            // 
            this.btnVenderTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenderTarjetas.FlatAppearance.BorderSize = 0;
            this.btnVenderTarjetas.Location = new System.Drawing.Point(0, 0);
            this.btnVenderTarjetas.Name = "btnVenderTarjetas";
            this.btnVenderTarjetas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVenderTarjetas.Size = new System.Drawing.Size(250, 35);
            this.btnVenderTarjetas.TabIndex = 1;
            this.btnVenderTarjetas.Text = "VENTA DE TARJETAS";
            this.btnVenderTarjetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenderTarjetas.UseVisualStyleBackColor = true;
            this.btnVenderTarjetas.Click += new System.EventHandler(this.btnVenderTarjetas_Click);
            // 
            // btnMenuVentasAbrir
            // 
            this.btnMenuVentasAbrir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuVentasAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuVentasAbrir.FlatAppearance.BorderSize = 0;
            this.btnMenuVentasAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVentasAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVentasAbrir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuVentasAbrir.Location = new System.Drawing.Point(0, 256);
            this.btnMenuVentasAbrir.Name = "btnMenuVentasAbrir";
            this.btnMenuVentasAbrir.Size = new System.Drawing.Size(250, 38);
            this.btnMenuVentasAbrir.TabIndex = 5;
            this.btnMenuVentasAbrir.Text = "MENU VENDER (TARJETAS Y JUEGOS)";
            this.btnMenuVentasAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasAbrir.UseVisualStyleBackColor = false;
            this.btnMenuVentasAbrir.Click += new System.EventHandler(this.btnMenuVentasAbrir_Click);
            // 
            // panelSubMenuTarjetas
            // 
            this.panelSubMenuTarjetas.BackColor = System.Drawing.Color.Teal;
            this.panelSubMenuTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuTarjetas.Location = new System.Drawing.Point(0, 126);
            this.panelSubMenuTarjetas.Name = "panelSubMenuTarjetas";
            this.panelSubMenuTarjetas.Size = new System.Drawing.Size(250, 130);
            this.panelSubMenuTarjetas.TabIndex = 3;
            // 
            // panelSubMenuClientes
            // 
            this.panelSubMenuClientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelSubMenuClientes.Controls.Add(this.btnConsultarInfoClientes);
            this.panelSubMenuClientes.Controls.Add(this.btnNuevoCliente);
            this.panelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuClientes.Location = new System.Drawing.Point(0, 55);
            this.panelSubMenuClientes.Name = "panelSubMenuClientes";
            this.panelSubMenuClientes.Size = new System.Drawing.Size(250, 71);
            this.panelSubMenuClientes.TabIndex = 1;
            // 
            // btnConsultarInfoClientes
            // 
            this.btnConsultarInfoClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarInfoClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultarInfoClientes.Location = new System.Drawing.Point(0, 35);
            this.btnConsultarInfoClientes.Name = "btnConsultarInfoClientes";
            this.btnConsultarInfoClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarInfoClientes.Size = new System.Drawing.Size(250, 34);
            this.btnConsultarInfoClientes.TabIndex = 2;
            this.btnConsultarInfoClientes.Text = "VER INFORMACION DE CLIENTES";
            this.btnConsultarInfoClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarInfoClientes.UseVisualStyleBackColor = true;
            this.btnConsultarInfoClientes.Click += new System.EventHandler(this.btnConsultarInfoClientes_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevoCliente.Size = new System.Drawing.Size(250, 35);
            this.btnNuevoCliente.TabIndex = 1;
            this.btnNuevoCliente.Text = "NUEVO CLIENTE";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnMenuClientesAbrir
            // 
            this.btnMenuClientesAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuClientesAbrir.FlatAppearance.BorderSize = 0;
            this.btnMenuClientesAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuClientesAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuClientesAbrir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuClientesAbrir.Location = new System.Drawing.Point(0, 10);
            this.btnMenuClientesAbrir.Name = "btnMenuClientesAbrir";
            this.btnMenuClientesAbrir.Size = new System.Drawing.Size(250, 45);
            this.btnMenuClientesAbrir.TabIndex = 0;
            this.btnMenuClientesAbrir.Text = "MENU CLIENTES";
            this.btnMenuClientesAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClientesAbrir.UseVisualStyleBackColor = true;
            this.btnMenuClientesAbrir.Click += new System.EventHandler(this.btnMenuClientesAbrir_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 10);
            this.panelLogo.TabIndex = 0;
            // 
            // panelAbajo
            // 
            this.panelAbajo.BackColor = System.Drawing.Color.Teal;
            this.panelAbajo.Controls.Add(this.btnSalir1);
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(250, 418);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(778, 100);
            this.panelAbajo.TabIndex = 1;
            // 
            // btnSalir1
            // 
            this.btnSalir1.Location = new System.Drawing.Point(560, 74);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(75, 23);
            this.btnSalir1.TabIndex = 2;
            this.btnSalir1.Text = "SALIR";
            this.btnSalir1.UseVisualStyleBackColor = true;
            this.btnSalir1.Click += new System.EventHandler(this.btnSalir1_Click);
            // 
            // panelContenedorDeFormularios
            // 
            this.panelContenedorDeFormularios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContenedorDeFormularios.Controls.Add(this.label2);
            this.panelContenedorDeFormularios.Controls.Add(this.label1);
            this.panelContenedorDeFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorDeFormularios.Location = new System.Drawing.Point(250, 0);
            this.panelContenedorDeFormularios.Name = "panelContenedorDeFormularios";
            this.panelContenedorDeFormularios.Size = new System.Drawing.Size(778, 418);
            this.panelContenedorDeFormularios.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(221, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(32, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "PUEDE CONTROLAR LA INFORMACIÓN DE LA EMPRESA\r\n GAMESIVAR COMO SUS CLIENTES";
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 518);
            this.Controls.Add(this.panelContenedorDeFormularios);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.panelMenuMayorLateral);
            this.Name = "fmrPrincipal";
            this.Text = ":::GameSIVAR:::";
            this.panelMenuMayorLateral.ResumeLayout(false);
            this.panelSubMenuVentas.ResumeLayout(false);
            this.panelSubMenuClientes.ResumeLayout(false);
            this.panelAbajo.ResumeLayout(false);
            this.panelContenedorDeFormularios.ResumeLayout(false);
            this.panelContenedorDeFormularios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuMayorLateral;
        private System.Windows.Forms.Panel panelSubMenuClientes;
        private System.Windows.Forms.Button btnConsultarInfoClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnMenuClientesAbrir;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenuTarjetas;
        private System.Windows.Forms.Panel panelAbajo;
        private System.Windows.Forms.Panel panelContenedorDeFormularios;
        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnMenuVentasAbrir;
        private System.Windows.Forms.Panel panelSubMenuVentas;
        private System.Windows.Forms.Button btnVenderJuegos;
        private System.Windows.Forms.Button btnVenderTarjetas;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

