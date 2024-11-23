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
    public class DatEmpresaTransporte
    {
        private static DatEmpresaTransporte _instancia = new DatEmpresaTransporte();
        public static DatEmpresaTransporte Instancia
        {
            get { return _instancia; }
        }
        public List<EntEmpresaTransporte> ListarEmpresaTransporte()
        {

            SqlCommand cmd = null;
            List<EntEmpresaTransporte> lista = new List<EntEmpresaTransporte>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarEmpresaTransporte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntEmpresaTransporte ET = new EntEmpresaTransporte();
                    ET.EmpresaTransporteId = Convert.ToInt32(dr["EmpresaTransporteId"]);
                    ET.TipoDocumentoId = Convert.ToInt32(dr["TipoDocumentoId"]);
                    ET.TipoDocumento = dr["TipoDocumento"].ToString();
                    ET.NumeroDocumento = dr["NumeroDocumento"].ToString();
                    ET.RazonSocial =dr["RazonSocial"].ToString();
                    ET.Direccion = dr["Direccion"].ToString();
                    ET.NumeroContacto = dr["NumeroContacto"].ToString();
                    ET.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(ET);
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

        public Boolean InsertarEmpresaTransporte(EntEmpresaTransporte ET)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarEmpresaTransporte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoDocumentoId", ET.TipoDocumentoId);
                cmd.Parameters.AddWithValue("@numeroDocumento", ET.NumeroDocumento);
                cmd.Parameters.AddWithValue("@razonSocial", ET.RazonSocial);
                cmd.Parameters.AddWithValue("@direccion", ET.Direccion);
                cmd.Parameters.AddWithValue("@numeroContacto", ET.NumeroContacto);
                cmd.Parameters.AddWithValue("@estado", ET.Estado);
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

        public Boolean EditarEmpresaTransporte(EntEmpresaTransporte ET)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarEmpresaTransporte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ET.EmpresaTransporteId);
                cmd.Parameters.AddWithValue("@TipoDocumentoId", ET.TipoDocumentoId);
                cmd.Parameters.AddWithValue("@numeroDocumento", ET.NumeroDocumento);
                cmd.Parameters.AddWithValue("@razonSocial", ET.RazonSocial);
                cmd.Parameters.AddWithValue("@direccion", ET.Direccion);
                cmd.Parameters.AddWithValue("@numeroContacto", ET.NumeroContacto);
                cmd.Parameters.AddWithValue("@Estado", ET.Estado);
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
