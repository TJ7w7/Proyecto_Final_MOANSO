using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogRegion
    {
        private static readonly LogRegion _instancia = new LogRegion();
        public static LogRegion Instancia
        {
            get { return _instancia; }
        }

        public List<EntRegion> ListarRegion()
        {
            return DatRegion.Instancia.ListarRegion();
        }
        public void InsertarRegion(EntRegion Re)
        {
            DatRegion.Instancia.InsertarRegion(Re);
        }

        public void EditarRegion(EntRegion Re)
        {
            DatRegion.Instancia.EditarRegion(Re);
        }
    }
}
