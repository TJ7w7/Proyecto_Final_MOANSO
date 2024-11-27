using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatPedido
    {
        private static readonly DatPedido _instancia = new DatPedido();

        public static DatPedido Instancia
        {
            get { return _instancia; }
        }
        public List<EntPedido> listarPedido()
        {

            SqlCommand cmd = null;
            List<EntPedido> lista = new List<EntPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPedido ped = new EntPedido();
                    ped.OrdenPedidoId = Convert.ToInt32(dr["OrdenPedidoId"]);
                    ped.NumeroPedido = dr["NumeroPedido"].ToString();
                    ped.ClienteId = Convert.ToInt32(dr["ClienteId"].ToString());
                    ped.FormaDePagoId = Convert.ToInt32(dr["FormasDePagoId"].ToString());
                    ped.PrecioTransporteId = Convert.ToInt32(dr["PrecioTransporteId"].ToString());
                    ped.PrecioProductos = Convert.ToDecimal(dr["PrecioProductos"].ToString());
                    ped.PrecioFletes = Convert.ToDecimal(dr["PrecioFlete"].ToString());
                    ped.PrecioTotal = Convert.ToDecimal(dr["PrecioTotal"].ToString());
                    ped.Fecha = DateTime.Parse(dr["Fecha"].ToString());
                    ped.Estado = dr["Estado"].ToString();
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
        public int InsertarPedido(EntPedido pedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("InsertarPedido", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@numeroPedido", pedido.NumeroPedido);
                    cmd.Parameters.AddWithValue("@clienteId", pedido.ClienteId);
                    cmd.Parameters.AddWithValue("@formasDePagoId", pedido.FormaDePagoId);
                    cmd.Parameters.AddWithValue("@precioTransporteId", pedido.PrecioTransporteId);
                    cmd.Parameters.AddWithValue("@precioProductos", pedido.PrecioProductos);
                    cmd.Parameters.AddWithValue("@precioFlete", pedido.PrecioFletes);
                    cmd.Parameters.AddWithValue("@precioTotal", pedido.PrecioTotal);
                    cmd.Parameters.AddWithValue("@fecha", pedido.Fecha);
                    cmd.Parameters.AddWithValue("@estado", pedido.Estado);

                    // Parámetro de salida para obtener el ID del pedido generado
                    SqlParameter outputId = new SqlParameter("@PedidoId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    cmd.ExecuteNonQuery();

                    return (int)outputId.Value; // Retornar el ID generado
                }
            }
        }
        public string ContarFilasOrdenPedido()
        {
            int totalFilas = 0;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("ContarFilasOrdenPedido", cn))
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
        public List<EntPedido> listarPedidoConfirmados()
        {

            SqlCommand cmd = null;
            List<EntPedido> lista = new List<EntPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarPedidosConfirmados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPedido ped = new EntPedido();
                    ped.OrdenPedidoId = Convert.ToInt32(dr["OrdenPedidoId"]);
                    ped.NumeroPedido = dr["NumeroPedido"].ToString();
                    ped.ClienteId = Convert.ToInt32(dr["ClienteId"].ToString());
                    ped.FormaDePagoId = Convert.ToInt32(dr["FormasDePagoId"].ToString());
                    ped.PrecioTransporteId = Convert.ToInt32(dr["PrecioTransporteId"].ToString());
                    ped.PrecioProductos = Convert.ToDecimal(dr["PrecioProductos"].ToString());
                    ped.PrecioFletes = Convert.ToDecimal(dr["PrecioFlete"].ToString());
                    ped.PrecioTotal = Convert.ToDecimal(dr["PrecioTotal"].ToString());
                    ped.Fecha = DateTime.Parse(dr["Fecha"].ToString());
                    ped.Estado = dr["Estado"].ToString();
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
    }
}
