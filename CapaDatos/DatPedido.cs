using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatPedido
    {
        #region Singleton
        private static readonly DatPedido _instancia = new DatPedido();

        public static DatPedido Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton
    }
}
