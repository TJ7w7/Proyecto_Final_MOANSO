using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class DatCliente
    {
        private static readonly DatCliente _instancia = new DatCliente();
        public static DatCliente Instancia
        {
            get { return _instancia; }
        }

        public DataTable ObtenerClientes()
        {
            DataTable dtClientes = new DataTable();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = "SELECT ClienteId, BRN_RUC, Nombre, DivisionesAdministrativasId, Direccion, NumeroContacto FROM Cliente";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtClientes);
            }
            return dtClientes;
        }

        public DataTable BuscarClienteBRN(string brn)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = "SELECT ClienteId, BRN_RUC, Nombre, DivisionesAdministrativasId, Direccion, NumeroContacto FROM Cliente WHERE BRN_RUC = @BRN_RUC";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@BRN_RUC", brn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }

        public bool RegistrarCliente(EntCliente cliente)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (BRN_RUC, Nombre, DivisionesAdministrativasId, Direccion, NumeroContacto) " +
                                                    "VALUES (@BRN_RUC, @Nombre, @DivisionesAdministrativasId, @Direccion, @NumeroContacto)", cn);
                    cmd.Parameters.AddWithValue("@BRN_RUC", cliente.BRN_RUC);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@DivisionesAdministrativasId", cliente.DivisionesAdministrativasId);
                    cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    cmd.Parameters.AddWithValue("@NumeroContacto", cliente.NumeroContacto);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception("Error al registrar el cliente: " + ex.Message);
            }
        }

        public bool ModificarCliente(EntCliente cliente)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Cliente SET BRN_RUC = @BRN_RUC, Nombre = @Nombre, DivisionesAdministrativasId = @DivisionesAdministrativasId, Direccion = @Direccion, NumeroContacto = @NumeroContacto WHERE ClienteId = @ClienteId", cn);
                    cmd.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);
                    cmd.Parameters.AddWithValue("@BRN_RUC", cliente.BRN_RUC);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@DivisionesAdministrativasId", cliente.DivisionesAdministrativasId);
                    cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    cmd.Parameters.AddWithValue("@NumeroContacto", cliente.NumeroContacto);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el cliente: " + ex.Message);
            }
        }

        public bool EliminarCliente(int clienteId)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE ClienteId = @ClienteId", cn);
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente: " + ex.Message);
            }
        }

        public EntCliente ObtenerClientePorId(int clienteid)
        {
            EntCliente cliente = null;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexion.Instancia.Conectar();
                string query = "SELECT * FROM Cliente WHERE ClienteId = @ClienteId";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ClienteId", clienteid);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    cliente = new EntCliente
                    {
                        ClienteId = Convert.ToInt32(reader["ClienteId"]),
                        BRN_RUC = reader["BRN_RUC"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        DivisionesAdministrativasId = Convert.ToInt32(reader["DivisionesAdministrativasId"]),
                        Direccion = reader["Direccion"].ToString(),
                        NumeroContacto = reader["NumeroContacto"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos del cliente", ex);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return cliente;
        }
    }
}
