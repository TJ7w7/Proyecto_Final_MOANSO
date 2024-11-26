using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogAsignacionTransporte
    {
        private static readonly LogAsignacionTransporte _instancia = new LogAsignacionTransporte();
        public static LogAsignacionTransporte Instancia
        {
            get { return _instancia; }
        }
        public List<EntAsignacionTransporte> ListarAsignacion()
        {
            return DatAsignacionTransporte.Instancia.listarAsignacion();
        }

        public int InsertarConductor(EntConductor cond)
        {
            int conductorid = DatAsignacionTransporte.Instancia.InsertarConductor(cond);
            return conductorid;
        }

        public int InsertarVehiculo(EntVehiculo ve)
        {
            int vehiculoid = DatAsignacionTransporte.Instancia.InsertarVehiculo(ve);
            return vehiculoid;
        }

        public void InsertarAsignacionTransporte(EntAsignacionTransporte ast)
        {
            DatAsignacionTransporte.Instancia.InsertarAsignacion(ast);
        }
    }
}
