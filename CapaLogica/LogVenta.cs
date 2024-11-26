using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogVenta
    {
        private static readonly LogVenta _instancia = new LogVenta();
        //privado para evitar la instanciación directa
        public static LogVenta Instancia
        {
            get
            {
                return LogVenta._instancia;
            }
        }

        public List<EntVenta> ListarVenta()
        {
            return DatVenta.Instancia.listarVentas();
        }
        public string ContarFilas()
        {
            return DatVenta.Instancia.ContarFilasVenta();
        }
        public void InsertarVenta(EntVenta x)
        {
            DatVenta.Instancia.InsertarVenta(x);
        }
    }
}
