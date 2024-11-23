using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogEmpresaTransporte
    {
        private static readonly LogEmpresaTransporte _instancia = new LogEmpresaTransporte();
        public static LogEmpresaTransporte Instancia
        {
            get { return _instancia; }
        }

        public List<EntEmpresaTransporte> ListarEmpresaTransporte()
        {
            return DatEmpresaTransporte.Instancia.ListarEmpresaTransporte();
        }
        public void InsertarEmpresaTransporte(EntEmpresaTransporte e)
        {
            DatEmpresaTransporte.Instancia.InsertarEmpresaTransporte(e);
        }

        public void EditarEmpresaTransporte(EntEmpresaTransporte e)
        {
            DatEmpresaTransporte.Instancia.EditarEmpresaTransporte(e);
        }
    }
}
