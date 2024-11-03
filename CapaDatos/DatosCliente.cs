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
        private static readonly DatosCliente _instancia = new DatosCliente();
        public static DatosCliente Instancia
        {
            get { return _instancia; }
        }

        public DataTable ObtenerTodosLosClientes()
        {

            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = "SELECT ClienteId, BRN_RUC, Nombre, DivisionesAdministrativasId, Direccion, NumeroContacto FROM Cliente";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;

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
        public bool insertarCliente(Cliente cliente)
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
        public bool ModificarCliente(Cliente cliente)
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
    }
}
