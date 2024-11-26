using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class EntAsignacionTransporte
    {
        public int AsignacionTransporteId {  get; set; }
        public int OrdenPedidoId { get; set; }
        public int ConductorId { get; set; }
        public int VehiculoId { get; set; }
        public bool Estado {  get; set; }
    }
}
