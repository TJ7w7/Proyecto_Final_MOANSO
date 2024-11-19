using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogPais
    {
        private static readonly LogPais _instancia = new LogPais();
        public static LogPais Instancia
        {
            get { return _instancia; }
        }

        public List<EntPais> listarPais()
        {
            return DatPais.Instancia.listarPais();
        }
        public void InsertarPais(EntPais Pa)
        {
            DatPais.Instancia.InsertarPais(Pa);
        }

        public void EditarPais(EntPais Pa)
        {
            DatPais.Instancia.EditarPais(Pa);
        }
    }
}
