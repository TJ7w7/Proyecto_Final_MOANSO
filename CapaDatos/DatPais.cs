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
    public class DatPais
    {
        private static DatPais _instancia = new DatPais();
        public static DatPais Instancia
        {
            get { return _instancia; }
        }
        public List<EntPais> listarPais()
        {

            SqlCommand cmd = null;
            List<EntPais> lista = new List<EntPais>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarPais", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPais Pa = new EntPais();
                    Pa.PaisId = Convert.ToInt32(dr["PaisId"]);
                    Pa.Nombre = dr["Nombre"].ToString();
                    Pa.CodigoISO = dr["CodigoIso"].ToString();
                    Pa.CodigoTelefono = dr["CodigoTelefono"].ToString();
                    Pa.MonedaId = Convert.ToInt32(dr["MonedaId"]);
                    Pa.Estado = Convert.ToBoolean(dr["Estado"]);
                    Pa.NombreMoneda = dr["Moneda"].ToString();
                    lista.Add(Pa);
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

        public Boolean InsertarPais(EntPais Pa)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarPais", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Pa.Nombre);
                cmd.Parameters.AddWithValue("@codigoISO", Pa.CodigoISO);
                cmd.Parameters.AddWithValue("@codigoTelefono", Pa.CodigoTelefono);
                cmd.Parameters.AddWithValue("@monedaId", Pa.MonedaId);
                cmd.Parameters.AddWithValue("@estado", Pa.Estado);
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

        public Boolean EditarPais(EntPais Pa)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarPais", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Pa.PaisId);
                cmd.Parameters.AddWithValue("@nombre", Pa.Nombre);
                cmd.Parameters.AddWithValue("@codigoISO", Pa.CodigoISO);
                cmd.Parameters.AddWithValue("@codigoTelefono", Pa.CodigoTelefono);
                cmd.Parameters.AddWithValue("@monedaId", Pa.MonedaId);
                cmd.Parameters.AddWithValue("@estado", Pa.Estado);
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
