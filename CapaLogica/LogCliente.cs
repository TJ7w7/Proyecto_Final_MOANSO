using CapaDatos;
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
        public DataTable ListarClientes()
        {
            DatCliente datCliente = new DatCliente();
            return datCliente.ObtenerClientes();
        }
        public void AgregarCliente(string brnRuc, string nombre, int divisionesAdministrativasId, string direccion, string numeroContacto)
        {
            DatCliente datCliente = new DatCliente();
            datCliente.RegistrarCliente(brnRuc, nombre, divisionesAdministrativasId, direccion, numeroContacto);
        }
    }
}
