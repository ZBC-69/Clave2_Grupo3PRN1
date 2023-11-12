using System;
using System.Windows.Forms;

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

        /// <summary>
        /// Método válido en el método constructor de fmrPrincipal() para personalizar el diseño del formulario
        /// </summary>
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

        
        /// <summary>
        /// Trabaja sobre los submenus para volverlos visibles o invisibles dependiento de cual esté activo
        /// </summary>
        /// <param name="subMenu"></param>
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

        /// <summary>
        /// Botón lateral Iqz. encargado de abrir y mostrar el submenu "Clientes"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenuClientesAbrir_Click(object sender, EventArgs e){
            mostrarSubmenu(panelSubMenuClientes);
        }

        /// <summary>
        /// Botón que abre el formulario de ingreso de clientes para hacer un registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Metodos.AbrirDiferentesFormularios(new fmrNuevoCliente(), panelContenedorDeFormularios);
            //ocultar el submenu que esté visible
            ocultarSubmenu();
        }

        private void btnConsultarInfoClientes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario fmrVerInfoClientes
            fmrVerInfoClientes formularioClientes = new fmrVerInfoClientes();

            // Mostrar el formulario
            formularioClientes.Show();
            ocultarSubmenu();
            
        }

        private void btnModificarDatosCliente_Click(object sender, EventArgs e){
            ocultarSubmenu();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e) {       
            ocultarSubmenu();
        }
      
        private void btnMenuTarjetasElectronicasAbrir_Click(object sender, EventArgs e)  {
            mostrarSubmenu(panelSubMenuTarjetas);
        }

        private void btnMostrarTarjetasVendidas_Click(object sender, EventArgs e){
            ocultarSubmenu();
        }

        private void btnMostrarTarjetasExpiradas_Click(object sender, EventArgs e){
            ocultarSubmenu();
        }

        private void btnBuscarUnaTarjeta_Click(object sender, EventArgs e){
            ocultarSubmenu();
        }

        
        /// <summary>
        /// Salir de la aplicación si se da click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void btnMenuVentasAbrir_Click(object sender, EventArgs e){
            mostrarSubmenu(panelSubMenuVentas);
        }

        private void btnVenderTarjetas_Click(object sender, EventArgs e)
        {
            Metodos.AbrirDiferentesFormularios(new fmrVenderTarjetas(), panelContenedorDeFormularios);
            ocultarSubmenu();
        }

        private void btnVenderJuegos_Click(object sender, EventArgs e)
        {
            Metodos.AbrirDiferentesFormularios(new fmrVenderJuegos(), panelContenedorDeFormularios);
            ocultarSubmenu();
        }

        //Codificacion del btn para probar conexion
        private void btnConexion_Click(object sender, EventArgs e)
        {
            //creacion de objeto
            Clases.Conexion objetoConexion = new Clases.Conexion();
            objetoConexion.establecerConexion();
        }
    }
}
