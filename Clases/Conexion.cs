using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave2_Grupo.Clases
{
    internal class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "clave2_grupo3";
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
                MessageBox.Show("Conexion Incorrecta, error: " + ex.ToString());
            }
            return conexion;
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
    
