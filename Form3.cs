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
        private void dgvHistorialRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHistorialRegistros.Columns[e.ColumnIndex].Name == "Editar")
            {
                //DUI = (dgvHistorialRegistros.CurrentRow.
                //    Cells["DUI"].Value.ToString());
                //frmEDITAR fmrEditDates = new frmEDITAR(DUI);
                //fmrEditDates.ShowDialog();
                //CargarGrid();

                Cliente cliente = new Cliente();

                if (e.RowIndex >= 0 && e.ColumnIndex == dgvHistorialRegistros.Columns["Editar"].Index)
                {
                    cliente.Nombre = dgvHistorialRegistros.Rows[e.RowIndex].Cells[2].Value.ToString();

                    frmEDITAR formEdita = new frmEDITAR(cliente);
                    formEdita.txtNombre.Text = cliente.Nombre;
                    formEdita.Show();
                    MessageBox.Show(formEdita.txtNombre.Text);

                    
                    
                }
            }
        }
    }
}
