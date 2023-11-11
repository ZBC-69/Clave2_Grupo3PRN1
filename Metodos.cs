using System.Windows.Forms;

namespace Clave2_Grupo
{
    public class Metodos
    {
        // Declarar una variable estática para fmrActivo
        private static Form fmrActivo = null;


        /// <summary>
        /// Valida  los datos de tipo letra de un objeto TexBox en su evento KeyPress
        /// </summary>
        /// <remarks>Usted debe especificar cual texbox se va a verificar. Devuelve un sms de error si se digita un número, simbolo</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ValidarTextBoxSoloLetrasKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                //La tecla es un simbolo o numero, falso para evitar que se guarde
                e.Handled = true;
                MessageBox.Show("Usted no debe escribir números ni símbolos. Debe digitar solo letras para el nombre y apellido", "Error, no se permiten números ni simbolos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        

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
