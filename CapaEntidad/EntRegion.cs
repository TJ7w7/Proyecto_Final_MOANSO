using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntRegion
    {
        public int RegionId { get; set; }
        public int PaisId { get; set; }
        public int CodigoArea { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public bool Aduana {  get; set; }


        //dato solo para mostrar en el data
        public string NombrePais { get; set; }
    }
}
