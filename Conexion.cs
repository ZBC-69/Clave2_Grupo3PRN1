using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Clave2_Grupo
{
     class Conexion
    {
       public static MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;port=3306;user=root;pwd=1234;database=Clave2_Grupo3;");
    
        public static void ProbarConexion()
        {
            try
            {
                conexion.Open();
                 MessageBox.Show("Conexion Exitosa");
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { conexion.Close(); }
        }
    }
}
