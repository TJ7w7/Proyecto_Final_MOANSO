using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaRegion
    {
        // Singleton
        private static readonly LogicaRegion _instancia = new LogicaRegion();
        public static LogicaRegion Instancia => _instancia;

        // Listar todas las regiones
        public DataTable ListarRegiones()
        {
            try
            {
                return DatosRegion.Instancia.ObtenerTodosRegion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las regiones: " + ex.Message);
            }
        }

        // Listar regiones por país
        public DataTable ListarRegionesPorPais(int paisId)
        {
            if (paisId <= 0)
            {
                throw new ArgumentException("El ID del país es inválido.");
            }

            try
            {
                return DatosRegion.Instancia.ObtenerRegionesPorPais(paisId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las regiones por país: " + ex.Message);
            }
        }

        public bool InsertarRegion(Region region)
        {
            if (string.IsNullOrWhiteSpace(region.Nombre) || region.Nombre.Length > 255)
            {
                throw new ArgumentException("El nombre de la región no puede estar vacío ni exceder los 255 caracteres.");
            }
            if (region.CodigoArea != 0 && region.CodigoArea <= 0)
            {
                throw new ArgumentException("El código de área debe ser mayor a 0 o igual a 0 si no aplica.");
            }

            return DatosRegion.Instancia.InsertarRegion(region);
        }

        public bool ModificarRegion(Region region)
        {
            if (region.RegionId <= 0 || string.IsNullOrWhiteSpace(region.Nombre) || region.PaisId <= 0)
            {
                throw new ArgumentException("Datos inválidos para modificar la región.");
            }
            return DatosRegion.Instancia.ModificarRegion(region);
        }

        public bool EliminarRegion(int regionId)
        {
            if (regionId <= 0)
            {
                throw new ArgumentException("El ID de la región es inválido.");
            }
            return DatosRegion.Instancia.EliminarRegion(regionId);
        }
    }
}
