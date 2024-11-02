using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatCliente
    {
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

        public void RegistrarCliente(string brnRuc, string nombre, int divisionesAdministrativasId, string direccion, string numeroContacto)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = "INSERT INTO Cliente (BRN_RUC, Nombre, DivisionesAdministrativasId, Direccion, NumeroContacto) " +
                               "VALUES (@BRN_RUC, @Nombre, @DivisionesAdministrativasId, @Direccion, @NumeroContacto)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@BRN_RUC", brnRuc);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@DivisionesAdministrativasId", divisionesAdministrativasId);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@NumeroContacto", numeroContacto);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
