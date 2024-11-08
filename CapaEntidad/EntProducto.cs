using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntProducto
    {
        public int Productoid { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public int Stock { get; set; }
        public Decimal IGV { get; set; }
        public Boolean Descontinuado { get; set; }
        public byte[] Imagen { get; set; }

    }
}
