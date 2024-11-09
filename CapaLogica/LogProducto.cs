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
        public void GuardarProductos(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Nombre"].Value != null) // Verificar que el valor no esté vacío
                {
                    EntProducto producto = new EntProducto
                    {
                        Nombre = row.Cells["Nombre"].Value?.ToString() ?? string.Empty,
                        Descripcion = row.Cells["Descripcion"].Value?.ToString() ?? string.Empty,
                        Peso = row.Cells["Peso"].Value?.ToString() ?? string.Empty,
                        Color = row.Cells["Color"].Value?.ToString() ?? string.Empty,
                        Precio = Convert.ToDecimal(row.Cells["Precio"].Value ?? 0),
                        Stock = Convert.ToInt32(row.Cells["Stock"].Value ?? 0),
                        IGV = Convert.ToDecimal(row.Cells["IGV"].Value ?? 0),
                        Descontinuado = row.Cells["Descontinuado"].Value != null && Convert.ToBoolean(row.Cells["Descontinuado"].Value),
                        Imagen = row.Cells["Imagen"].Value as byte[] ?? new byte[0]
                    };

                    dtProducto.Instancia.GuardaProducto(producto);
                }
            }
        }
    }
}
