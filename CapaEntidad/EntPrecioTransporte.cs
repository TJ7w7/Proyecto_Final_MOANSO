using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPrecioTransporte
    {
        public int PrecioTransporteId { get; set; }
        public int EmpresaId { get; set; }
        public string TipoTransporte { get; set; }
        //public int OrigenPaisId { get; set; }
        public int OrigenRegionId { get; set; }
        //public int DestinoPaisId { get; set; }
        public int DestinoRegionId { get;set; }
        public int MonedaId { get; set; }
        public decimal Precio {  get; set; }
        public bool Estado {  get; set; }


        //Solo pa visualizar
        public string Empresa { get; set; }
        //public string OrigenPais { get; set; }
        public string OrigenRegion { get; set; }
        //public string DestinoPais { get; set; }
        public string DestinoRegion { get; set; }
        public string Moneda { get; set; }
    }
}
