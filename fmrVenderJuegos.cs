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
            string productoVendido;
            
            if (radJuegMecanic.Checked)
            {
                productoVendido = radJuegMecanic.Text;
            }
            else
            {
                if (radJuegElectronic.Checked)
                {
                    productoVendido = radJuegElectronic.Text;
                }
                else
                {
                    productoVendido= "Por favor seleccione un tipo de juego para la compra";
                    MessageBox.Show(productoVendido, "No seleccionó ningún tipo de juego",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

            }

            
            DateTime fechaActual = DateTime.Now;
            string mensaje = $"Tipo de Juego: {productoVendido}" + "\n" +
                            "Fecha y hora actual: " + fechaActual.ToString() + "\n" +
                            "Día de la semana: " + fechaActual.ToString("dddd");

            string diaSeman = fechaActual.ToString("dddd");
            MessageBox.Show(mensaje+""+"\nES DIA: "+diaSeman, "SE VENDIÓ UN PRODUCTO JUEGO");
            ResetearValores();
        }

        private void ResetearValores()
        {
            radJuegMecanic.Checked = false;
            radJuegElectronic.Checked = false;
            
            // Restablecer otros valores si es necesario
            // ...
        }
    }
}
