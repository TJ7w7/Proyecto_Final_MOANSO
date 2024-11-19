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
    public class DatRegion
    {
        private static DatRegion _instancia = new DatRegion();
        public static DatRegion Instancia
        {
            get { return _instancia; }
        }
        public List<EntRegion> ListarRegion()
        {

            SqlCommand cmd = null;
            List<EntRegion> lista = new List<EntRegion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarRegion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntRegion Re = new EntRegion();
                    Re.RegionId = Convert.ToInt32(dr["RegionId"]);
                    Re.PaisId = Convert.ToInt32(dr["PaisId"]);
                    Re.NombrePais = dr["Pais"].ToString();
                    Re.CodigoArea = Convert.ToInt32(dr["CodigoArea"]);
                    Re.Nombre = dr["Nombre"].ToString();
                    Re.Estado = Convert.ToBoolean(dr["Estado"]);
                    Re.Aduana = Convert.ToBoolean(dr["Aduana"]);
                    lista.Add(Re);
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

        public Boolean InsertarRegion(EntRegion Re)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarRegion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@paisId", Re.PaisId);
                cmd.Parameters.AddWithValue("@codigoArea", Re.CodigoArea);
                cmd.Parameters.AddWithValue("@nombre", Re.Nombre);
                cmd.Parameters.AddWithValue("@estado", Re.Estado);
                cmd.Parameters.AddWithValue("@aduana", Re.Aduana);
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

        public Boolean EditarRegion(EntRegion Re)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarRegion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Re.RegionId);
                cmd.Parameters.AddWithValue("@paisId", Re.PaisId);
                cmd.Parameters.AddWithValue("@codigoArea", Re.CodigoArea);
                cmd.Parameters.AddWithValue("@nombre", Re.Nombre);
                cmd.Parameters.AddWithValue("@estado", Re.Estado);
                cmd.Parameters.AddWithValue("@aduana", Re.Aduana);
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
