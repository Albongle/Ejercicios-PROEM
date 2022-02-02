using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Entidades
{
    public static class GestorSQL
    {
        private static string conexion;
        static GestorSQL()
        {
            GestorSQL.conexion = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
        }



        public static Cliente GetClienteById(int id)
        {

            string sentencia = "SELECT * FROM CLIENTES WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.conexion))
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("id", id);
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlDataReader reader = command.ExecuteReader();

                return reader.Read() == false ? throw new Exception("Cliente no encontrado") : new Cliente(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
            }
        }
        public static List<Cliente> GetClientes()
        {
            List<Cliente> returnCliente = new List<Cliente>();

            string sentencia = "SELECT * FROM CLIENTES";
            using (SqlConnection connection = new SqlConnection(GestorSQL.conexion))
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente(reader.GetInt32(0), reader.GetString(1),
                        reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                    returnCliente.Add(cliente);
                }
            }

            return returnCliente;
        }


        public static void AddCliente(Cliente cliente)
        {

            string sentencia = "INSERT INTO CLIENTES (nombre,apellido, direccion, telefono) VALUES (@nombre,@apellido,@direccion,@telefono)"; ;
            using (SqlConnection connection = new SqlConnection(GestorSQL.conexion))
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                command.Parameters.AddWithValue("nombre", cliente.Nombre);
                command.Parameters.AddWithValue("apellido", cliente.Apellido);
                command.Parameters.AddWithValue("direccion", cliente.Direccion);
                command.Parameters.AddWithValue("telefono", cliente.Telefono);
                command.ExecuteNonQuery();
            }
        }


        public static bool EditCliente(Cliente cliente)
        {

            if (cliente is not null)
            {

                string sentencia = "UPDATE CLIENTES SET nombre=@nombre," +
                    " apellido=@apellido, direccion=@direccion, telefono=@telefono" +
                    " WHERE id=@id";
                using (SqlConnection connection = new SqlConnection(GestorSQL.conexion))
                {
                    SqlCommand command = new SqlCommand(sentencia, connection);
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command.Parameters.AddWithValue("id", cliente.Id);
                    command.Parameters.AddWithValue("nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("direccion", cliente.Direccion);
                    command.Parameters.AddWithValue("telefono", cliente.Telefono);
                    command.ExecuteNonQuery();
                    return true;
                }


            }

            throw new Exception("No se recibio el cliente a Editar");
        }


        public static bool DeleteCliente (int id)
        {
            bool returnAux = false;
            string sentencia = "DELETE FROM [.NET-PROEM].DBO.clientes WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.conexion))
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("id", id);
                if(connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open (); 
                }

                command.ExecuteNonQuery (); 

                returnAux = true;   
                return returnAux;
            }
        }
    }
}
