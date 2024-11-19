using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTipoDocumento
    {
        private static readonly LogTipoDocumento _instancia = new LogTipoDocumento();
        public static LogTipoDocumento Instancia
        {
            get { return _instancia; }
        }

        public List<EntTipoDocumento> listarTipoDocumento()
        {
            return DatTipoDocumento.Instancia.listarTipoDocumento();
        }
        public void InsertarTipoDocumento(EntTipoDocumento tp)
        {
            DatTipoDocumento.Instancia.InsertarTipoDocumento(tp);
        }

        public void EditarTipoDocumento(EntTipoDocumento tp)
        {
            DatTipoDocumento.Instancia.EditarTipoDocumento(tp);
        }
    }
}
