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
    public partial class fmrNuevoCliente : Form
    {
        //objeto para validar informaciones
        Metodos validDat = new Metodos();
        private bool btnAddClicked = false;
        //Instanciación de la clase Cliente para guardar la información en sus propiedad nombre y DUI
        Cliente cliente = new Cliente();
        public fmrNuevoCliente()
        {
            //Inicialización del datagridview de prueba para verificar el registro
            InitializeComponent();
            dgvAddClientePrueba.Columns.Add("Documento Unico de Identidad", "DUI");
            dgvAddClientePrueba.Columns.Add("Nombre completo del cliente", "Nombre Completo");
        }


        private void txtNomCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validDat.ValidarTextBoxSoloLetrasKeyPress(sender,e);
        } 

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Las variables "validDUI, validNOM" sirven para dar luz verde al programa si y solo si todas las validaciones son correctas
        bool validDUI = false;
        bool validNOM = false;
        /*Evento condicionado: Se activa unicamente si el usuario ingresa un formato incorrecto en el DUI
       -Mediante un error provider le indica que solo ingrese números
       */
        private void msktxtDUI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(msktxtDUI, "Solo puede ingresar números");
            validDUI = false;
        }
        //Evento cuando se añade un nuevo cliente
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            //Validación para campos vacios o incompletos
            if (txtNomCompleto.Text==string.Empty)
            {
                errorProvider1.SetError(txtNomCompleto, "Campo obligatorio");
                validNOM = false;
            }
            else
            {
                errorProvider1.SetError(txtNomCompleto, "");
                validNOM = true;
            }
            msktxtDUI.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (msktxtDUI.Text ==string.Empty||msktxtDUI.MaskCompleted==false)
            {
                errorProvider1.SetError(msktxtDUI, "Campo obligatorio, Ingrese DUI completo");
                validDUI = false;
            }
            else
            {
                errorProvider1.SetError(msktxtDUI, "");
                validDUI = true;
            }
            // Acciones a realizar si todas las validaciones han sido superadas exitosamente
            if (validDUI==true&&validNOM==true)
            {
                                             
                cliente.Nombre = txtNomCompleto.Text;
                cliente.NumDui = msktxtDUI.Text;
                if (cliente.NumDui.Length > 1)
                {
                    // Insertar un guion antes del último dígito del DUI 
                    cliente.NumDui = cliente.NumDui.Insert(cliente.NumDui.Length - 1, "-");
                }
                
                //PROVICIONAL; solo para comprobar la validación del registro
                dgvAddClientePrueba.Rows.Clear();
                dgvAddClientePrueba.Rows.Add(cliente.NumDui, cliente.Nombre);
                MessageBox.Show("El usuario ha sido registrado");
                MessageBox.Show(cliente.NumDui);
                btnAddClicked = true;
                //txtNomCompleto.Clear();
                //msktxtDUI.Text = "";
            }
 
        }

        /// <summary>
        /// Bóton que permite ir al formulario de compras de tarjetas una vez se han llenado los campos de dui y nommbre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIrACompras_Click(object sender, EventArgs e)
        {
            if (btnAddClicked)
            {
                if (!string.IsNullOrWhiteSpace(txtNomCompleto.Text) && !string.IsNullOrEmpty(txtNomCompleto.Text) && !string.IsNullOrWhiteSpace(msktxtDUI.Text) && msktxtDUI.MaskCompleted)
                {
                    
                    // Crear una instancia del formulario fmrVenderTarjetas y pasar el objeto Cliente para que el otro formulario trabaje a partir del DUI Y nombre del cliente que aquí hemos registrado
                    fmrVenderTarjetas formVentaTarjetas = new fmrVenderTarjetas(cliente);
                    // Abrir el formulario
                    formVentaTarjetas.Show();
                }
                else
                {
                    MessageBox.Show("Error, uno o varios datos están vacíos o el DUI no está completo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Debe hacer clic en el botón 'Agregar' antes de abrir el formulario de ventas de tarjetas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            

        }
    }
    
}
