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
    public class DatFormasDePago
    {
        private static DatFormasDePago _instancia = new DatFormasDePago();
        public static DatFormasDePago Instancia
        {
            get { return _instancia; }
        }

        public List<EntFormasDePago> listarFormasDePago()
        {

            SqlCommand cmd = null;
            List<EntFormasDePago> lista = new List<EntFormasDePago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarFormasDePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntFormasDePago Fp = new EntFormasDePago();
                    Fp.FormasDePagoId = Convert.ToInt32(dr["FormasDePagoId"]);
                    Fp.Nombre = dr["Nombre"].ToString();
                    Fp.ClienteExtranjero = Convert.ToBoolean(dr["ClienteExtranjero"].ToString());
                    Fp.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                    lista.Add(Fp);
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
        public Boolean InsertarFormasDePago(EntFormasDePago Fp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarFormasDePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Fp.Nombre);
                cmd.Parameters.AddWithValue("@clienteExtranjero", Fp.ClienteExtranjero);
                cmd.Parameters.AddWithValue("@estado", Fp.Estado);
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

        public Boolean EditarFormaDePago(EntFormasDePago Fp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarFormasDePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Fp.FormasDePagoId);
                cmd.Parameters.AddWithValue("@nombre", Fp.Nombre);
                cmd.Parameters.AddWithValue("@clienteExtranjero", Fp.ClienteExtranjero);
                cmd.Parameters.AddWithValue("@estado", Fp.Estado);
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
