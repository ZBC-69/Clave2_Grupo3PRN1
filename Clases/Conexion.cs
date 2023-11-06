using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave2_Grupo.Clases
{
    class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "clave2_grupo3_";
        static string usuario = "root";
        static string password = "root";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        //creando metodo

        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Conexion exitosa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar la conexion, error: " + ex.ToString());
            }
            return conexion;
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
    
