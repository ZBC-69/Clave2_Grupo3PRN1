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

            public void registrarClientes(MaskedTextBox DUI ,TextBox nombre)
            {
                try
                {
                    Conexion objetoConexion = new Conexion();

                String query = "insert into cliente(DUI, Nombre)" +
                "values ('" + DUI.Text + "','" + nombre.Text + "');";

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
