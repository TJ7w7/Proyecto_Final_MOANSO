using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosClienteBase
    {
        // Singleton
        private static readonly DatosClienteBase _instancia = new DatosClienteBase();
        public static DatosClienteBase Instancia => _instancia;

        // Insertar un cliente base
        public int InsertarClienteBase(Cliente cliente, SqlConnection cn, SqlTransaction transaccion)
        {
            string query = @"
            INSERT INTO Cliente (Direccion, NumeroContacto, Estado)
            OUTPUT INSERTED.ClienteId
            VALUES (@Direccion, @NumeroContacto, @Estado)";
            using (SqlCommand cmd = new SqlCommand(query, cn, transaccion))
            {
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@NumeroContacto", cliente.NumeroContacto);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                return (int)cmd.ExecuteScalar();
            }
        }

        // Modificar un cliente base
        public void ModificarClienteBase(Cliente cliente, SqlConnection cn, SqlTransaction transaccion)
        {
            string query = @"
            UPDATE Cliente
            SET Direccion = @Direccion, NumeroContacto = @NumeroContacto, Estado = @Estado
            WHERE ClienteId = @ClienteId";
            using (SqlCommand cmd = new SqlCommand(query, cn, transaccion))
            {
                cmd.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@NumeroContacto", cliente.NumeroContacto);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar un cliente base
        public void EliminarClienteBase(int clienteId, SqlConnection cn, SqlTransaction transaccion)
        {
            string query = "DELETE FROM Cliente WHERE ClienteId = @ClienteId";
            using (SqlCommand cmd = new SqlCommand(query, cn, transaccion))
            {
                cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
