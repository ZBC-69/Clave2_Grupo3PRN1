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
    }
}
