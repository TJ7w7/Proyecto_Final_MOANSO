using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogPedido _instancia = new LogPedido();
        //privado para evitar la instanciación directa
        public static LogPedido Instancia
        {
            get
            {
                return LogPedido._instancia;
            }
        }
        #endregion singleton
    }
}
