﻿using System.Windows.Forms;

namespace Clave2_Grupo
{
    public class Metodos
    {
        /// <summary>
        /// Método que valida que solo se ingresen letras en un TextBox (en el evento KeyPress)
        /// </summary>
        /// <remarks>Muestra un error si se digitan teclas numericas o simbolos.
        /// Las teclas space, back y letras son validas.
        /// </remarks>

        /// <param name="sender">Objeto que envía el evento.</param>
        /// <param name="e">Argumentos del evento KeyPress.</param>
        /// <example>
        /// Ejemplo de uso del método ValidarTextBoxSoloLetrasKeyPress en un formulario de Windows Forms.
        /// </example>
        /// <code>
        /// private void textBox1_KeyPress(object sender, KeyPressEventArgs e) ///  donde textBox1 representa el nombre del texbox que se desea validar
        /// {
        ///     //Invocar el método para que compruebe si solo hay letras
        ///     ValidarTextBoxSoloLetrasKeyPress(sender, e);
        /// }
        /// </code>
        public void ValidarTextBoxSoloLetrasKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                //La tecla es un simbolo o numero, falso para evitar que se guarde
                e.Handled = true;
                MessageBox.Show("Usted no debe escribir números ni símbolos. Debe digitar solo letras para el nombre y apellido", "Error, no se permiten números ni simbolos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        // Declarar una variable estática para fmrActivo
        private static Form fmrActivo = null;

        /// <summary>
        /// Método que permite abrir formularios dentro de otros formularios mayores o principales
        /// </summary>
        /// <param name="fmrCualquiera"></param>
        public static void AbrirDiferentesFormularios(Form fmrCualquiera, Panel panelContenedor)
        {
            if (fmrActivo != null)
            {
                fmrActivo.Close();
            }
            fmrActivo = fmrCualquiera;
            fmrCualquiera.TopLevel = false;
            fmrCualquiera.FormBorderStyle = FormBorderStyle.None;
            fmrCualquiera.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fmrCualquiera);
            panelContenedor.Tag = fmrCualquiera;
            fmrCualquiera.BringToFront();
            fmrCualquiera.Show();
        }

        // Resto de los métodos de la clase Metodos
    }
}
