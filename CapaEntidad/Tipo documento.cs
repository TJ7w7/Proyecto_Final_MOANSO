using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Tipo_documento
    {
        public int tipoDocumentoId {  get; set; }
        public string nombre {  get; set; }
        public bool LongitudExacta { get; set; }
        public int LongitudMinima { get; set; }
        public int LongitudMaxima { get; set; }
        public bool Alfanumerico { get; set; }
        public bool ClienteJuridico { get; set; }
        

    }
}
