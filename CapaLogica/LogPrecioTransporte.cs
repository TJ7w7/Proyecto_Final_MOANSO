using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogPrecioTransporte
    {
        private static readonly LogPrecioTransporte _instancia = new LogPrecioTransporte();
        public static LogPrecioTransporte Instancia
        {
            get { return _instancia; }
        }

        public List<EntPrecioTransporte> ListarPrecioTransporte()
        {
            return DatPrecioTransporte.Instancia.ListarPrecioTransporte();
        }
        public void InsertarPrecioTransporte(EntPrecioTransporte Pt)
        {
            DatPrecioTransporte.Instancia.InsertarPrecioTransporte(Pt);
        }

        public void EditarPrecioTransporte(EntPrecioTransporte Pt)
        {
            DatPrecioTransporte.Instancia.EditarPrecioTransporte(Pt);
        }
    }
}
