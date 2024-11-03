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
        public DataTable ListarClientes()
        {
            DatCliente datCliente = new DatCliente();
            return datCliente.ObtenerClientes();
        }

        public bool RegistrarCliente(EntCliente cliente)
        {
            return DatCliente.Instancia.RegistrarCliente(cliente);
        }
    }
}
