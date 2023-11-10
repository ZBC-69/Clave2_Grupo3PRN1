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
           
            regis.SeleccionarAlumnos(dgvHistorialRegistros, txtNombre, mskDui);
        }

        private void dgvHistorialRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe seleccionar un regisitro desde la tabla dando click", "Datos no deben estar vacíos",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            regis.ActualizarDatosd(txtNombre,mskDui);
            txtNombre.Text = "";
            mskDui.Text = string.Empty;
            Clases.RegistroCliente.mostrarHistorialClientes(dgvHistorialRegistros);
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            
        }
    }
}
