
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
            this.btnConexion = new System.Windows.Forms.Button();
            this.panelMenuMayorLateral.SuspendLayout();
            this.panelSubMenuVentas.SuspendLayout();
            this.panelSubMenuClientes.SuspendLayout();
            this.panelAbajo.SuspendLayout();
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
            this.panelMenuMayorLateral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuMayorLateral.Name = "panelMenuMayorLateral";
            this.panelMenuMayorLateral.Size = new System.Drawing.Size(333, 638);
            this.panelMenuMayorLateral.TabIndex = 0;
            // 
            // panelSubMenuVentas
            // 
            this.panelSubMenuVentas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelSubMenuVentas.Controls.Add(this.btnVenderJuegos);
            this.panelSubMenuVentas.Controls.Add(this.btnVenderTarjetas);
            this.panelSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVentas.Location = new System.Drawing.Point(0, 361);
            this.panelSubMenuVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubMenuVentas.Name = "panelSubMenuVentas";
            this.panelSubMenuVentas.Size = new System.Drawing.Size(333, 154);
            this.panelSubMenuVentas.TabIndex = 6;
            // 
            // btnVenderJuegos
            // 
            this.btnVenderJuegos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenderJuegos.FlatAppearance.BorderSize = 0;
            this.btnVenderJuegos.Location = new System.Drawing.Point(0, 43);
            this.btnVenderJuegos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVenderJuegos.Name = "btnVenderJuegos";
            this.btnVenderJuegos.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnVenderJuegos.Size = new System.Drawing.Size(333, 43);
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
            this.btnVenderTarjetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVenderTarjetas.Name = "btnVenderTarjetas";
            this.btnVenderTarjetas.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnVenderTarjetas.Size = new System.Drawing.Size(333, 43);
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
            this.btnMenuVentasAbrir.Location = new System.Drawing.Point(0, 314);
            this.btnMenuVentasAbrir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuVentasAbrir.Name = "btnMenuVentasAbrir";
            this.btnMenuVentasAbrir.Size = new System.Drawing.Size(333, 47);
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
            this.panelSubMenuTarjetas.Location = new System.Drawing.Point(0, 154);
            this.panelSubMenuTarjetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubMenuTarjetas.Name = "panelSubMenuTarjetas";
            this.panelSubMenuTarjetas.Size = new System.Drawing.Size(333, 160);
            this.panelSubMenuTarjetas.TabIndex = 3;
            // 
            // panelSubMenuClientes
            // 
            this.panelSubMenuClientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelSubMenuClientes.Controls.Add(this.btnConsultarInfoClientes);
            this.panelSubMenuClientes.Controls.Add(this.btnNuevoCliente);
            this.panelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuClientes.Location = new System.Drawing.Point(0, 67);
            this.panelSubMenuClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubMenuClientes.Name = "panelSubMenuClientes";
            this.panelSubMenuClientes.Size = new System.Drawing.Size(333, 87);
            this.panelSubMenuClientes.TabIndex = 1;
            // 
            // btnConsultarInfoClientes
            // 
            this.btnConsultarInfoClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarInfoClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultarInfoClientes.Location = new System.Drawing.Point(0, 43);
            this.btnConsultarInfoClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarInfoClientes.Name = "btnConsultarInfoClientes";
            this.btnConsultarInfoClientes.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnConsultarInfoClientes.Size = new System.Drawing.Size(333, 42);
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
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnNuevoCliente.Size = new System.Drawing.Size(333, 43);
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
            this.btnMenuClientesAbrir.Location = new System.Drawing.Point(0, 12);
            this.btnMenuClientesAbrir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuClientesAbrir.Name = "btnMenuClientesAbrir";
            this.btnMenuClientesAbrir.Size = new System.Drawing.Size(333, 55);
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(333, 12);
            this.panelLogo.TabIndex = 0;
            // 
            // panelAbajo
            // 
            this.panelAbajo.BackColor = System.Drawing.Color.Teal;
            this.panelAbajo.Controls.Add(this.btnSalir1);
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(333, 515);
            this.panelAbajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(1080, 123);
            this.panelAbajo.TabIndex = 1;
            // 
            // btnSalir1
            // 
            this.btnSalir1.Location = new System.Drawing.Point(747, 91);
            this.btnSalir1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(100, 28);
            this.btnSalir1.TabIndex = 2;
            this.btnSalir1.Text = "SALIR";
            this.btnSalir1.UseVisualStyleBackColor = true;
            this.btnSalir1.Click += new System.EventHandler(this.btnSalir1_Click);
            // 
            // panelContenedorDeFormularios
            // 
            this.panelContenedorDeFormularios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContenedorDeFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorDeFormularios.Location = new System.Drawing.Point(333, 0);
            this.panelContenedorDeFormularios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedorDeFormularios.Name = "panelContenedorDeFormularios";
            this.panelContenedorDeFormularios.Size = new System.Drawing.Size(1080, 515);
            this.panelContenedorDeFormularios.TabIndex = 2;
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(71, 570);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(175, 23);
            this.btnConexion.TabIndex = 7;
            this.btnConexion.Text = "Comprobar Conexion";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 638);
            this.Controls.Add(this.panelContenedorDeFormularios);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.panelMenuMayorLateral);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmrPrincipal";
            this.Text = ":::GameSIVAR:::";
            this.panelMenuMayorLateral.ResumeLayout(false);
            this.panelSubMenuVentas.ResumeLayout(false);
            this.panelSubMenuClientes.ResumeLayout(false);
            this.panelAbajo.ResumeLayout(false);
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
    }
}

