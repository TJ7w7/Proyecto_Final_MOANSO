using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class Cliente_natural: Cliente
    {
        public string NroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}
