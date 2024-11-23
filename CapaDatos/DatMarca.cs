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
    public class DatMarca
    {
        private static DatMarca _instancia = new DatMarca();
        public static DatMarca Instancia
        {
            get { return _instancia; }
        }

        public List<EntMarca> listarMarca()
        {

            SqlCommand cmd = null;
            List<EntMarca> lista = new List<EntMarca>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntMarca Ma = new EntMarca();
                    Ma.MarcaId = Convert.ToInt32(dr["MarcaId"]);
                    Ma.Nombre = dr["Nombre"].ToString();
                    Ma.Descripcion = dr["Descripcion"].ToString();
                    Ma.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Ma);
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

        public Boolean InsertarMarca(EntMarca Ma)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Ma.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", Ma.Descripcion);
                cmd.Parameters.AddWithValue("@estado", Ma.Estado);
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

        public Boolean EditarMarca(EntMarca Ma)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Ma.MarcaId);
                cmd.Parameters.AddWithValue("@nombre", Ma.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", Ma.Descripcion);
                cmd.Parameters.AddWithValue("@estado", Ma.Estado);
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
