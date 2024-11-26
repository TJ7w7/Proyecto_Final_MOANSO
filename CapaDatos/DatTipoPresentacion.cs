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
    public class DatTipoPresentacion
    {
        private static DatTipoPresentacion _instancia = new DatTipoPresentacion();
        public static DatTipoPresentacion Instancia
        {
            get { return _instancia; }
        }
        public List<EntTipoPresentacion> ListarTipoPresentacion(int productoid)
        {

            SqlCommand cmd = null;
            List<EntTipoPresentacion> lista = new List<EntTipoPresentacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarTipoPresentacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productoId",productoid);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoPresentacion P = new EntTipoPresentacion();
                    P.TipoPresentacionId = Convert.ToInt32(dr["TipoPresentacionId"]);
                    P.ProductoId = Convert.ToInt32(dr["ProductoId"]);
                    P.TipoPresentacion = dr["TipoPresentacion"].ToString();
                    P.Stock = Convert.ToInt32(dr["Stock"]);
                    P.PrecioConIGV = Convert.ToInt32(dr["PrecioConIGV"]);
                    P.PrecioSinIGV = Convert.ToInt32(dr["PrecioSinIGV"]);
                    P.Peso = Convert.ToDecimal(dr["Peso"]);
                    P.Largo = Convert.ToDecimal(dr["Largo"]);
                    P.Ancho = Convert.ToDecimal(dr["Ancho"]);
                    P.Alto = Convert.ToDecimal(dr["Alto"]);
                    P.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(P);
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
        public Boolean InsertarTipoPresentacion(EntTipoPresentacion P)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarTipoPresentacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productoId", P.ProductoId);
                cmd.Parameters.AddWithValue("@tipoPresentacion", P.TipoPresentacion);
                cmd.Parameters.AddWithValue("@stock", P.Stock);
                cmd.Parameters.AddWithValue("@precioConIGV", P.PrecioConIGV);
                cmd.Parameters.AddWithValue("@precioSinIGV", P.PrecioSinIGV);
                cmd.Parameters.AddWithValue("@peso", P.Peso);
                cmd.Parameters.AddWithValue("@largo", P.Largo);
                cmd.Parameters.AddWithValue("@ancho", P.Ancho);
                cmd.Parameters.AddWithValue("@alto", P.Alto);
                cmd.Parameters.AddWithValue("@estado", P.Estado);
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
        //public Boolean EditarTipoPresentacion(EntTipoPresentacion P)
        //{
        //    SqlCommand cmd = null;
        //    Boolean edita = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("EditarProducto", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id", P.ProductoId);
        //        cmd.Parameters.AddWithValue("@codigo", P.Codigo);
        //        cmd.Parameters.AddWithValue("@marcaId", P.MarcaId);
        //        cmd.Parameters.AddWithValue("@categoriaId", P.CategoriaId);
        //        cmd.Parameters.AddWithValue("@saboresId", P.SaboresId);
        //        cmd.Parameters.AddWithValue("@descripcion", P.Descripcion);
        //        cmd.Parameters.AddWithValue("@imagen", P.Imagen);
        //        cmd.Parameters.AddWithValue("@estado", P.Estado);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            edita = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        cmd.Connection.Close();
        //    }
        //    return edita;
        //}
    }
}
