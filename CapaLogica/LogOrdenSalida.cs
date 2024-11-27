using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogOrdenSalida
    {
        private static readonly LogOrdenSalida _instancia = new LogOrdenSalida();
        public static LogOrdenSalida Instancia
        {
            get { return _instancia; }
        }
        public List<EntOrdenSalida> listarOrdenSalida()
        {
            return DatOrdenSalida.Instancia.listarOrdenSalida();
        }
        public string ContarFilas()
        {
            return DatOrdenSalida.Instancia.ContarFilasOrdenSalida();
        }

        public void InsertarOrdenSalidaa(EntOrdenSalida x)
        {
            DatOrdenSalida.Instancia.InsertarOrdenSalida(x);
        }

    }
}
