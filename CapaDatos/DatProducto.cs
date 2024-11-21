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
                    P.Nombre = dr["Nombre"].ToString();
                    P.CategoriaId = Convert.ToInt32(dr["CategoriaId"]);
                    P.Categoria = dr["Categoria"].ToString();
                    P.SaboresId = Convert.ToInt32(dr["SaboresId"]);
                    P.Sabores = dr["Sabores"].ToString();
                    P.Descripcion = dr["Descripcion"].ToString();
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
                cmd.Parameters.AddWithValue("@nombre", P.Nombre);
                cmd.Parameters.AddWithValue("@categoriaId", P.CategoriaId);
                cmd.Parameters.AddWithValue("@saboresId", P.SaboresId);
                cmd.Parameters.AddWithValue("@descripcion", P.Descripcion);
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
                cmd.Parameters.AddWithValue("@nombre", P.Nombre);
                cmd.Parameters.AddWithValue("@categoriaId", P.CategoriaId);
                cmd.Parameters.AddWithValue("@saboresId", P.SaboresId);
                cmd.Parameters.AddWithValue("@descripcion", P.Descripcion);
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
    }
}
