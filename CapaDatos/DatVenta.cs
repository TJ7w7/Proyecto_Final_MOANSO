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
    public class DatVenta
    {
        private static readonly DatVenta _instancia = new DatVenta();

        public static DatVenta Instancia
        {
            get { return _instancia; }
        }
        public List<EntVenta> listarVentas()
        {

            SqlCommand cmd = null;
            List<EntVenta> lista = new List<EntVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntVenta ped = new EntVenta();
                    ped.VentaId = Convert.ToInt32(dr["VentaId"]);
                    ped.NumeroVenta = dr["NumeroVenta"].ToString();
                    ped.OrdenPedidoId = Convert.ToInt32(dr["OrdenPedidoId"]);
                    ped.Fecha = DateTime.Parse(dr["Fecha"].ToString());
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
        public Boolean InsertarVenta(EntVenta x)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroVenta", x.NumeroVenta);
                cmd.Parameters.AddWithValue("@ordenPedidoId", x.OrdenPedidoId);
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


        public string ContarFilasVenta()
        {
            int totalFilas = 0;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("ContarFilasVenta", cn))
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
    }
}
