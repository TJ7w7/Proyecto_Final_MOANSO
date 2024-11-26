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

        public List<EntClienteNatural> ListarClienteNatural()
        {
            return DatCliente.Instancia.listarClienteNatural();
        }

        public void InsertarClienteNatural(EntCliente c, EntClienteNatural cn)
        {
            DatCliente.Instancia.InsertarClienteNatural(c, cn);
        }

        public void EditarClienteNatural(EntClienteNatural cn)
        {
            DatCliente.Instancia.EditarClienteNatural(cn);
        }

        public EntClienteNatural BuscarClienteNatural(string nro)
        {
            return DatCliente.Instancia.BuscarClienteNatural(nro);
        }

        public EntClienteJuridico BuscarClienteJuridico(string nro)
        {
            return DatCliente.Instancia.BuscarClienteJuridico(nro);
        }
    }
}
