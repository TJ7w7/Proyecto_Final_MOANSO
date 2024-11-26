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
        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }
        public int SaboresId { get; set; }
        public string Descripcion { get; set; }
        public string Imagen {  get; set; }
        public bool Estado {  get; set; }

        //Solo Para mostrar
        public int TipoPresentacionId { get; set; }
        public string TipoPresentacion { get; set; }
        public decimal PrecioConIGV { get; set; }
        public decimal PrecioSinIGV { get; set; }
        public decimal Peso { get; set; }
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }

        //Solo para mostrar
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Sabores { get; set; }

    }
}
