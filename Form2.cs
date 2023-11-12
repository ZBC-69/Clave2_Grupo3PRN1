using System;
using System.Windows.Forms;

namespace Clave2_Grupo
{
    public partial class fmrNuevoCliente : Form
    {

        //objeto para validar informacion
        Metodos validDat = new Metodos();
        private bool btnAddClicked = false;
        //Instanciación de la clase Cliente para guardar la información en sus propiedad nombre y DUI
        Cliente cliente = new Cliente();
        public fmrNuevoCliente()
        {
            //Inicialización del datagridview de prueba para verificar el registro
            InitializeComponent();
            dgvRegistroClientes.Columns.Add("Documento Unico de Identidad", "DUI");
            dgvRegistroClientes.Columns.Add("Nombre completo del cliente", "Nombre Completo");

            //Llamando la clase RegistroCliente
            Clases.Empleado objRegistro = new Clases.Empleado();//permitirá el registro de nombre y dui del cliente
        }

        /// <summary>
        /// Permite el ingreso de solo teclas de tipo Letra. Muestra sms de eror al detectar datos no válidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNomCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validDat.ValidarTextBoxSoloLetrasKeyPress(sender, e);
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Las variables "validDUI, validNOM" sirven para dar luz verde al programa si y solo si todas las validaciones son correctas
        bool validDUI = false;
        bool validNOM = false;

        /// <summary>
        /// Evento condicionado: Se activa unicamente si el usuario ingresa un formato incorrecto en el DUI
        /// </summary>
        /// <remarks>Mediante un error provider se muestra un mensaje indicando que solo deben ingresarse números</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msktxtDUI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(mskDUI, "Solo puede ingresar números");
            validDUI = false;
        }


        /// <summary>
        /// Botón que permite guardar en la base de datos la información dui y nombre de un cliente luego de validar el ingreso de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Validación para campos vacios o incompletos
            if (txtNombre.Text == string.Empty)
            {
                errorProvider1.SetError(txtNombre, "Campo obligatorio");
                validNOM = false;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
                validNOM = true;
            }
            mskDUI.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mskDUI.Text == string.Empty || mskDUI.MaskCompleted == false)
            {
                errorProvider1.SetError(mskDUI, "Campo obligatorio, Ingrese DUI completo");
                validDUI = false;
            }
            else
            {
                errorProvider1.SetError(mskDUI, "");
                validDUI = true;
            }
            // Acciones a realizar si todas las validaciones han sido superadas exitosamente
            if (validDUI == true && validNOM == true)
            {

                cliente.Nombre = txtNombre.Text;
                cliente.NumDui = mskDUI.Text;
                if (cliente.NumDui.Length > 1)
                {
                    // Insertar un guion antes del último dígito del DUI 
                    cliente.NumDui = cliente.NumDui.Insert(cliente.NumDui.Length - 1, "-");
                }

                //PROVICIONAL; solo para comprobar la validación del registro
                dgvRegistroClientes.Rows.Clear();
                dgvRegistroClientes.Rows.Add(cliente.NumDui, cliente.Nombre);//agrega datos a la tabla
                MessageBox.Show("El usuario ha sido registrado");
                MessageBox.Show(cliente.NumDui);


                Clases.Empleado objetoCliente = new Clases.Empleado();
                objetoCliente.registrarClientes(cliente.NumDui, cliente.Nombre);
                btnAddClicked = true; //permitirá que el  botón btnIrAcompras abra el formulario de Tarjetas (con ello nos aseguramos de que se realizó un registro)
            }

        }

        /// <summary>
        /// Bóton que permite ir al formulario de compras de tarjetas una vez se han llenado los campos de dui y nommbre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIrACompras_Click(object sender, EventArgs e)
        {
            //se abrirá el formulario de venta de tarjetas solo si se llevó a cabo un registro en el formulario de Nuevo Cliente.
            if (btnAddClicked)
            {
                //validar datos nulos o vacíos.
                if (validarDatosVacios())
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
                MessageBox.Show("Debe hacer clic en el botón 'Registrar' antes de abrir el formulario de ventas de tarjetas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }



        private void LimpiarDatos()
        {
            dgvRegistroClientes.Rows.Clear();
            txtNombre.Clear();
            mskDUI.Clear();
            errorProvider1.Clear();
            validDUI = false;
            validNOM = false;
            btnAddClicked = false;
        }

        /// <summary>
        /// valida la información de los datos nombres y dui del cliente y que no estén vacíos.
        /// </summary>
        /// <returns>True si los datos son correctos, Falso si son</returns>
        private bool validarDatosVacios()
        {
            if (!string.IsNullOrWhiteSpace(cliente.NumDui) && !string.IsNullOrEmpty(cliente.Nombre) && !string.IsNullOrWhiteSpace(mskDUI.Text) && mskDUI.MaskCompleted)
            {
                //los datos no son nulos. Los datos están bien.
                return true;            
            }
            return false;
        }

    }
}
    
