using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogMarca
    {
        private static readonly LogMarca _instancia = new LogMarca();
        public static LogMarca Instancia
        {
            get { return _instancia; }
        }

        public List<EntMarca> listarMarca()
        {
            return DatMarca.Instancia.listarMarca();
        }
        public void InsertarMarca(EntMarca ma)
        {
            DatMarca.Instancia.InsertarMarca(ma);
        }

        public void EditarMarca(EntMarca ma)
        {
            DatMarca.Instancia.EditarMarca(ma);
        }
    }
}
