using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogSabores
    {
        private static readonly LogSabores _instancia = new LogSabores();
        public static LogSabores Instancia
        {
            get
            {
                return _instancia;
            }
        }

        public bool GuardarSabores(EntSabores sabores)
        {
            if (string.IsNullOrWhiteSpace(sabores.Nombre))
            {
                throw new ArgumentException("El nombre de sabor no puede estar vacío.");
            }

            if (sabores.Nombre.Length > 100)
            {
                throw new ArgumentException("El nombre de sabor no puede exceder los 100 caracteres.");
            }

            return dtSabores.Instancia.GuardarSabores(sabores);
        }
        public bool ModificarSabores(EntSabores sabores)
        {
            if (string.IsNullOrWhiteSpace(sabores.Nombre))
            {
                throw new ArgumentException("El nombre de sabores no puede estar vacío.");
            }

            if (sabores.Nombre.Length > 100)
            {
                throw new ArgumentException("El nombre de sabores no puede exceder los 100 caracteres.");
            }

            return dtSabores.Instancia.ModificarSabores(sabores);
        }
        public bool EliminarSabores(int saboresid)
        {
            if (saboresid <= 0)
            {
                throw new ArgumentException("El ID de sabores no es válido.");
            }

            return dtSabores.Instancia.EliminarSabores(saboresid);
        }

        public List<EntSabores> ObtenerSabores()
        {
            return dtSabores.Instancia.ListarSabores();
        }
        public List<EntSabores> ObtenerSaboresCMB()
        {
            return dtSabores.Instancia.ListarSaboresEnCMB();
        }


    }
}
