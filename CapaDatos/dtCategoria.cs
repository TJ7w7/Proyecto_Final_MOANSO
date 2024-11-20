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
        public bool ActualizarCategoria(EntCategoria categoria)
        {
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "UPDATE Categoria SET Nombre = @Nombre, Estado = @Estado WHERE CategoriaId = @CategoriaId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CategoriaId", categoria.CategoriaId);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Estado", categoria.Estado);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        public bool EliminarCategoria(int categoriaId)
        {
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "DELETE FROM Categoria WHERE CategoriaId = @CategoriaId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // Retorna true si se eliminó correctamente
            }
        }
        public List<EntCategoria> ListarCategorias()
        {
            List<EntCategoria> lista = new List<EntCategoria>();
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "SELECT CategoriaId, Nombre, Estado FROM Categoria";
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new EntCategoria
                    {
                        CategoriaId = Convert.ToInt32(dr["CategoriaId"]),
                        Nombre = dr["Nombre"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    });
                }
            }
            return lista;
        }
        public List<EntCategoria> ListarCategoriasEnCMB()
        {
            List<EntCategoria> lista = new List<EntCategoria>();
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "SELECT CategoriaId, Nombre FROM Categoria";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new EntCategoria
                    {
                        CategoriaId = Convert.ToInt32(dr["CategoriaId"]),
                        Nombre = dr["Nombre"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
