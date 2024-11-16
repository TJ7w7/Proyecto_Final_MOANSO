using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogMoneda
    {
        private static readonly LogMoneda _instancia = new LogMoneda();
        public static LogMoneda Instancia
        {
            get { return _instancia; }
        }

        public List<EntMoneda> listarMoneda()
        {
            return DatMoneda.Instancia.listarMoneda();
        }
        public void InsertarMoneda(EntMoneda Mon)
        {
            DatMoneda.Instancia.InsertarMoneda(Mon);
        }

        public void EditarMoneda(EntMoneda Mon)
        {
            DatMoneda.Instancia.EditarMoneda(Mon);
        }
    }
}
