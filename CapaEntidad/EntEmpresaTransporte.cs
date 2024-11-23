using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntEmpresaTransporte
    {
        public int EmpresaTransporteId { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion {  get; set; }
        public string NumeroContacto { get; set; }
        public bool Estado { get; set; }

        //Solo para mostrar

        public string TipoDocumento {  get; set; }
    }
}
