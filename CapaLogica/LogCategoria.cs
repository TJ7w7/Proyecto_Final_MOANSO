using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCategoria
    {
        private static readonly LogCategoria _instancia = new LogCategoria();
        public static LogCategoria Instancia
        {
            get
            {
                return _instancia;
            }
        }

        public bool GuardarCategoria(EntCategoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");
            }

            if (categoria.Nombre.Length > 255)
            {
                throw new ArgumentException("El nombre de la categoría no puede exceder los 255 caracteres.");
            }

            return dtCategoria.Instancia.GuardaCategoria(categoria);
        }
        public bool ActualizarCategoria(EntCategoria categoria)
        {
            // Validaciones similares a las que ya tienes en GuardarCategoria
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");
            }

            if (categoria.Nombre.Length > 255)
            {
                throw new ArgumentException("El nombre de la categoría no puede exceder los 255 caracteres.");
            }

            return dtCategoria.Instancia.ActualizarCategoria(categoria);
        }
        public bool EliminarCategoria(int categoriaId)
        {
            if (categoriaId <= 0)
            {
                throw new ArgumentException("El ID de la categoría no es válido.");
            }

            return dtCategoria.Instancia.EliminarCategoria(categoriaId);
        }

        public List<EntCategoria> ObtenerCategorias()
        {
            return dtCategoria.Instancia.ListarCategorias();
        }
    }
}
