using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCliente
    {
        private static readonly LogCliente _instancia = new LogCliente();
        public static LogCliente Instancia
        {
            get { return _instancia; }
        }
        public List<EntClienteJuridico> ListarClienteJuridico()
        {
            return DatCliente.Instancia.ListarClienteJuridico();
        }

        public void InsertarClienteJuridico(EntCliente c, EntClienteJuridico cj)
        {
            DatCliente.Instancia.InsertarClienteJuridico(c, cj);
        }

        public void EditarClienteJuridico(EntClienteJuridico cj)
        {
            DatCliente.Instancia.EditarClienteJuridico(cj);
        }
    }
}
