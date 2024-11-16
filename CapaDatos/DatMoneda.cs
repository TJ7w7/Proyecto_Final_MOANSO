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
    public class DatMoneda
    {
        private static DatMoneda _instancia = new DatMoneda();
        public static DatMoneda Instancia
        {
            get { return _instancia; }
        }

        public List<EntMoneda> listarMoneda()
        {

            SqlCommand cmd = null;
            List<EntMoneda> lista = new List<EntMoneda>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarMoneda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntMoneda Mon = new EntMoneda();
                    Mon.MonedaId = Convert.ToInt32(dr["MonedaId"]);
                    Mon.CodigoISO = dr["CodigoISO"].ToString();
                    Mon.Nombre = dr["Nombre"].ToString();
                    Mon.TasaCambio = Convert.ToDecimal(dr["TasaCambio"]);
                    Mon.FechaActualizacion = Convert.ToDateTime(dr["FechaActualizacion"]);
                    Mon.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Mon);
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

        public Boolean InsertarMoneda(EntMoneda Mon)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarMoneda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoISO", Mon.CodigoISO);
                cmd.Parameters.AddWithValue("@nombre", Mon.Nombre);
                cmd.Parameters.AddWithValue("@tasaCambio", Mon.TasaCambio);
                cmd.Parameters.AddWithValue("@fechaActualizacion", Mon.FechaActualizacion);
                cmd.Parameters.AddWithValue("@estado", Mon.Estado);
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
        public Boolean EditarMoneda(EntMoneda Mon)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarMoneda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Mon.MonedaId);
                cmd.Parameters.AddWithValue("@codigoISO", Mon.CodigoISO);
                cmd.Parameters.AddWithValue("@nombre", Mon.Nombre);
                cmd.Parameters.AddWithValue("@tasaCambio", Mon.TasaCambio);
                cmd.Parameters.AddWithValue("@fechaActualizacion", Mon.FechaActualizacion);
                cmd.Parameters.AddWithValue("@estado", Mon.Estado);
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
