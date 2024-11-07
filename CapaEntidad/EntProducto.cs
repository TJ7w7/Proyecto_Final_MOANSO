using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntProducto
    {
        public int Productoid {  get; set; }
        public string Nombre { get; set; }  
        public string Descripcion { get; set; }
        public int Precio {  get; set; }
        public int Stock { get; set; }
        public int Porcentaje { get; set; }
        public int IGV { get; set; }
        public Boolean Descontinuado {  get; set; }

    }
}
