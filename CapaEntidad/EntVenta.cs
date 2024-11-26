using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntVenta
    {
        public int VentaId { get; set; }
        public string NumeroVenta { get; set; }
        public int OrdenPedidoId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
