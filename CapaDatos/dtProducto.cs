using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class dtProducto
    {
        Conexion cn = new Conexion();

        private static readonly dtProducto _instancia = new dtProducto();
        public static dtProducto Instancia
        {
            get
            {
                return dtProducto._instancia;
            }
        }

        public bool GuardarProducto(EntProducto producto)
        {
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "INSERT INTO Producto (Nombre, CategoriaId, SaboresId, Stock, Descontinuado, Imagen) " +
                               "VALUES (@Nombre, @CategoriaId, @SaboresId, @Stock, @Descontinuado, @Imagen)";

                SqlCommand gp = new SqlCommand(query, connection);
                gp.Parameters.AddWithValue("@Nombre", producto.Nombre);
                gp.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                gp.Parameters.AddWithValue("@SaboresId", producto.SaboresId);
                gp.Parameters.AddWithValue("@Stock", producto.Stock);
                gp.Parameters.AddWithValue("@Descontinuado", producto.Descontinuado);
                gp.Parameters.AddWithValue("@Imagen", producto.Imagen);


                connection.Open();
                int rowsAffected = gp.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        public bool ModificarProducto(EntProducto producto)
        {
            using (SqlConnection connection = Conexion.Instancia.Conectar())
            {
                string query = @"
            UPDATE Producto
            SET Nombre = @Nombre,
                CategoriaId = @CategoriaId,
                SaboresId = @SaboresId,
                Stock = @Stock,
                Descontinuado = @Descontinuado,
                Imagen = @Imagen
            WHERE ProductoId = @ProductoId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                cmd.Parameters.AddWithValue("@SaboresId", producto.SaboresId);
                cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                cmd.Parameters.AddWithValue("@Descontinuado", producto.Descontinuado);
                cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);
                cmd.Parameters.AddWithValue("@ProductoId", producto.Productoid);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        public bool EliminarProducto(int productoId)
        {
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "DELETE FROM Producto WHERE ProductoId = @ProductoId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProductoId", productoId);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Si se eliminó correctamente, retorna true
            }
        }
        public List<EntProducto> BuscarProductoPorNombre(string nombre)
        {
            List<EntProducto> productos = new List<EntProducto>();

            using (SqlConnection connection = cn.Conectar())
            {
                string query = "SELECT ProductoId, Nombre, CategoriaId, SaboresId, Stock, Descontinuado, Imagen " +
                               "FROM Producto " +
                               "WHERE Nombre LIKE @Nombre";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%"); // Usamos el LIKE con comodín

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EntProducto producto = new EntProducto
                    {
                        Productoid = Convert.ToInt32(reader["ProductoId"]),
                        Nombre = reader["Nombre"].ToString(),
                        CategoriaId = Convert.ToInt32(reader["CategoriaId"]),
                        SaboresId = Convert.ToInt32(reader["SaboresId"]),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Descontinuado = Convert.ToBoolean(reader["Descontinuado"]),
                        Imagen = (byte[])reader["Imagen"]
                    };

                    productos.Add(producto);
                }
            }

            return productos;
        }
    }
}
