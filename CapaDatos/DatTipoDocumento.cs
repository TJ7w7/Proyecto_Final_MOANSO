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
    public class DatTipoDocumento
    {
        private static DatTipoDocumento _instancia = new DatTipoDocumento();
        public static DatTipoDocumento Instancia
        {
            get { return _instancia; }
        }

        public List<EntTipoDocumento> listarTipoDocumento()
        {
            SqlCommand cmd = null;
            List<EntTipoDocumento> lista = new List<EntTipoDocumento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarTipoDocumento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoDocumento Tp = new EntTipoDocumento();
                    Tp.TipoDocumentoId = Convert.ToInt32(dr["TipoDocumentoId"]);
                    Tp.Nombre = dr["Nombre"].ToString();
                    Tp.LongitudExacta = Convert.ToBoolean(dr["LongitudExacta"]);
                    Tp.LongitudMinima = Convert.ToInt32(dr["LongitudMinima"]);
                    Tp.LongitudMaxima = Convert.ToInt32(dr["LongitudMaxima"]);
                    Tp.Alfanumerico = Convert.ToBoolean(dr["Alfanumerico"]);
                    Tp.ClienteJuridico = Convert.ToBoolean(dr["ClienteJuridico"]);
                    Tp.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Tp);
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

        public Boolean InsertarTipoDocumento(EntTipoDocumento Tp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarTipoDocumento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Tp.Nombre);
                cmd.Parameters.AddWithValue("@longitudExacta", Tp.LongitudExacta);
                cmd.Parameters.AddWithValue("@longitudMinima", Tp.LongitudMinima);
                cmd.Parameters.AddWithValue("@longitudMaxima", Tp.LongitudMaxima);
                cmd.Parameters.AddWithValue("@alfanumerico", Tp.Alfanumerico);
                cmd.Parameters.AddWithValue("@clienteJuridico", Tp.ClienteJuridico);
                cmd.Parameters.AddWithValue("@estado", Tp.Estado);
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

        public Boolean EditarTipoDocumento(EntTipoDocumento Tp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarTipoDocumento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Tp.TipoDocumentoId);
                cmd.Parameters.AddWithValue("@nombre", Tp.Nombre);
                cmd.Parameters.AddWithValue("@longitudExacta", Tp.LongitudExacta);
                cmd.Parameters.AddWithValue("@longitudMinima", Tp.LongitudMinima);
                cmd.Parameters.AddWithValue("@longitudMaxima", Tp.LongitudMaxima);
                cmd.Parameters.AddWithValue("@alfanumerico", Tp.Alfanumerico);
                cmd.Parameters.AddWithValue("@clienteJuridico", Tp.ClienteJuridico);
                cmd.Parameters.AddWithValue("@estado", Tp.Estado);
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
