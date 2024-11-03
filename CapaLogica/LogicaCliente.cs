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
    public class LogicaCliente
    {
        private static readonly LogicaCliente _instancia = new LogicaCliente();
        public static LogicaCliente Instancia
        {
            get { return _instancia; }
        }
        public DataTable ListarClientes()
        {
            DatosCliente datCliente = new DatosCliente();
            return datCliente.ObtenerTodosLosClientes();
        }

        public bool RegistrarCliente(Cliente cliente)
        {
            return DatosCliente.Instancia.insertarCliente(cliente);
        }

        public DataTable BuscarClientePorBRN(string brn)
        {
            return DatosCliente.Instancia.BuscarClienteBRN(brn);
        }
        public bool ModificarCliente(Cliente cliente)
        {
            return DatosCliente.Instancia.ModificarCliente(cliente);
        }

        public bool EliminarCliente(int clienteId)
        {
            return DatosCliente.Instancia.EliminarCliente(clienteId);
        }

    }
}
