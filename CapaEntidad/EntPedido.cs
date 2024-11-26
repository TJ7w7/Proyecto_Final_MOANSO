using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPedido
    {
        public int OrdenPedidoId { get; set; }
        public string NumeroPedido { get; set; }
        public int ClienteId { get; set; }
        public int FormaDePagoId { get; set; }
        public int PrecioTransporteId { get; set; }
        public decimal PrecioProductos { get; set; }
        public decimal PrecioFletes { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime Fecha {  get; set; }
        public string Estado {  get; set; }
    }
}
