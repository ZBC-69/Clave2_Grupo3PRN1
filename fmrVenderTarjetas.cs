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
    public partial class fmrVenderTarjetas : Form
    {
        const int PrecioPlus = 50;
        const int PrecioSilver = 150;
        const int PrecioGold = 300;
        public fmrVenderTarjetas()
        {
            InitializeComponent();
        }
        string ValidCliente;
        string ValidDUI;
        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            switch (cmbTarjetasComprar.Text)
            {
                case "Plus":
                    errorProvider1.SetError(cmbTarjetasComprar,"");
                    if (txtNumTarjetasComprar.Text==string.Empty)
                    {
                        errorProvider1.SetError(txtNumTarjetasComprar,"Campo Obligatorio");
                    }
                    else
                    {
                        errorProvider1.SetError(txtNumTarjetasComprar, "");
                        try
                        {
                            int CantTarjetas= Convert.ToInt32(txtNumTarjetasComprar.Text);
                            if (CantTarjetas>0)
                            {
                                int TotalPagarTarjetas = CantTarjetas * PrecioPlus;
                                ValidCliente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre completo del cliente", "Identificación de usuario");
                                ValidDUI = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el DUI completo del cliente", "Identificación de usuario");
                                if (ValidCliente == "Carlos Amaya" && ValidDUI == "123456789")
                                {
                                    MessageBox.Show($"Cliente:{ValidCliente}\nDui:{ValidDUI}\nTarjeta seleccionada: Plus\nCantidad de tarjetas: {CantTarjetas}\nEl total a pagar es: ${TotalPagarTarjetas}", "Factura");
                                }
                                else
                                {
                                    MessageBox.Show("No se encuentran registros del cliente");
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(txtNumTarjetasComprar, "Ingrese números positivos");
                            }
                        }
                        catch (Exception)
                        {
                            errorProvider1.SetError(txtNumTarjetasComprar, "Ingrese solo números enteros");
                        }
                    }
                    break;

                case "Silver":
                    errorProvider1.SetError(cmbTarjetasComprar, "");
                    if (txtNumTarjetasComprar.Text == string.Empty)
                    {
                        errorProvider1.SetError(txtNumTarjetasComprar, "Campo Obligatorio");
                    }
                    else
                    {
                        errorProvider1.SetError(txtNumTarjetasComprar, "");
                        try
                        {
                            int CantTarjetas = Convert.ToInt32(txtNumTarjetasComprar.Text);
                            if (CantTarjetas>0)
                            {
                                int TotalPagarTarjetas = CantTarjetas * PrecioSilver;
                                if (ValidCliente == "Carlos Amaya" && ValidDUI == "123456789")
                                {
                                    MessageBox.Show($"Cliente:{ValidCliente}\nDui:{ValidDUI}\nTarjeta seleccionada: Silver\nCantidad de tarjetas: {CantTarjetas}\nEl total a pagar es: ${TotalPagarTarjetas}", "Factura");
                                }
                                else
                                {
                                    MessageBox.Show("No se encuentran registros del cliente");
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(txtNumTarjetasComprar, "Ingrese solo números positivos");
                            }
                        }
                        catch (Exception)
                        {
                            errorProvider1.SetError(txtNumTarjetasComprar, "Ingrese solo números enteros");
                        }
                    }
                    break;

                case "Gold":
                    errorProvider1.SetError(cmbTarjetasComprar, "");
                    if (txtNumTarjetasComprar.Text == string.Empty)
                    {
                        errorProvider1.SetError(txtNumTarjetasComprar, "Campo Obligatorio");
                    }
                    else
                    {
                        errorProvider1.SetError(txtNumTarjetasComprar, "");
                        try
                        {
                            int CantTarjetas = Convert.ToInt32(txtNumTarjetasComprar.Text);
                            if (CantTarjetas>0)
                            {
                                int TotalPagarTarjetas = CantTarjetas * PrecioGold;
                                ValidCliente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre completo del cliente", "Identificación de usuario");
                                ValidDUI = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el DUI completo del cliente", "Identificación de usuario");
                                if (ValidCliente == "Carlos Amaya" && ValidDUI == "123456789")
                                {
                                    MessageBox.Show($"Cliente:{ValidCliente}\nDui:{ValidDUI}\nTarjeta seleccionada: Gold\nCantidad de tarjetas: {CantTarjetas}\nEl total a pagar es: ${TotalPagarTarjetas}", "Factura");
                                }
                                else
                                {
                                    MessageBox.Show("No se encuentran registros del cliente");
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(txtNumTarjetasComprar, "Ingrese solo números positivos");
                            }
                        }
                        catch (Exception)
                        {
                            errorProvider1.SetError(txtNumTarjetasComprar, "Ingrese solo números enteros");
                        }
                    }
                    break;
                default:
                    errorProvider1.SetError(cmbTarjetasComprar, "Campo obligatorio");
                    break;
            }
        }
    }
}
