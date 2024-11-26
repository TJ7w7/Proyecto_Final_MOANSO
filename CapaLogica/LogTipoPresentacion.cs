using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTipoPresentacion
    {
        private static readonly LogTipoPresentacion _instancia = new LogTipoPresentacion();
        public static LogTipoPresentacion Instancia
        {
            get { return _instancia; }
        }
        public List<EntTipoPresentacion> ListarTipoPresentacion(int productoid)
        {
            return DatTipoPresentacion.Instancia.ListarTipoPresentacion(productoid);
        }

        public void InsertarTipoPresentacion(EntTipoPresentacion p)
        {
            DatTipoPresentacion.Instancia.InsertarTipoPresentacion(p);
        }
    }
}
