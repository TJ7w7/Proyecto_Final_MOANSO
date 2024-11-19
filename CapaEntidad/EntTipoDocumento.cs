using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntTipoDocumento
    {
        public int TipoDocumentoId { get; set; }
        public string Nombre {  get; set; }
        public bool LongitudExacta { get; set; }
        public int LongitudMinima { get; set; }
        public int LongitudMaxima { get; set;}
        public bool Alfanumerico { get; set; }
        public bool ClienteJuridico { get; set; }
        public bool Estado {  get; set; }
    }
}
