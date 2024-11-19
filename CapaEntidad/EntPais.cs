using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPais
    {
        public int PaisId {  get; set; }
        public string Nombre { get; set; }
        public string CodigoISO {  get; set; }
        public string CodigoTelefono { get; set; }
        public int MonedaId { get; set; }
        public bool Estado {  get; set; }


        //dato solo para mostrar en el dgv
        public string NombreMoneda { get; set; }

    }
}
