using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogPedidoDetalle
    {
        private static readonly LogPedidoDetalle _instancia = new LogPedidoDetalle();
        public static LogPedidoDetalle Instancia
        {
            get { return _instancia; }
        }

        public void GuardarPedidoCompleto(EntPedido pedido, List<EntPedidoDetalle> detalles)
        {
            try
            {
                int pedidoId = DatPedido.Instancia.InsertarPedido(pedido); // Guardar el pedido y obtener su ID
                DatPedidoDetalle.Instancia.InsertarDetallePedidoProducto(detalles, pedidoId); // Guardar el detalle con el ID del pedido

            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el pedido completo", ex);
            }
        }
    }
}
