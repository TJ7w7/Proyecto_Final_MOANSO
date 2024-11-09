using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class dtCategoria
    {
        Conexion cn = new Conexion();

        private static readonly dtCategoria _instancia = new dtCategoria();
        public static dtCategoria Instancia
        {
            get
            {
                return dtCategoria._instancia;
            }
        }

        public bool GuardaCategoria(EntCategoria categoria)
        {
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "INSERT INTO Categoria (Nombre, Estado) " +
                               "VALUES (@Nombre, @Estado)";

                SqlCommand gp = new SqlCommand(query, connection);
                gp.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                gp.Parameters.AddWithValue("@Estado", categoria.Estado);

                connection.Open();
                int rowsAffected = gp.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }
}
