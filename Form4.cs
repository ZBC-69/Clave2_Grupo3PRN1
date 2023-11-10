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
    public partial class frmEDITAR : Form
    {
        private Cliente cliente; // Propiedad para almacenar el objeto Cliente
        public frmEDITAR()
        {
            InitializeComponent();
        }

        public frmEDITAR(string DUI)
        {
            InitializeComponent();
        }

        public frmEDITAR(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente; // Asigna el objeto Cliente recibido al campo de la clase
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clases.RegistroCliente objetoRegistro = new Clases.RegistroCliente();

            cliente.NumDui = txtDUI.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.TipoTarjeta = txtTipo.Text;

            Tarjeta trjeta = new Tarjeta();
            trjeta.SaldoActual = Convert.ToInt32(txtCredito.Text);
            trjeta.FechaVencimiento = txtVence.Text;
            trjeta.FechaApertura = txtApertura.Text;
            String code = "FDJKFD";
            string vigente = "ACTIV";
            objetoRegistro.registrarClientes(cliente.NumDui, cliente.Nombre);

            
            
            objetoRegistro.guardarOtrosDatos(cliente.NumDui,
                trjeta.CodigoTarjeta,
                code,
                trjeta.SaldoActual,               
                trjeta.FechaVencimiento,
                trjeta.FechaApertura,
                vigente);
                
        }

    }
}
