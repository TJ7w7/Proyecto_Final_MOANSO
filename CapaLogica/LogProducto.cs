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
        public bool GuardarProducto(EntProducto producto)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.");

            if (producto.Nombre.Length > 255)
                throw new ArgumentException("El nombre del producto no puede exceder los 255 caracteres.");

            if (producto.CategoriaId <= 0)
                throw new ArgumentException("Debe seleccionar una categoría válida.");

            if (producto.SaboresId <= 0)
                throw new ArgumentException("Debe seleccionar un sabor válido.");

            if (producto.Stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            if (producto.Imagen == null || producto.Imagen.Length == 0)
                throw new ArgumentException("Debe cargar una imagen para el producto.");

            return dtProducto.Instancia.GuardarProducto(producto);
        }
        public bool ModificarProducto(EntProducto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.");

            if (producto.Stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            return dtProducto.Instancia.ModificarProducto(producto);
        }
        public bool EliminarProducto(int productoId)
        {
            try
            {
                return dtProducto.Instancia.EliminarProducto(productoId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto: " + ex.Message);
            }
        }
    }
}
