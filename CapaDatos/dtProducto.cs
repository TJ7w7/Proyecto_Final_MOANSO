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

        public bool GuardaProducto(EntProducto producto)
        {
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "INSERT INTO Producto (Nombre, CategoriaId, SaboresId, Descripcion, Stock, Descontinuado, Imagen) " +
                               "VALUES (@Nombre, @CategoriaId, @SaboresId, @Descripcion, @Stock, @Descontinuado, @Imagen)";

                SqlCommand gp = new SqlCommand(query, connection);
                gp.Parameters.AddWithValue("@Nombre", producto.Nombre);
                gp.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                gp.Parameters.AddWithValue("@SaboresId", producto.SaboresId);
                gp.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                gp.Parameters.AddWithValue("@Stock", producto.Stock);
                gp.Parameters.AddWithValue("@Descontinuado", producto.Descontinuado);
                gp.Parameters.AddWithValue("@Imagen", producto.Imagen);


                connection.Open();
                int rowsAffected = gp.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

    }
}
