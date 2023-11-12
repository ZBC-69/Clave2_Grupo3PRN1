using System;
using System.Windows.Forms;

namespace Clave2_Grupo
{
    public partial class fmrVerInfoClientes : Form
    {
        public fmrVerInfoClientes()
        {
            InitializeComponent();
            
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Muestra los datos almacenados en la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmrVerInfoClientes_Load(object sender, EventArgs e)
        {
            Clases.Empleado.mostrarHistorialClientes(dgvHistorialRegistros);

        }

        string DUI;
        Clases.Empleado regis = new Clases.Empleado();

        /// <summary>
        /// Traslada a dos objetos texbox el nombre y dui de un cliente registrado.
        /// </summary>
        /// <remarks>Debe dar clic en alguna celda de un datagridview que contenga datos de la base.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHistorialRegistros_CellClick(object sender, DataGridViewCellEventArgs e){
           regis.SeleccionarAlumnos(dgvHistorialRegistros, txtNombre, txtDui);
        }

        /// <summary>
        /// Modifica la información nombre de un cliente en la base de datos. Los texbox dui y nombre no deben estar vacíos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe seleccionar un registro desde la tabla dando click", "Datos no deben estar vacíos",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            regis.ActualizarDatosd(txtNombre,txtDui);
            txtNombre.Text = "";
            txtDui.Text = string.Empty;
            Clases.Empleado.mostrarHistorialClientes(dgvHistorialRegistros);

            LimpiarTexboxes();
        }

        /// <summary>
        /// Boton que elimina todo el registro de un cliente almacenado en la base de datos. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe seleccionar un registro desde la tabla dando click", "Dato vacio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Preguntar al usuario si está seguro de eliminar los datos de la base de datos
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            // Verifica la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                Clases.Empleado registro = new Clases.Empleado();
                registro.EliminarRegistros(txtDui.Text);
                Clases.Empleado.mostrarHistorialClientes(dgvHistorialRegistros);

                LimpiarTexboxes();
            }
        }

        /// <summary>
        /// Permite limpiar el contenido texto de dos texbox txtDui y txtNombre del presente formulario.
        /// </summary>
        private void LimpiarTexboxes()
        {
            txtDui.Text = "";
            txtNombre.Clear();
        }

        /// <summary>
        /// Botón que permite abrir un siguiente formulario (formulario de Ir a Registrar NUEVOS CLIENTES)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIrARegistrarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            //fmrNuevoCliente formNuevoRegistro = new fmrNuevoCliente();
            //formNuevoRegistro.Show();
            fmrPrincipal fmrNuevoCliente = new fmrPrincipal();
            fmrNuevoCliente.Show();
            
        }
    }
}
