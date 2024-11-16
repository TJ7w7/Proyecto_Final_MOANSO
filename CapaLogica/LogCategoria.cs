using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCategoria
    {
        private static readonly LogCategoria _instancia = new LogCategoria();
        public static LogCategoria Instancia
        {
            get {return _instancia;}
        }

        public List<EntCategoria> listarCategoria()
        {
            return DatCategoria.Instancia.listarCategoria();
        }
        public void InsertarCategoria(EntCategoria cat)
        {
            DatCategoria.Instancia.InsertarCategoria(cat);
        }

        public void EditarCategoria(EntCategoria cat)
        {
            DatCategoria.Instancia.EditarCategoria(cat);    
        }
    }
}
