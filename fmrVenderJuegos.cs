using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave2_Grupo
{
    public partial class fmrVenderJuegos : Form
    {
        public fmrVenderJuegos()
        {
            InitializeComponent();

            
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPreciosJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrarCompraJuego_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SE VENDIO UN PRODUCTO JUEGO");
        }
    }
}
