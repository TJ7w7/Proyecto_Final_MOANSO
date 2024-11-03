using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class DatosCliente
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=DB_SistemaVenta;Integrated Security=True;";

        public DataTable ObtenerTodosLosClientes()
        {
            string query = "SELECT clienteId, BRN, Nombre, Direccion FROM Cliente";
            DataTable tabla = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(tabla);
            }
            return tabla;
        }
        public DataTable BuscarClienteBRN(string brn)
        {
            string query = "Select clienteId,BRN, Nombre, Direccion FROM Cliente where BRN = @BRN";
            DataTable tabla = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BRN", brn);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(tabla);
                }
            }
            return tabla;
        }
        public void insertarCliente(Cliente cliente)
        {
            string query = "INSERT INTO Cliente (BRN, Nombre, Direccion) VALUES (@BRN, @Nombre, @Direccion)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection)) 
            {
                command.Parameters.AddWithValue("@BRN", cliente.BRN);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void ModificarCliente(Cliente cliente)
        {
            string query = "UPDATE Cliente SET BRN = @BRN, Nombre = @Nombre, Direccion = @Direccion WHERE clienteId = @clienteId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BRN", cliente.BRN);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@clienteId", cliente.clienteId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarCliente(int clienteId)
        {
            string query = "DELETE FROM Cliente WHERE ClienteId = @ClienteId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@clienteId", clienteId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
