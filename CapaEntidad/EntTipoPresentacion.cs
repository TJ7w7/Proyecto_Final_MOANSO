using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntTipoPresentacion
    {
        public int TipoPresentacionId { get; set; }
        public int ProductoId { get; set; }
        public string TipoPresentacion { get; set; }
        public int Stock {  get; set; }
        public  decimal PrecioConIGV { get; set; }
        public decimal PrecioSinIGV { get; set;}
        public decimal Peso {  get; set; }
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Alto {  get; set; }
        public bool Estado {  get; set; }
    }
}
