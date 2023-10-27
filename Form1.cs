using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Clave2_Grupo
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
            //llamar al método de personalizar el diseño del formulario
            personalizarDiseñoForm();
        }

        private void personalizarDiseñoForm()
        {
            //ocultar los paneles de submenus
            panelSubMenuClientes.Visible = false;
            panelSubMenuTarjetas.Visible = false;
            panelSubMenuVentas.Visible = false;
            //...

        }

        /// <summary>
        /// Este método oculta los submenús relacionados con clientes y tarjetas si están visibles.
        /// </summary>
        private void ocultarSubmenu()
        {
            // Verificar si el submenú de Clientes está visible
            if (panelSubMenuClientes.Visible == true)
            {
                // Si está visible, lo ocultamos
                panelSubMenuClientes.Visible = false;
            }

            // Verificar si el submenú de Tarjetas está visible
            if (panelSubMenuTarjetas.Visible == true)
            {
                // Si está visible, lo ocultamos
                panelSubMenuTarjetas.Visible = false;
            }

            // Verificar si el submenú de Ventas está visible
            if (panelSubMenuVentas.Visible == true)
            {
                // Si está visible, lo ocultamos
                panelSubMenuVentas.Visible = false;
            }
        }

        //mostrar los submenus
        private void mostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                ocultarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMenuClientesAbrir_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenuClientes);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            abrirDiferentesFormularios(new fmrNuevoCliente());
            

            ocultarSubmenu();

        }

        private void btnConsultarInfoClientes_Click(object sender, EventArgs e)
        {
            abrirDiferentesFormularios(new fmrVerInfoClientes());
            //...
            //Your Code
            //...
            ocultarSubmenu();
        }

        private void btnModificarDatosCliente_Click(object sender, EventArgs e)
        {
            //...
            //Your Code
            //...
            ocultarSubmenu();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            
            //...
            //Your Code
            //...
            ocultarSubmenu();
        }
      
        private void btnMenuTarjetasElectronicasAbrir_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenuTarjetas);
        }

        private void btnMostrarTarjetasVendidas_Click(object sender, EventArgs e)
        {
            //...
            //Your Code
            //...
            ocultarSubmenu();
        }

        private void btnMostrarTarjetasExpiradas_Click(object sender, EventArgs e)
        {
            //...
            //Your Code
            //...
            ocultarSubmenu();
        }

        private void btnBuscarUnaTarjeta_Click(object sender, EventArgs e)
        {
            //...
            //Your Code
            //...
            ocultarSubmenu();
        }

        //=============================ABRIR DIFERENTES FORMULARIOS=============



        private Form fmrActivo = null;
        /// <summary>
        /// Método que permite abrir diversos formularios del formulario principal
        /// </summary>
        /// <param name="fmrCualquiera"></param>
        private void abrirDiferentesFormularios(Form fmrCualquiera)
        {
            if (fmrActivo != null)
            {
                fmrActivo.Close();
            }
            fmrActivo = fmrCualquiera;
            fmrCualquiera.TopLevel = false;
            fmrCualquiera.FormBorderStyle = FormBorderStyle.None;
            fmrCualquiera.Dock = DockStyle.Fill;
            panelContenedorDeFormularios.Controls.Add(fmrCualquiera);
            panelContenedorDeFormularios.Tag = fmrCualquiera;
            fmrCualquiera.BringToFront();
            fmrCualquiera.Show();
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje al usuario y preguntar si quiere salirse
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirme si desea salirse", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Si el usuario confirma, cerrar la aplicación pues se cierra el programa
                Application.Exit();
            }
        }

        private void btnMenuVentasAbrir_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenuVentas);
        }

        private void btnVenderTarjetas_Click(object sender, EventArgs e)
        {
            abrirDiferentesFormularios(new fmrVenderTarjetas());
            //...
            //Your Code
            //...
            ocultarSubmenu();
        }

        private void btnVenderJuegos_Click(object sender, EventArgs e)
        {
            abrirDiferentesFormularios(new fmrVenderJuegos());
            //...
            //Your Code
            //...
            ocultarSubmenu();
        }
    }
}
