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
                //Instantación de la clase Cliente para guardar la información en sus atributos
                Cliente cliente = new Cliente();
                //PROVICIONAL; solo para comprobar la validación del registro
                dgvAddClientePrueba.Rows.Clear();
                dgvAddClientePrueba.Rows.Add(txtNomCompleto.Text, msktxtDUI.Text);
                MessageBox.Show("El usuario ha sido registrado");
            }
 
        }

        
    }
    
}
