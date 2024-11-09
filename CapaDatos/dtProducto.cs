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
                string query = "INSERT INTO Producto (Nombre, Descripcion, Precio, Stock, IGV, Descontinuado, Imagen) " +
                               "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @IGV, @Descontinuado, @Imagen)";

                SqlCommand gp = new SqlCommand(query, connection);
                gp.Parameters.AddWithValue("@Nombre", producto.Nombre);
                gp.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                gp.Parameters.AddWithValue("@Peso", producto.Peso);
                gp.Parameters.AddWithValue("@Color", producto.Color);
                gp.Parameters.AddWithValue("@Precio", producto.Precio);
                gp.Parameters.AddWithValue("@Stock", producto.Stock);
                gp.Parameters.AddWithValue("@IGV", producto.IGV);
                gp.Parameters.AddWithValue("@Descontinuado", producto.Descontinuado);
                gp.Parameters.AddWithValue("@Imagen", producto.Imagen);

                connection.Open();
                int rowsAffected = gp.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

    }
}
