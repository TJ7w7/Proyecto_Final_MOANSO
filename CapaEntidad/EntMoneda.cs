using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntMoneda
    {
        public int MonedaId { get; set; }
        public string CodigoISO { get; set; }
        public string Nombre { get; set; }
        public decimal TasaCambio { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Estado { get; set; }
    }
}
