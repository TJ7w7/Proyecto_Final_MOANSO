using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntDivisionesAdministrativas
    {
        public int DivisionesAdministrativasId { get; set; }
        public string Nombre { get; set; }
        public int CodigoArea { get; set; }
        public bool Estado { get; set; }
    }
}
