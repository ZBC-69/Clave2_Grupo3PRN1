using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave2_Grupo.Clases
{
    class RegistroCliente
    {
        //creando metodo para mostrar los clientes 
        /* public void mostrarClientes(DataGridView tablaClientes)
         {
             try
             {
                 Conexion objetoConexion = new Conexion();

                 String query = "SELECT * FROM cliente";
                 tablaClientes.DataSource = null;
                 MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                 DataTable dt = new DataTable();
                 adapter.Fill(dt);
                 tablaClientes.DataSource = dt;
                 objetoConexion.cerrarConexion();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No se registraron los datos de la base de datos, error: " + ex.ToString());
             }
         }*/

        /// <summary>
        /// Permite agregar datos de un nuevo usuario a la base de datos (Dui, Nombre)
        /// </summary>
        /// <param name="DUI">el número de dui del cliente</param>
        /// <param name="nombre">El nombre del cliente a registrar</param>
        public void registrarClientes(string DUI, string nombre)
        {
            try
            {
                Conexion objetoConexion = new Conexion();

                String query = "insert into cliente(DUI, Nombre)" +
                "values ('" + DUI + "','" + nombre + "');";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se guardo correctamente los registros en la base de datos");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se registraron los datos de la base de datos, error: " + ex.ToString());
            }
        }

            

            
    }
}
