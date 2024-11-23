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
    public class DatPrecioTransporte
    {
        private static DatPrecioTransporte _instancia = new DatPrecioTransporte();
        public static DatPrecioTransporte Instancia
        {
            get { return _instancia; }
        }
        public List<EntPrecioTransporte> ListarPrecioTransporte()
        {

            SqlCommand cmd = null;
            List<EntPrecioTransporte> lista = new List<EntPrecioTransporte>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarPrecioTransporte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPrecioTransporte Pt = new EntPrecioTransporte();
                    Pt.PrecioTransporteId = Convert.ToInt32(dr["PrecioTransporteId"]);
                    Pt.EmpresaId = Convert.ToInt32(dr["EmpresaId"]);
                    Pt.Empresa = dr["Empresa"].ToString();
                    Pt.TipoTransporte = dr["TipoTransporte"].ToString();
                    //Pt.OrigenPaisId = Convert.ToInt32(dr["OrigenPaisId"]);
                    //Pt.OrigenPais = dr["OrigenPais"].ToString();
                    Pt.OrigenRegionId = Convert.ToInt32(dr["OrigenRegionId"]);
                    Pt.OrigenRegion = dr["OrigenRegion"].ToString();
                    //Pt.DestinoPaisId = Convert.ToInt32(dr["DestinoPaisId"]);
                    //Pt.DestinoPais = dr["DestinoPais"].ToString();
                    Pt.DestinoRegionId = Convert.ToInt32(dr["DestinoRegionId"]);
                    Pt.DestinoRegion = dr["DestinoRegion"].ToString();
                    Pt.MonedaId = Convert.ToInt32(dr["MonedaId"]);
                    Pt.Moneda = dr["Moneda"].ToString();
                    Pt.Precio = Convert.ToDecimal(dr["Precio"]);
                    Pt.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Pt);
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

        public Boolean InsertarPrecioTransporte(EntPrecioTransporte Pt)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarPrecioTransporte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empresaTransporteId", Pt.EmpresaId);
                cmd.Parameters.AddWithValue("@tipoTransporte", Pt.TipoTransporte);
                //cmd.Parameters.AddWithValue("@origenPaisId", Pt.OrigenPaisId);
                cmd.Parameters.AddWithValue("@origenRegionId", Pt.OrigenRegionId);
                //cmd.Parameters.AddWithValue("@destinoPaisId", Pt.DestinoPaisId);
                cmd.Parameters.AddWithValue("@destinoRegionId", Pt.DestinoRegionId);
                cmd.Parameters.AddWithValue("@monedaId", Pt.MonedaId);
                cmd.Parameters.AddWithValue("@precio", Pt.Precio);
                cmd.Parameters.AddWithValue("@estado", Pt.Estado);
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

        public Boolean EditarPrecioTransporte(EntPrecioTransporte Pt)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarPrecioTransporte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Pt.PrecioTransporteId);
                cmd.Parameters.AddWithValue("@empresaTransporteId", Pt.EmpresaId);
                cmd.Parameters.AddWithValue("@tipoTransporte", Pt.TipoTransporte);
                //cmd.Parameters.AddWithValue("@origenPaisId", Pt.OrigenPaisId);
                cmd.Parameters.AddWithValue("@origenRegionId", Pt.OrigenRegionId);
                //cmd.Parameters.AddWithValue("@destinoPaisId", Pt.DestinoPaisId);
                cmd.Parameters.AddWithValue("@destinoRegionId", Pt.DestinoRegionId);
                cmd.Parameters.AddWithValue("@monedaId", Pt.MonedaId);
                cmd.Parameters.AddWithValue("@precio", Pt.Precio);
                cmd.Parameters.AddWithValue("@estado", Pt.Estado);
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
