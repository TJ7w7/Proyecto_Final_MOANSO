using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntCliente
    {
        public int ClienteId { get; set; } 
        public string BRN_RUC { get; set; }
        public string Nombre { get; set; }
        public int DivisionesAdministrativasId { get; set; }
        public string Direccion { get; set; }
        public string NumeroContacto { get; set; }
    }
}
