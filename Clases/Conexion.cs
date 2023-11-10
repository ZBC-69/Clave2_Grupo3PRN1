using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave2_Grupo.Clases
{
    public class Conexion : IDisposable
    {
        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "Clave2_Grupo3_";
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Liberar recursos administrados
                if (conexion != null)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            // Liberar recursos no administrados
        }
    }
}
    
