using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public string CodigoIso { get; set; }
        public string CodigoTelefono { get; set; }
        public int MonedaId { get; set; }
    }
}
