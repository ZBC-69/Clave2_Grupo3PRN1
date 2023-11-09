﻿using MySql.Data.MySqlClient;
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
         public static void mostrarHistorialClientes(DataGridView tablaClientes)
         {
             try
             {
                 Conexion objetoConexion = new Conexion();

                //String query = "SELECT * FROM tarjeta"; //ANTES solo se mostraban los datos de la tarjeta sin el name del cliente
                string query = "SELECT cliente.Nombre, tarjeta.* " +
               "FROM tarjeta " +
               "INNER JOIN cliente ON tarjeta.DUI = cliente.DUI " +
               "ORDER BY cliente.Nombre";
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


        public void guardarOtrosDatos(string DUI, string codTarjeta, string tipoTarjet, double credito, string fVence, string fApertura,string vigente)
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

    }
}
