using System;
using System.Windows.Forms;

namespace Clave2_Grupo
{
    public partial class fmrVerInfoClientes : Form
    {
        public fmrVerInfoClientes()
        {
            InitializeComponent();
            //Clases.RegistroCliente objetoCliente = new Clases.RegistroCliente();
            //objetoCliente.mostrarClientes(dgvHistorialRegistros);
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmrVerInfoClientes_Load(object sender, EventArgs e)
        {
            Clases.RegistroCliente.mostrarHistorialClientes(dgvHistorialRegistros);

        }

        string DUI;
        Clases.RegistroCliente regis = new Clases.RegistroCliente();
        private void dgvHistorialRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            regis.SeleccionarAlumnos(dgvHistorialRegistros, txtNombre, txtDui);
        }

        

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
            Clases.RegistroCliente.mostrarHistorialClientes(dgvHistorialRegistros);

            LimpiarTexboxes();
        }

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
                //// Ejecuta las acciones de eliminacion de los datos
                //Clases.RegistroCliente registro = new Clases.RegistroCliente();
                //registro.EliminarRegistro(txtDui);
                //Clases.RegistroCliente.mostrarHistorialClientes(dgvHistorialRegistros);

                Clases.RegistroCliente registro = new Clases.RegistroCliente();
                registro.EliminarRegistro(txtDui.Text);
                Clases.RegistroCliente.mostrarHistorialClientes(dgvHistorialRegistros);

                LimpiarTexboxes();
            }
        }

        private void LimpiarTexboxes()
        {
            txtDui.Text = "";
            txtNombre.Clear();
        }
    }
}
