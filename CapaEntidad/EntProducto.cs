using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntProducto
    {
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public int MaracId { get; set; }
        public int CategoriaId { get; set; }
        public int SaboresId { get; set; }
        public string Descripcion { get; set; }
        public string Imagen {  get; set; }
        public bool Estado {  get; set; }

        //Solo para mostrar
        public string Categoria { get; set; }
        public string Sabores { get; set; }
    }
}
