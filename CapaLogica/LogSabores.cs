using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogSabores
    {
        private static readonly LogSabores _instancia = new LogSabores();
        public static LogSabores Instancia
        {
            get { return _instancia; }
        }

        public List<EntSabores> listarSabores()
        {
            return DatSabores.Instancia.listarSabores();
        }
        public void InsertarSabores(EntSabores Sab)
        {
            DatSabores.Instancia.InsertarSabores(Sab);
        }

        public void EditarSabores(EntSabores Sab)
        {
            DatSabores.Instancia.EditarSabores(Sab);
        }
    }
}
