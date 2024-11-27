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
    public class DatOrdenSalida
    {
        private static readonly DatOrdenSalida _instancia = new DatOrdenSalida();

        public static DatOrdenSalida Instancia
        {
            get { return _instancia; }
        }
        public List<EntOrdenSalida> listarOrdenSalida()
        {

            SqlCommand cmd = null;
            List<EntOrdenSalida> lista = new List<EntOrdenSalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarOrdenSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntOrdenSalida ped = new EntOrdenSalida();
                    ped.OrdenSalidaId = Convert.ToInt32(dr["OrdenSalidaId"]);
                    ped.NumeroOrdenSalida = dr["NumeroOrdenSalida"].ToString();
                    ped.NumeroVenta = dr["NumeroVenta"].ToString();
                    ped.Fecha = Convert.ToDateTime(dr["FormasDePagoId"].ToString());
                    lista.Add(ped);
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

        public string ContarFilasOrdenSalida()
        {
            int totalFilas = 0;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("ContarFilasOrdenSalida", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Ejecutar el comando y obtener el resultado
                    totalFilas = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            totalFilas++;

            // Devolver el número de filas como un string con 7 dígitos, rellenando con ceros a la izquierda
            return totalFilas.ToString("D7");
        }

        public Boolean InsertarOrdenSalida(EntOrdenSalida x)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarOrdenSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroOrden", x.NumeroOrdenSalida);
                cmd.Parameters.AddWithValue("@ventaId", x.VentaId);
                cmd.Parameters.AddWithValue("@fecha", x.Fecha);
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
    }
}
