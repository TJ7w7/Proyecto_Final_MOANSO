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
    public class DatosPais
    {
        private static readonly DatosPais _instancia = new DatosPais();
        public static DatosPais Instancia => _instancia;

        public DataTable ObtenerTodosPaises()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "SELECT PaisId, Nombre FROM Pais";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener países: " + ex.Message);
            }
            return tabla;
        }

        public bool InsertarPais(Pais pais)
        {
            if (string.IsNullOrWhiteSpace(pais.Nombre))
            {
                throw new ArgumentException("El nombre del país no puede estar vacío.");
            }

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                string query = @"
                IF EXISTS (SELECT 1 FROM Moneda WHERE MonedaId = @MonedaId)
                BEGIN
                    INSERT INTO Pais (Nombre, CodigoIso, CodigoTelefono, MonedaId)
                    VALUES (@Nombre, @CodigoIso, @CodigoTelefono, @MonedaId)
                END
                ELSE
                BEGIN
                    THROW 50000, 'El MonedaId no es válido.', 1;
                END";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", pais.Nombre);
                    cmd.Parameters.AddWithValue("@CodigoIso", pais.CodigoIso);
                    cmd.Parameters.AddWithValue("@CodigoTelefono", pais.CodigoTelefono);
                    cmd.Parameters.AddWithValue("@MonedaId", pais.MonedaId);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool ModificarPais(Pais pais)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "UPDATE Pais SET Nombre = @Nombre, CodigoIso = @CodigoIso, CodigoTelefono = @CodigoTelefono, MonedaId = @MonedaId WHERE PaisId = @PaisId";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@PaisId", pais.PaisId);
                    cmd.Parameters.AddWithValue("@Nombre", pais.Nombre);
                    cmd.Parameters.AddWithValue("@CodigoIso", pais.CodigoIso);
                    cmd.Parameters.AddWithValue("@CodigoTelefono", pais.CodigoTelefono);
                    cmd.Parameters.AddWithValue("@MonedaId", pais.MonedaId);
                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el país: " + ex.Message);
            }
        }

        public bool EliminarPais(int paisId)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "DELETE FROM Pais WHERE PaisId = @PaisId";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@PaisId", paisId);
                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el país: " + ex.Message);
            }
        }
    }
}
