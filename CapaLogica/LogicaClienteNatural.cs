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
    public class LogicaClienteNatural
    {
        // Singleton
        private static readonly LogicaClienteNatural _instancia = new LogicaClienteNatural();
        public static LogicaClienteNatural Instancia => _instancia;

        // Obtener todos los clientes naturales
        public DataTable ObtenerTodosLosClientesNaturales()
        {
            try
            {
                return DatosClienteNatural.Instancia.ListarClientesNaturales();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de clientes naturales: " + ex.Message);
            }
        }

        // Insertar un cliente natural
        public bool InsertarClienteNatural(Cliente cliente, Cliente_natural clienteNatural)
        {
            if (cliente == null || clienteNatural == null)
            {
                throw new ArgumentException("Los datos del cliente natural no pueden ser nulos.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Direccion) || cliente.Direccion.Length > 255)
            {
                throw new ArgumentException("La dirección no puede estar vacía ni exceder los 255 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(clienteNatural.Nombres) || clienteNatural.Nombres.Length > 100)
            {
                throw new ArgumentException("El nombre no puede estar vacío ni exceder los 100 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(clienteNatural.Apellidos) || clienteNatural.Apellidos.Length > 100)
            {
                throw new ArgumentException("El apellido no puede estar vacío ni exceder los 100 caracteres.");
            }

            try
            {
                return DatosClienteNatural.Instancia.InsertarClienteNatural(cliente, clienteNatural);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente natural: " + ex.Message);
            }
        }

        // Modificar un cliente natural
        public bool ModificarClienteNatural(Cliente cliente, Cliente_natural clienteNatural)
        {
            if (cliente == null || clienteNatural == null)
            {
                throw new ArgumentException("Los datos del cliente natural no pueden ser nulos.");
            }

            if (cliente.ClienteId != clienteNatural.ClienteId)
            {
                throw new ArgumentException("El ID del cliente es inválido o no coincide entre Cliente y ClienteNatural.");
            }

            try
            {
                return DatosClienteNatural.Instancia.ModificarClienteNatural(cliente, clienteNatural);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar cliente natural: " + ex.Message);
            }
        }

        // Eliminar un cliente natural
        public bool EliminarClienteNatural(int clienteId)
        {
            if (clienteId <= 0)
            {
                throw new ArgumentException("El ID del cliente es inválido.");
            }

            try
            {
                return DatosClienteNatural.Instancia.EliminarClienteNatural(clienteId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente natural: " + ex.Message);
            }
        }
    }
}
