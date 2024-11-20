using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int? TipoDocumentoId { get; set; }
        public int? PaisId { get; set; }
        public int? RegionId { get; set; }
        public string Direccion { get; set; }
        public string NumeroContacto { get; set; }

        public bool Estado {  get; set; }

    }
}
