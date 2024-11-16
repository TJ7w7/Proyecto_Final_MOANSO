using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatSabores
    {
        private static DatSabores _instancia = new DatSabores();
        public static DatSabores Instancia
        {
            get { return _instancia; }
        }

        public List<EntSabores> listarSabores()
        {

            SqlCommand cmd = null;
            List<EntSabores> lista = new List<EntSabores>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarSabores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntSabores Sab = new EntSabores();
                    Sab.SaboresId = Convert.ToInt32(dr["SaboresId"]);
                    Sab.Nombre = dr["Nombre"].ToString();
                    Sab.Descripcion = dr["Descripcion"].ToString();
                    Sab.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Sab);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarSabores(EntSabores Sab)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarSabores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Sab.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", Sab.Descripcion);
                cmd.Parameters.AddWithValue("@estado", Sab.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        public Boolean EditarSabores(EntSabores Sab)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarSabores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Sab.SaboresId);
                cmd.Parameters.AddWithValue("@nombre", Sab.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", Sab.Descripcion);
                cmd.Parameters.AddWithValue("@estado", Sab.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }
    }
}
