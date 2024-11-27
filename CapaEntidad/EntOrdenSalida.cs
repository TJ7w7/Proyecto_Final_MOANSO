using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntOrdenSalida
    {
        public int OrdenSalidaId { get; set; }
        public string NumeroOrdenSalida {  get; set; }
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }

        //Solo mostrar
        public string NumeroVenta { get; set; }
    }
}
