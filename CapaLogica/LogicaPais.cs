using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaPais
    {
        // Singleton
        private static readonly LogicaPais _instancia = new LogicaPais();
        public static LogicaPais Instancia => _instancia;

        // Listar todos los países
        public DataTable ListarPaises()
        {
            try
            {
                return DatosPais.Instancia.ObtenerTodosPaises();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los países: " + ex.Message);
            }
        }

        public bool InsertarPais(Pais pais)
        {
            if (string.IsNullOrWhiteSpace(pais.Nombre) || pais.Nombre.Length > 255)
            {
                throw new ArgumentException("El nombre del país no puede estar vacío ni exceder los 255 caracteres.");
            }
            if (string.IsNullOrWhiteSpace(pais.CodigoIso) || pais.CodigoIso.Length != 3)
            {
                throw new ArgumentException("El código ISO debe tener exactamente 3 caracteres.");
            }

            return DatosPais.Instancia.InsertarPais(pais);
        }

        public bool ModificarPais(Pais pais)
        {
            if (pais.PaisId <= 0 || string.IsNullOrWhiteSpace(pais.Nombre))
            {
                throw new ArgumentException("Datos inválidos para modificar el país.");
            }
            return DatosPais.Instancia.ModificarPais(pais);
        }

        public bool EliminarPais(int paisId)
        {
            if (paisId <= 0)
            {
                throw new ArgumentException("El ID del país es inválido.");
            }
            return DatosPais.Instancia.EliminarPais(paisId);
        }
    }
}
