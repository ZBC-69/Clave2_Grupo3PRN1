using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Clave2_Grupo
{
    class Conexion
    {
       public static MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=1234;database=Clave2_Grupo3;Sslmode = none;");
    
        public static void ProbarConexion()
        {
            try
            {
                conexion.Open();
                _ = MessageBox.Show("Conexion Exitosa");
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
