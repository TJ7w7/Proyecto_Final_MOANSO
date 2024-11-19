using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntCliente
    {
        public int ClienteId { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public int PaisId { get; set; }
        public int RegionId { get; set; }
        public string Direccion { get; set; }
        public string NumeroContacto { get; set; }
        public bool Estado { get; set; }


        //Solo para visualizar datos
        public string TipoDocumento { get; set; }
        public string Pais {  get; set; }
        public string Region { get; set; }

    }
}
