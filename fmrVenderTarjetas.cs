﻿using System;
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

        private Cliente cliente; // Propiedad para almacenar el objeto Cliente

        // Constructor que acepta un objeto Cliente como parámetro
        // y con esto nos aseguramos de recoger los datos y que se hayan guardado en otros formularios y así continuarlos usando
        public fmrVenderTarjetas(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente; // Asigna el objeto Cliente recibido al campo de la clase
        }
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
        /// <summary>
        /// Botón que se encarga de procesar la compra de tarjetas eleectrónicas para un cliente.
        /// Lo anterior una vez el cliente ya está registrado en la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //verificar si ya se registró un cliente
            //LAS LINEAS SIGUIENTES ESTARÁN COMENTADAS TEMPORALMENTE
            //if (cliente != null && !string.IsNullOrEmpty(cliente.Nombre))
            //{
            //    MessageBox.Show(cliente.Nombre + " " + cliente.NumDui);
            //}
            //else
            //{
            //    MessageBox.Show("Primero debe registrar un cliente en el formulario de registros", "No se encuentran registros del cliente",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            //    return;
            //}

            //comprobar cual tarjeta fue seleccionada y la cantidad de tarjetas a comprar
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
                    int TotalPagarTarjetas = 0;
                    string tarjetaSeleccionadaV = "";

                    switch (cmbTarjetasComprar.Text)
                    {
                        case "Plus":
                            TotalPagarTarjetas = CantTarjetas * PrecioPlus;
                            tarjetaSeleccionadaV = "Plus";
                            break;

                        case "Silver":
                            TotalPagarTarjetas = CantTarjetas * PrecioSilver;
                            tarjetaSeleccionadaV = "Silver";
                            break;

                        case "Gold":
                            TotalPagarTarjetas = CantTarjetas * PrecioGold;
                            tarjetaSeleccionadaV = "Gold";
                            break;

                        default:
                            errorProvider1.SetError(cmbTarjetasComprar, "Campo obligatorio");
                            break;
                    }

                    if (tarjetaSeleccionadaV != "")
                    {
                        ValidCliente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre completo del cliente", "Identificación de usuario");
                        ValidDUI = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el DUI completo del cliente\nEjemplo: 00110022-9", "Identificación de usuario");

                        if (ValidCliente == cliente.Nombre && ValidDUI == cliente.NumDui)
                        {
                            //pasarle al objeto cliente el valor de la propiedad Tipo de Tarjeta
                            cliente.TipoTarjeta = tarjetaSeleccionadaV;
                            //crear una tajeta para el cliente
                            Tarjeta tarjetaParaCliente = new Tarjeta();
                            tarjetaParaCliente.TipoTarjeta = cliente.TipoTarjeta;

                            //establecer el limite del saldo de la tarjeta, saldo actual, fecha de apertura, vencimiento,etc
                            tarjetaParaCliente.EstablecerValoresPorTipoTarjeta();

                            
                            MessageBox.Show($"Cliente:{ValidCliente}\nDui:{ValidDUI}\nTarjeta seleccionada: {tarjetaParaCliente.TipoTarjeta}\nCantidad de tarjetas: {CantTarjetas}\nEl total a pagar es: ${TotalPagarTarjetas}\nSaldo actual de tarjeta: {tarjetaParaCliente.SaldoActual} $USD\nFecha de apertura: {tarjetaParaCliente.FechaApertura}\nFecha de Vencimiento: {tarjetaParaCliente.FechaVencimiento}\nPuntos Acumulados: {tarjetaParaCliente.PuntosAcum}\nVigente: SI", "Factura");
                            
                        }
                        else
                        {
                            MessageBox.Show("No se encuentran registros del cliente\nTambién debe asegurarse de colocar el DUI con 9 caracteres y un guión\nEjemplo: 00220099-2");
                        }
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtNumTarjetasComprar, "Ingrese solo números enteros");
                }
            }
        }
    }
}
