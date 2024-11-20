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
    public class DatosRegion
    {
        private static readonly DatosRegion _instancia = new DatosRegion();
        public static DatosRegion Instancia => _instancia;

        public DataTable ObtenerTodosRegion()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "SELECT RegionId, PaisId, CodigoArea, Nombre, Estado, Aduana FROM Region";
                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las regiones: " + ex.Message);
            }
            return tabla;
        }
        public DataTable ObtenerRegionesPorPais(int paisId)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                string query = @"
            SELECT RegionId, Nombre
            FROM Region
            WHERE PaisId = @PaisId";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@PaisId", paisId);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public bool InsertarRegion(Region region)
        {
            if (string.IsNullOrWhiteSpace(region.Nombre))
            {
                throw new ArgumentException("El nombre de la región no puede estar vacío.");
            }

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                string query = @"
            IF EXISTS (SELECT 1 FROM Pais WHERE PaisId = @PaisId)
            BEGIN
                INSERT INTO Region (PaisId, CodigoArea, Nombre, Estado, Aduana)
                VALUES (@PaisId, @CodigoArea, @Nombre, @Estado, @Aduana)
            END
            ELSE
            BEGIN
                THROW 50000, 'El PaisId no es válido.', 1;
            END";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@PaisId", region.PaisId);
                    cmd.Parameters.AddWithValue("@CodigoArea", region.CodigoArea == 0 ? (object)DBNull.Value : region.CodigoArea);
                    cmd.Parameters.AddWithValue("@Nombre", region.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", region.Estado);
                    cmd.Parameters.AddWithValue("@Aduana", region.Aduana);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool ModificarRegion(Region region)
        {
            if (region.RegionId <= 0 || string.IsNullOrWhiteSpace(region.Nombre))
            {
                throw new ArgumentException("Los datos de la región no son válidos.");
            }

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                string query = @"
            UPDATE Region
            SET PaisId = @PaisId, CodigoArea = @CodigoArea, Nombre = @Nombre, 
                Estado = @Estado, Aduana = @Aduana
            WHERE RegionId = @RegionId";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@RegionId", region.RegionId);
                    cmd.Parameters.AddWithValue("@PaisId", region.PaisId);
                    cmd.Parameters.AddWithValue("@CodigoArea", region.CodigoArea == 0 ? (object)DBNull.Value : region.CodigoArea);
                    cmd.Parameters.AddWithValue("@Nombre", region.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", region.Estado);
                    cmd.Parameters.AddWithValue("@Aduana", region.Aduana);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool EliminarRegion(int regionId)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "DELETE FROM Region WHERE RegionId = @RegionId";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@RegionId", regionId);
                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la región: " + ex.Message);
            }
        }
    }
}
