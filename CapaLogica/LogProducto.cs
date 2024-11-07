using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogProducto
    {
        #region sigleton
        private static readonly LogProducto _instancia = new LogProducto();
        public static LogProducto Instancia
        {
            get
            {
                return LogProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<string> ListarProductos()
        {
            return dtProducto.Instancia.ListarCliente();
        }
        #endregion singleton
    }
}
