using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatoTipoDocumento
    {
        private static readonly DatoTipoDocumento _instancia = new DatoTipoDocumento();
        public static DatoTipoDocumento Instancia => _instancia;

        public DataTable ObtenerTodosTipoDocumento()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open(); // Asegurar que la conexión esté abierta
                    string query = "SELECT TipoDocumentoId, Nombre FROM TipoDocumento";
                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    da.Fill(tabla);

                    if (tabla.Rows.Count == 0)
                    {
                        throw new Exception("No se encontraron registros en la tabla TipoDocumento.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipos de documento: " + ex.Message);
            }
            return tabla;
        }
        public bool InsertarTipoDocumento(Tipo_documento tipoDocumento)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "INSERT INTO TipoDocumento (Nombre, LongitudExacta, LongitudMinima, LongitudMaxima, Alfanumerico, ClienteJuridico) VALUES (@Nombre, @LongitudExacta, @LongitudMinima, @LongitudMaxima, @Alfanumerico, @ClienteJuridico)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Nombre", tipoDocumento.nombre);
                    cmd.Parameters.AddWithValue("@LongitudExacta", tipoDocumento.LongitudExacta);
                    cmd.Parameters.AddWithValue("@LongitudMinima", tipoDocumento.LongitudMinima);
                    cmd.Parameters.AddWithValue("@LongitudMaxima", tipoDocumento.LongitudMaxima);
                    cmd.Parameters.AddWithValue("@Alfanumerico", tipoDocumento.Alfanumerico);
                    cmd.Parameters.AddWithValue("@ClienteJuridico", tipoDocumento.ClienteJuridico);
                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el tipo de documento: " + ex.Message);
            }
        }
        public bool ModificarTipoDocumento(Tipo_documento tipoDocumento)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                string query = @"
                UPDATE TipoDocumento
                SET Nombre = @Nombre, LongitudExacta = @LongitudExacta, 
                    LongitudMinima = @LongitudMinima, LongitudMaxima = @LongitudMaxima, 
                    Alfanumerico = @Alfanumerico, ClienteJuridico = @ClienteJuridico
                WHERE TipoDocumentoId = @TipoDocumentoId";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@TipoDocumentoId", tipoDocumento.tipoDocumentoId);
                    cmd.Parameters.AddWithValue("@Nombre", tipoDocumento.nombre);
                    cmd.Parameters.AddWithValue("@LongitudExacta", tipoDocumento.LongitudExacta);
                    cmd.Parameters.AddWithValue("@LongitudMinima", tipoDocumento.LongitudMinima);
                    cmd.Parameters.AddWithValue("@LongitudMaxima", tipoDocumento.LongitudMaxima);
                    cmd.Parameters.AddWithValue("@Alfanumerico", tipoDocumento.Alfanumerico);
                    cmd.Parameters.AddWithValue("@ClienteJuridico", tipoDocumento.ClienteJuridico);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
        public bool EliminarTipoDocumento(int tipoDocumentoId)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "DELETE FROM TipoDocumento WHERE TipoDocumentoId = @TipoDocumentoId";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@TipoDocumentoId", tipoDocumentoId);
                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el tipo de documento: " + ex.Message);
            }
        }
    }
                       
}
