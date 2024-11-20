using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogFormasDePago
    {
        private static readonly LogFormasDePago _instancia = new LogFormasDePago();
        public static LogFormasDePago Instancia
        {
            get { return _instancia; }
        }

        public List<EntFormasDePago> listarFormasDePago()
        {
            return DatFormasDePago.Instancia.listarFormasDePago();
        }

        public void InsertarFormasDePago(EntFormasDePago fp)
        {
            DatFormasDePago.Instancia.InsertarFormasDePago(fp);
        }

        public void EditarFormasDePago(EntFormasDePago fp)
        {
            DatFormasDePago.Instancia.EditarFormaDePago(fp);
        }
    }
}
