using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntFormasDePago
    {
        public int FormasDePagoId { get; set; }
        public string Nombre { get; set; }
        public bool ClienteExtranjero { get; set; }
        public bool Estado { get; set; }
    }
}
