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
    public class DatPedidoDetalle
    {
        private static readonly DatPedidoDetalle _instancia = new DatPedidoDetalle();

        public static DatPedidoDetalle Instancia
        {
            get { return _instancia; }
        }
        public void InsertarDetallePedidoProducto(List<EntPedidoDetalle> detalles, int pedidoId)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();

                foreach (var detalle in detalles)
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarDetallePedidoProducto", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@pedidoId", pedidoId);
                        cmd.Parameters.AddWithValue("@tipoPresentacionId", detalle.TipoPresentacionId);
                        cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        cmd.Parameters.AddWithValue("@precioTotal", detalle.PrecioTotal);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
