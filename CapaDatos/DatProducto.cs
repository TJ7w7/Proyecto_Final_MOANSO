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
    public class DatProducto
    {
        private static DatProducto _instancia = new DatProducto();
        public static DatProducto Instancia
        {
            get { return _instancia; }
        }
        public List<EntProducto> ListarProducto()
        {

            SqlCommand cmd = null;
            List<EntProducto> lista = new List<EntProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntProducto P = new EntProducto();
                    P.ProductoId = Convert.ToInt32(dr["ProductoId"]);
                    P.Codigo = dr["Codigo"].ToString();
                    P.MarcaId = Convert.ToInt32(dr["MarcaId"]);
                    P.Marca = dr["Marca"].ToString();
                    P.CategoriaId = Convert.ToInt32(dr["CategoriaId"]);
                    P.Categoria = dr["Categoria"].ToString();
                    P.SaboresId = Convert.ToInt32(dr["SaboresId"]);
                    P.Sabores = dr["Sabores"].ToString();
                    P.Descripcion = dr["Descripcion"].ToString();
                    P.Imagen = dr["Imagen"].ToString();
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
        public Boolean InsertarProducto(EntProducto P)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", P.Codigo);
                cmd.Parameters.AddWithValue("@marcaId", P.MarcaId);
                cmd.Parameters.AddWithValue("@categoriaId", P.CategoriaId);
                cmd.Parameters.AddWithValue("@saboresId", P.SaboresId);
                cmd.Parameters.AddWithValue("@descripcion", P.Descripcion);
                cmd.Parameters.AddWithValue("@imagen", P.Imagen);
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
        public Boolean EditarProducto(EntProducto P)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", P.ProductoId);
                cmd.Parameters.AddWithValue("@codigo", P.Codigo);
                cmd.Parameters.AddWithValue("@marcaId", P.MarcaId);
                cmd.Parameters.AddWithValue("@categoriaId", P.CategoriaId);
                cmd.Parameters.AddWithValue("@saboresId", P.SaboresId);
                cmd.Parameters.AddWithValue("@descripcion", P.Descripcion);
                cmd.Parameters.AddWithValue("@imagen", P.Imagen);
                cmd.Parameters.AddWithValue("@estado", P.Estado);
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

        public List<EntProducto> ListarTipoPresentacionProducto()
        {
            SqlCommand cmd = null;
            List<EntProducto> lista = new List<EntProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarTipoPresentacionProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntProducto P = new EntProducto();
                    P.Codigo = dr["Codigo"].ToString();
                    P.Descripcion = dr["Descripcion"].ToString();
                    P.TipoPresentacionId = Convert.ToInt32(dr["TipoPresentacionId"]);
                    P.TipoPresentacion = dr["TipoPresentacion"].ToString();
                    P.PrecioConIGV = Convert.ToDecimal(dr["PrecioConIGV"]);
                    P.PrecioSinIGV = Convert.ToDecimal(dr["PrecioSinIGV"]);
                    P.Peso = Convert.ToDecimal(dr["Peso"]);
                    P.Largo = Convert.ToDecimal(dr["Largo"]);
                    P.Ancho = Convert.ToDecimal(dr["Ancho"]);
                    P.Alto = Convert.ToDecimal(dr["Alto"]);
                    lista.Add(P);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos con tipo de presentación", ex);
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }
    }
}
