using CapaDatos;
using CapaEntidad;
using System;
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
            get { return _instancia; }
        }
        public List<EntProducto> ListarProducto()
        {
            return DatProducto.Instancia.ListarProducto();
        }

        public void InsertarProducto(EntProducto p)
        {
            DatProducto.Instancia.InsertarProducto(p);
        }

        public void EditarProducto(EntProducto p)
        {
            DatProducto.Instancia.EditarProducto(p);
        }

        public List<EntProducto> ListarProductoTipoPresentaciones()
        {
            return DatProducto.Instancia.ListarTipoPresentacionProducto();
        }
    }
}
