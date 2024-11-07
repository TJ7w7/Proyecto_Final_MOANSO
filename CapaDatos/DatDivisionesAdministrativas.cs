using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatDivisionesAdministrativas
    {
        #region Singleton
        private static readonly DatDivisionesAdministrativas _instancia = new DatDivisionesAdministrativas();
        public static DatDivisionesAdministrativas Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        // Método para obtener las divisiones administrativas
        public List<EntDivisionesAdministrativas> ObtenerDivisionesAdministrativas()
        {
            List<EntDivisionesAdministrativas> lista = new List<EntDivisionesAdministrativas>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = "SELECT DivisionesAdministrativasId, Nombre, CodigoArea, Estado FROM DivisionesAdministrativas";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            EntDivisionesAdministrativas division = new EntDivisionesAdministrativas
                            {
                                DivisionesAdministrativasId = Convert.ToInt32(dr["DivisionesAdministrativasId"]),
                                Nombre = dr["Nombre"].ToString(),
                                CodigoArea = Convert.ToInt32(dr["CodigoArea"]),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            };
                            lista.Add(division);
                        }
                    }
                }
            }
            return lista;
        }

        public bool CambiarEstadoDivision(int id, bool nuevoEstado)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = "UPDATE DivisionesAdministrativas SET Estado = @Estado WHERE DivisionesAdministrativasId = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0; 
                }
            }
        }

        public string ObtenerNombreDivisionPorId(int idDivision)
        {
            string nombreDivision = string.Empty;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = "SELECT Nombre FROM DivisionesAdministrativas WHERE DivisionesAdministrativasId = @id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", idDivision);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nombreDivision = dr["Nombre"].ToString();
                }
                dr.Close();
            }
            return nombreDivision;
        }
    }
}
