using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente_juridico: Cliente
    {
        public string NumeroDocumento { get; set; }
        public string RazonSocial {  get; set; }

    }
}
