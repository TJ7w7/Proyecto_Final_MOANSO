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
    public class LogicaClienteJuridico
    {
        // Singleton
        private static readonly LogicaClienteJuridico _instancia = new LogicaClienteJuridico();
        public static LogicaClienteJuridico Instancia => _instancia;


        public DataTable ObtenerClientesJuridicos()
        {
            try
            {
                return DatosClienteJuridico.Instancia.ListarClientesJuridicos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de clientes jurídicos: " + ex.Message);
            }
        }


        // Insertar un cliente jurídico
        public bool InsertarClienteJuridico(Cliente cliente, Cliente_juridico clienteJuridico)
        {
            try
            {
                return DatosClienteJuridico.Instancia.InsertarClienteJuridico(cliente, clienteJuridico);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente jurídico: " + ex.Message);
            }
        }

        // Modificar un cliente jurídico
        public bool ModificarClienteJuridico(Cliente cliente, Cliente_juridico clienteJuridico)
        {
            if (cliente == null || clienteJuridico == null)
            {
                throw new ArgumentException("Los datos del cliente jurídico no son válidos.");
            }

            if (cliente.ClienteId != clienteJuridico.ClienteId)
            {
                throw new ArgumentException("El ID del cliente no coincide entre cliente base y cliente jurídico.");
            }

            try
            {
                return DatosClienteJuridico.Instancia.ModificarClienteJuridico(cliente, clienteJuridico);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar cliente jurídico: " + ex.Message);
            }
        }

        // Eliminar un cliente jurídico
        public bool EliminarClienteJuridico(int clienteId)
        {
            if (clienteId <= 0)
            {
                throw new ArgumentException("El ID del cliente es inválido.");
            }

            try
            {
                return DatosClienteJuridico.Instancia.EliminarClienteJuridico(clienteId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente jurídico: " + ex.Message);
            }
        }
    }
}
