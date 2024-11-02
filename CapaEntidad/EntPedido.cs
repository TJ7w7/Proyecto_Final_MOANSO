using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPedido
    {
        public int IDPedido { get; set; }
        public int RUC { get; set; }
        public string Nombre { get; set; }
        public string Region { get; set; }
        public int Celular { get; set; }
        public int IDProducto { get; set; }
        public string Categoria { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public string CalleCorea { get; set; }
        public bool EstadodelPedido { get; set; }
    }
}
