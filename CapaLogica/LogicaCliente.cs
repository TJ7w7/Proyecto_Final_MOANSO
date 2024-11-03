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
        private DatosCliente datosCliente = new DatosCliente();

        public DataTable ObtenerClientes()
        {
            return datosCliente.ObtenerTodosLosClientes();
        }

        public DataTable BuscarClientePorBRN(string brn)
        {
            return datosCliente.BuscarClienteBRN(brn);
        }
        public void RegistrarCliente(Cliente cliente)
        {
            datosCliente.insertarCliente(cliente);
        }
        public void ActualizarCliente(Cliente cliente)
        {
            datosCliente.ModificarCliente(cliente);
        }
        public void BorrarCliente(int clienteId)
        {
            datosCliente.EliminarCliente(clienteId);
        }
    }
}
