namespace Clave2_Grupo
{
    public class Cliente
    {
        private string nombre;  //
        private string numDui;  //   
        private string tipoTarjeta;


        //metodos Setters y Getters para la propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NumDui
        {
            get { return numDui; }
            set { numDui = value; }
        }

        public string TipoTarjeta
        {
            get { return tipoTarjeta; }
            set { tipoTarjeta = value; }
        }
        public bool VerificarNombreVacio()
        {
            if (string.IsNullOrEmpty(nombre))
            {
                //esta vacio
                return false;
            }
            else
            {   
                //tiene datos
                return true;
            }
        }



    }
}
