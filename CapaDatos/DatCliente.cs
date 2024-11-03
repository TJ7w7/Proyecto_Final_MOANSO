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
    }
}
