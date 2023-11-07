using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave2_Grupo.Clases
{
    class Tarjeta
    {
        //insertar datos del forms VenderTarjetas a la B.D
        public void guardarTarjetas(ComboBox Tarjeta)
        {
            try
            {
                Conexion objetoConexion = new Conexion();

                String query = "insert into tarjeta(Tipo)" +
                "values ('" + Tarjeta.Text + "');";
                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se registro el tipo de tarjeta seleccionada");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se registro el tipo de tarjeta a la base de datos, error: " + ex.ToString());
            }

        }
    }
}
