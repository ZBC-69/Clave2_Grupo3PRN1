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
    class Empleado
    {
        //creando metodo para mostrar los clientes 
        public static void mostrarHistorialClientes(DataGridView tablaClientes)
        {
            try
            {
                Conexion objetoConexion = new Conexion();

                String query = "SELECT cliente.Nombre, tarjeta.* " + //llamando todos los datos de la base
                "FROM tarjeta " +
                "INNER JOIN cliente ON tarjeta.DUI = cliente.DUI " +
                "ORDER BY cliente.Nombre";
                tablaClientes.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaClientes.DataSource = dt;

                // Asegúrate de que la DataGridView tenga al menos una columna
                // Asegúrate de que la DataGridView tenga al menos una columna
                if (tablaClientes.Columns.Count > 1)  // Verifica si hay al menos dos columnas
                {
                    // Ajusta el ancho de la segunda columna (índice 1)
                    tablaClientes.Columns[1].Width = 160;  // Ajusta el ancho según tus necesidades
                    tablaClientes.Columns[8].Width = 50;  // Ajusta el ancho según tus necesidades
                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se registraron los datos de la base de datos, error: " + ex.ToString());
            }
        }

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


        public void guardarOtrosDatos(string DUI, string codTarjeta, string tipoTarjet, double credito, string fVence, string fApertura, string vigente)
        {
            try
            {
                Conexion objetoConexion = new Conexion();

                String query = "insert into tarjeta (DUI, CodTarjeta, Tipo, Credito_Disponible, fecha_vencimiento, fecha_Apertura, Estado)" +
                "values ('" + DUI + "','" + codTarjeta + "','" + tipoTarjet + "','" + credito + "','" + fVence + "','" + fApertura + "','" + vigente + "');";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se guardaron los demás datos del cliente");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró guardar la información, error: " + ex.ToString());
            }
        }


        ///====================POSIBLE MÉTODO PARA ACTUALIZAR LOS DATOS DE LA BASE DE DATOS
        ///
        public void ActualizarDatosd(TextBox Nombre, TextBox Dui)
        {
            //Clases.Conexion objetoConexion = new Clases.Conexion();

            try
            {
                using (Clases.Conexion objetoConexion = new Clases.Conexion())
                {
                    string query = "UPDATE cliente SET Nombre=@Nombre WHERE DUI=@DUI";
                    MySqlCommand cmdCliente = new MySqlCommand(query, objetoConexion.establecerConexion());
                    cmdCliente.Parameters.AddWithValue("@Nombre", Nombre.Text);
                    cmdCliente.Parameters.AddWithValue("@DUI", Dui.Text);

                    // Ejecutas la actualización
                    int rowsAffected = cmdCliente.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se modificó correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para actualizar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizaron los datos de la base de datos, error: " + ex.ToString());
            }
        }



        public void SeleccionarAlumnos(DataGridView tablAlumnitos, TextBox nombre, TextBox Dui)
        {
            try
            {
                nombre.Text = tablAlumnitos.CurrentRow.Cells[1].Value.ToString();
                Dui.Text = tablAlumnitos.CurrentRow.Cells[2].Value.ToString();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lograr seleccionar, error: " + ex.ToString());
            }
        }

        public void EliminarRegistros(string dui)
        {
            try
            {
                Clases.Conexion objetoConexion = new Clases.Conexion();
                string queryTarjeta = "DELETE FROM tarjeta WHERE DUI = @DUI";
                string queryCliente = "DELETE FROM cliente WHERE DUI = @DUI";

                using (MySqlConnection conexion = objetoConexion.establecerConexion())
                {
                    using (MySqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            // Primero, eliminamos los registros de la tabla "tarjeta"
                            MySqlCommand cmdTarjeta = new MySqlCommand(queryTarjeta, conexion, transaccion);
                            cmdTarjeta.Parameters.AddWithValue("@DUI", dui);
                            int rowsAffectedTarjeta = cmdTarjeta.ExecuteNonQuery();

                            // Después iremos a eliminar el registro de la tabla "cliente"
                            MySqlCommand cmdCliente = new MySqlCommand(queryCliente, conexion, transaccion);
                            cmdCliente.Parameters.AddWithValue("@DUI", dui);
                            int rowsAffectedCliente = cmdCliente.ExecuteNonQuery();

                            // Completamos la transacción si ambas eliminaciones se realizaron
                            transaccion.Commit();

                            if (rowsAffectedCliente > 0)
                            {
                                MessageBox.Show("Se eliminó el registro con éxito");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro para eliminar");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Ocurrió un error, revertimos la transacción
                            transaccion.Rollback();
                            MessageBox.Show("Error al eliminar registros: " + ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se eliminaron los datos de la base de datos, error: " + ex.ToString());
            }
        }
    }
    
}
