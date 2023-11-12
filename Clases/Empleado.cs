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

        /// <summary>
        /// Muestra en un DataGridView los datos almacenados en la base de datos 
        /// </summary>
        /// <param name="tablaClientes">El nombre del DataGridView donde quieras que se muestre toda la informacion de la base</param>
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

                
                if (tablaClientes.Columns.Count > 1)  // Verifica si hay al menos dos columnas
                {
                    // Ajusta el ancho de la segunda columna (índice 1)
                    tablaClientes.Columns[1].Width = 160;  // Ajusta el ancho según tus necesidades
                    tablaClientes.Columns[8].Width = 50;  // Ajusta el ancho según tus necesidades
                }
                //cerrar la conexión con la base.
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se registraron los datos de la base de datos, error: " + ex.ToString());
            }
        }


        /// <summary>
        /// Envía la información a la base de datos
        /// </summary>
        /// <remarks>Registra y guarda los datos "DUI" y "Nombre" de un cliente</remarks>
        /// <param name="DUI">El texto dui capturado en el texbox</param>
        /// <param name="nombre">El texto nombre capturado en el texbox</param>
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

        /// <summary>
        /// Guarda en la base el resto de información de un cliente (datos de tarjeta y su Dui)
        /// </summary>
        /// <param name="DUI">Dui del cliente</param>
        /// <param name="codTarjeta">El código de la tarjeta de para el cliente</param>
        /// <param name="tipoTarjet">El tipo de tarjeta del cliente (Plus, Gold, Silver)</param>
        /// <param name="credito">El saldo de la tarjeta</param>
        /// <param name="fVence">fecha de vencimiento</param>
        /// <param name="fApertura">fecha de compra de la tarjeta</param>
        /// <param name="vigente">estado de la tarjeta</param>
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


        /// <summary>
        /// Actualiza el Dui y Nombre de un cliente específico de una tabla DataGridView
        /// </summary>
        /// <remarks>Se actualizan los datos en la tabla y en la base de datos</remarks>
        /// <param name="Nombre">Nombre del cliente</param>
        /// <param name="Dui">Número de DUI</param>
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


        /// <summary>
        /// Permite trasladar a dos texbox especificados, la información texto de dos celdas de un dataGridView
        /// </summary>
        /// <remarks>Solo se traslada el texto del índice de columna 1 y 2 del DataDridView Específicado</remarks>
        /// <param name="Mostrador">El nombre de la tabla que esté mostrando los registros de clientes de la base de datos</param>
        /// <param name="nombre">El nombre del cliente</param>
        /// <param name="Dui">El dui de un cliente</param>
        public void SeleccionarAlumnos(DataGridView Mostrador, TextBox nombre, TextBox Dui)
        {
            try
            {
                nombre.Text = Mostrador.CurrentRow.Cells[1].Value.ToString();
                Dui.Text = Mostrador.CurrentRow.Cells[2].Value.ToString();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lograr seleccionar, error: " + ex.ToString());
            }
        }


        /// <summary>
        /// Elimina en la base de datos todos los datos de registro para un cliente especificado por DUI
        /// </summary>
        /// <param name="dui">El dui del cliente</param>
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
                                //es probable que un registro no exista en la base de datos.
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
