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
    public class LogicaTipoDocumento
    {
        // Singleton
        private static readonly LogicaTipoDocumento _instancia = new LogicaTipoDocumento();
        public static LogicaTipoDocumento Instancia => _instancia;

        // Obtener todos los tipos de documentos como una lista
        public List<Tipo_documento> ObtenerTipoDocumentos()
        {
            try
            {
                // Obtiene el DataTable desde la capa de datos
                DataTable tabla = DatoTipoDocumento.Instancia.ObtenerTodosTipoDocumento();

                // Convertir DataTable en una lista de objetos TipoDocumento
                List<Tipo_documento> lista = new List<Tipo_documento>();
                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new Tipo_documento
                    {
                        tipoDocumentoId = Convert.ToInt32(fila["TipoDocumentoId"]),
                        nombre = fila["Nombre"].ToString()
                    });
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipos de documentos: " + ex.Message);
            }
        }

        //-------------------------------------------------------
        public bool InsertarTipoDocumento(Tipo_documento tipoDocumento)
        {
            if (string.IsNullOrWhiteSpace(tipoDocumento.nombre) || tipoDocumento.nombre.Length > 12)
            {
                throw new ArgumentException("El nombre del tipo de documento no puede estar vacío ni exceder los 12 caracteres.");
            }
            if (tipoDocumento.LongitudMinima < 0 || tipoDocumento.LongitudMaxima < tipoDocumento.LongitudMinima)
            {
                throw new ArgumentException("Las longitudes mínima y máxima no son coherentes.");
            }

            return DatoTipoDocumento.Instancia.InsertarTipoDocumento(tipoDocumento);
        }

        public bool ModificarTipoDocumento(Tipo_documento tipoDocumento)
        {
            if (tipoDocumento.tipoDocumentoId <= 0 ||
                string.IsNullOrWhiteSpace(tipoDocumento.nombre) ||
                tipoDocumento.LongitudExacta ||
                tipoDocumento.LongitudMinima < 0 ||
                tipoDocumento.LongitudMaxima < tipoDocumento.LongitudMinima)
            {
                throw new ArgumentException("Datos inválidos para modificar el tipo de documento.");
            }
            return DatoTipoDocumento.Instancia.ModificarTipoDocumento(tipoDocumento);
        }

        public bool EliminarTipoDocumento(int tipoDocumentoId)
        {
            if (tipoDocumentoId <= 0)
            {
                throw new ArgumentException("El ID del tipo de documento es inválido.");
            }
            return DatoTipoDocumento.Instancia.EliminarTipoDocumento(tipoDocumentoId);
        }
    }
}
