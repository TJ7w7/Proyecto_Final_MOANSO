using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class dtSabores
    {
        Conexion cn = new Conexion();

        private static readonly dtSabores _instancia = new dtSabores();
        public static dtSabores Instancia
        {
            get
            {
                return dtSabores._instancia;
            }
        }

        public bool GuardarSabores(EntSabores sabores)
        {
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "INSERT INTO Sabores (Nombre, Estado) " +
                               "VALUES (@Nombre, @Estado)";

                SqlCommand gp = new SqlCommand(query, connection);
                gp.Parameters.AddWithValue("@Nombre", sabores.Nombre);
                gp.Parameters.AddWithValue("@Estado", sabores.Estado);

                connection.Open();
                int rowsAffected = gp.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        public bool ModificarSabores(EntSabores sabores)
        {
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "UPDATE Sabores SET Nombre = @Nombre, Estado = @Estado WHERE SaboresId = @SaboresId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SaboresId", sabores.SaboresId);
                cmd.Parameters.AddWithValue("@Nombre", sabores.Nombre);
                cmd.Parameters.AddWithValue("@Estado", sabores.Estado);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        public bool EliminarSabores(int saboresid)
        {
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "DELETE FROM Sabores WHERE SaboresId = @SaboresId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SaboresId", saboresid);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; 
            }
        }
        public List<EntSabores> ListarSabores()
        {
            List<EntSabores> listaS = new List<EntSabores>();
            using (SqlConnection connection = cn.Conectar())
            {
                string query = "SELECT SaboresId, Nombre, Estado FROM Sabores";
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaS.Add(new EntSabores
                    {
                        SaboresId = Convert.ToInt32(dr["SaboresId"]),
                        Nombre = dr["Nombre"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    });
                }
            }
            return listaS;
        }
    }
}

