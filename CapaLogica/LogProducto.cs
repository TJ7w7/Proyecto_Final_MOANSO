using CapaEntidad;
using CapaDatos;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogProducto
    {
        private static readonly LogProducto _instancia = new LogProducto();
        public static LogProducto Instancia
        {
            get
            {
                return LogProducto._instancia;
            }
        }

    }
}
