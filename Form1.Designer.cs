
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
            this.btnBuscarUnaTarjeta = new System.Windows.Forms.Button();
            this.btnMostrarTarjetasExpiradas = new System.Windows.Forms.Button();
            this.btnMostrarTarjetasVendidas = new System.Windows.Forms.Button();
            this.btnMenuTarjetasElectronicasAbrir = new System.Windows.Forms.Button();
            this.panelSubMenuClientes = new System.Windows.Forms.Panel();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarDatosCliente = new System.Windows.Forms.Button();
            this.btnConsultarInfoClientes = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnMenuClientesAbrir = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelAbajo = new System.Windows.Forms.Panel();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.panelContenedorDeFormularios = new System.Windows.Forms.Panel();
            this.panelMenuMayorLateral.SuspendLayout();
            this.panelSubMenuVentas.SuspendLayout();
            this.panelSubMenuTarjetas.SuspendLayout();
            this.panelSubMenuClientes.SuspendLayout();
            this.panelAbajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuMayorLateral
            // 
            this.panelMenuMayorLateral.AutoScroll = true;
            this.panelMenuMayorLateral.BackColor = System.Drawing.Color.Teal;
            this.panelMenuMayorLateral.Controls.Add(this.panelSubMenuVentas);
            this.panelMenuMayorLateral.Controls.Add(this.btnMenuVentasAbrir);
            this.panelMenuMayorLateral.Controls.Add(this.panelSubMenuTarjetas);
            this.panelMenuMayorLateral.Controls.Add(this.btnMenuTarjetasElectronicasAbrir);
            this.panelMenuMayorLateral.Controls.Add(this.panelSubMenuClientes);
            this.panelMenuMayorLateral.Controls.Add(this.btnMenuClientesAbrir);
            this.panelMenuMayorLateral.Controls.Add(this.panelLogo);
            this.panelMenuMayorLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuMayorLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMayorLateral.Name = "panelMenuMayorLateral";
            this.panelMenuMayorLateral.Size = new System.Drawing.Size(250, 518);
            this.panelMenuMayorLateral.TabIndex = 0;
            // 
            // panelSubMenuVentas
            // 
            this.panelSubMenuVentas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelSubMenuVentas.Controls.Add(this.btnVenderJuegos);
            this.panelSubMenuVentas.Controls.Add(this.btnVenderTarjetas);
            this.panelSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVentas.Location = new System.Drawing.Point(0, 439);
            this.panelSubMenuVentas.Name = "panelSubMenuVentas";
            this.panelSubMenuVentas.Size = new System.Drawing.Size(233, 130);
            this.panelSubMenuVentas.TabIndex = 6;
            // 
            // btnVenderJuegos
            // 
            this.btnVenderJuegos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenderJuegos.FlatAppearance.BorderSize = 0;
            this.btnVenderJuegos.Location = new System.Drawing.Point(0, 35);
            this.btnVenderJuegos.Name = "btnVenderJuegos";
            this.btnVenderJuegos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVenderJuegos.Size = new System.Drawing.Size(233, 35);
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
            this.btnVenderTarjetas.Size = new System.Drawing.Size(233, 35);
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
            this.btnMenuVentasAbrir.Location = new System.Drawing.Point(0, 394);
            this.btnMenuVentasAbrir.Name = "btnMenuVentasAbrir";
            this.btnMenuVentasAbrir.Size = new System.Drawing.Size(233, 45);
            this.btnMenuVentasAbrir.TabIndex = 5;
            this.btnMenuVentasAbrir.Text = "MENU VENDER (TARJETAS Y JUEGOS)";
            this.btnMenuVentasAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasAbrir.UseVisualStyleBackColor = false;
            this.btnMenuVentasAbrir.Click += new System.EventHandler(this.btnMenuVentasAbrir_Click);
            // 
            // panelSubMenuTarjetas
            // 
            this.panelSubMenuTarjetas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelSubMenuTarjetas.Controls.Add(this.btnBuscarUnaTarjeta);
            this.panelSubMenuTarjetas.Controls.Add(this.btnMostrarTarjetasExpiradas);
            this.panelSubMenuTarjetas.Controls.Add(this.btnMostrarTarjetasVendidas);
            this.panelSubMenuTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuTarjetas.Location = new System.Drawing.Point(0, 264);
            this.panelSubMenuTarjetas.Name = "panelSubMenuTarjetas";
            this.panelSubMenuTarjetas.Size = new System.Drawing.Size(233, 130);
            this.panelSubMenuTarjetas.TabIndex = 3;
            // 
            // btnBuscarUnaTarjeta
            // 
            this.btnBuscarUnaTarjeta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarUnaTarjeta.FlatAppearance.BorderSize = 0;
            this.btnBuscarUnaTarjeta.Location = new System.Drawing.Point(0, 70);
            this.btnBuscarUnaTarjeta.Name = "btnBuscarUnaTarjeta";
            this.btnBuscarUnaTarjeta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBuscarUnaTarjeta.Size = new System.Drawing.Size(233, 35);
            this.btnBuscarUnaTarjeta.TabIndex = 3;
            this.btnBuscarUnaTarjeta.Text = "BUSCAR TARJETA";
            this.btnBuscarUnaTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUnaTarjeta.UseVisualStyleBackColor = true;
            this.btnBuscarUnaTarjeta.Click += new System.EventHandler(this.btnBuscarUnaTarjeta_Click);
            // 
            // btnMostrarTarjetasExpiradas
            // 
            this.btnMostrarTarjetasExpiradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarTarjetasExpiradas.FlatAppearance.BorderSize = 0;
            this.btnMostrarTarjetasExpiradas.Location = new System.Drawing.Point(0, 35);
            this.btnMostrarTarjetasExpiradas.Name = "btnMostrarTarjetasExpiradas";
            this.btnMostrarTarjetasExpiradas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMostrarTarjetasExpiradas.Size = new System.Drawing.Size(233, 35);
            this.btnMostrarTarjetasExpiradas.TabIndex = 2;
            this.btnMostrarTarjetasExpiradas.Text = "TARJETAS EXPIRADAS";
            this.btnMostrarTarjetasExpiradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTarjetasExpiradas.UseVisualStyleBackColor = true;
            this.btnMostrarTarjetasExpiradas.Click += new System.EventHandler(this.btnMostrarTarjetasExpiradas_Click);
            // 
            // btnMostrarTarjetasVendidas
            // 
            this.btnMostrarTarjetasVendidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarTarjetasVendidas.FlatAppearance.BorderSize = 0;
            this.btnMostrarTarjetasVendidas.Location = new System.Drawing.Point(0, 0);
            this.btnMostrarTarjetasVendidas.Name = "btnMostrarTarjetasVendidas";
            this.btnMostrarTarjetasVendidas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMostrarTarjetasVendidas.Size = new System.Drawing.Size(233, 35);
            this.btnMostrarTarjetasVendidas.TabIndex = 1;
            this.btnMostrarTarjetasVendidas.Text = "INFORMACION \r\nDE TARJETAS VENDIDAS";
            this.btnMostrarTarjetasVendidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTarjetasVendidas.UseVisualStyleBackColor = true;
            this.btnMostrarTarjetasVendidas.Click += new System.EventHandler(this.btnMostrarTarjetasVendidas_Click);
            // 
            // btnMenuTarjetasElectronicasAbrir
            // 
            this.btnMenuTarjetasElectronicasAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuTarjetasElectronicasAbrir.FlatAppearance.BorderSize = 0;
            this.btnMenuTarjetasElectronicasAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTarjetasElectronicasAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTarjetasElectronicasAbrir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuTarjetasElectronicasAbrir.Location = new System.Drawing.Point(0, 219);
            this.btnMenuTarjetasElectronicasAbrir.Name = "btnMenuTarjetasElectronicasAbrir";
            this.btnMenuTarjetasElectronicasAbrir.Size = new System.Drawing.Size(233, 45);
            this.btnMenuTarjetasElectronicasAbrir.TabIndex = 2;
            this.btnMenuTarjetasElectronicasAbrir.Text = "MENU TARJETAS ELECTRONICAS";
            this.btnMenuTarjetasElectronicasAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTarjetasElectronicasAbrir.UseVisualStyleBackColor = true;
            this.btnMenuTarjetasElectronicasAbrir.Click += new System.EventHandler(this.btnMenuTarjetasElectronicasAbrir_Click);
            // 
            // panelSubMenuClientes
            // 
            this.panelSubMenuClientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelSubMenuClientes.Controls.Add(this.btnEliminarCliente);
            this.panelSubMenuClientes.Controls.Add(this.btnModificarDatosCliente);
            this.panelSubMenuClientes.Controls.Add(this.btnConsultarInfoClientes);
            this.panelSubMenuClientes.Controls.Add(this.btnNuevoCliente);
            this.panelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuClientes.Location = new System.Drawing.Point(0, 55);
            this.panelSubMenuClientes.Name = "panelSubMenuClientes";
            this.panelSubMenuClientes.Size = new System.Drawing.Size(233, 164);
            this.panelSubMenuClientes.TabIndex = 1;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.Location = new System.Drawing.Point(0, 105);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarCliente.Size = new System.Drawing.Size(233, 35);
            this.btnEliminarCliente.TabIndex = 4;
            this.btnEliminarCliente.Text = "ELIMINAR UN CLIENTE";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificarDatosCliente
            // 
            this.btnModificarDatosCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarDatosCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarDatosCliente.Location = new System.Drawing.Point(0, 70);
            this.btnModificarDatosCliente.Name = "btnModificarDatosCliente";
            this.btnModificarDatosCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnModificarDatosCliente.Size = new System.Drawing.Size(233, 35);
            this.btnModificarDatosCliente.TabIndex = 3;
            this.btnModificarDatosCliente.Text = "MODIFICAR USUARIO";
            this.btnModificarDatosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarDatosCliente.UseVisualStyleBackColor = true;
            this.btnModificarDatosCliente.Click += new System.EventHandler(this.btnModificarDatosCliente_Click);
            // 
            // btnConsultarInfoClientes
            // 
            this.btnConsultarInfoClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarInfoClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultarInfoClientes.Location = new System.Drawing.Point(0, 35);
            this.btnConsultarInfoClientes.Name = "btnConsultarInfoClientes";
            this.btnConsultarInfoClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarInfoClientes.Size = new System.Drawing.Size(233, 35);
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
            this.btnNuevoCliente.Size = new System.Drawing.Size(233, 35);
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
            this.btnMenuClientesAbrir.Size = new System.Drawing.Size(233, 45);
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
            this.panelLogo.Size = new System.Drawing.Size(233, 10);
            this.panelLogo.TabIndex = 0;
            // 
            // panelAbajo
            // 
            this.panelAbajo.BackColor = System.Drawing.Color.Teal;
            this.panelAbajo.Controls.Add(this.btnSalir1);
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(250, 418);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(810, 100);
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
            this.panelContenedorDeFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorDeFormularios.Location = new System.Drawing.Point(250, 0);
            this.panelContenedorDeFormularios.Name = "panelContenedorDeFormularios";
            this.panelContenedorDeFormularios.Size = new System.Drawing.Size(810, 418);
            this.panelContenedorDeFormularios.TabIndex = 2;
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 518);
            this.Controls.Add(this.panelContenedorDeFormularios);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.panelMenuMayorLateral);
            this.Name = "fmrPrincipal";
            this.Text = "FORMULARIO PRINCIPAL";
            this.panelMenuMayorLateral.ResumeLayout(false);
            this.panelSubMenuVentas.ResumeLayout(false);
            this.panelSubMenuTarjetas.ResumeLayout(false);
            this.panelSubMenuClientes.ResumeLayout(false);
            this.panelAbajo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuMayorLateral;
        private System.Windows.Forms.Panel panelSubMenuClientes;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarDatosCliente;
        private System.Windows.Forms.Button btnConsultarInfoClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnMenuClientesAbrir;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenuTarjetas;
        private System.Windows.Forms.Button btnBuscarUnaTarjeta;
        private System.Windows.Forms.Button btnMostrarTarjetasExpiradas;
        private System.Windows.Forms.Button btnMostrarTarjetasVendidas;
        private System.Windows.Forms.Button btnMenuTarjetasElectronicasAbrir;
        private System.Windows.Forms.Panel panelAbajo;
        private System.Windows.Forms.Panel panelContenedorDeFormularios;
        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnMenuVentasAbrir;
        private System.Windows.Forms.Panel panelSubMenuVentas;
        private System.Windows.Forms.Button btnVenderJuegos;
        private System.Windows.Forms.Button btnVenderTarjetas;
    }
}

