using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatCategoria
    {
        private static DatCategoria _instancia = new DatCategoria();
        public static DatCategoria Instancia 
        {
            get {return _instancia;}
        }

        public List<EntCategoria> listarCategoria()
        {

            SqlCommand cmd = null;
            List<EntCategoria> lista = new List<EntCategoria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntCategoria Cat = new EntCategoria();
                    Cat.CategoriaId = Convert.ToInt32(dr["CategoriaId"]);
                    Cat.Nombre = dr["Nombre"].ToString();
                    Cat.Descripcion = dr["Descripcion"].ToString();
                    Cat.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Cat);
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarCategoria(EntCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Cat.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", Cat.Descripcion);
                cmd.Parameters.AddWithValue("@estado", Cat.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        public Boolean EditarCategoria(EntCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Cat.CategoriaId);
                cmd.Parameters.AddWithValue("@nombre", Cat.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", Cat.Descripcion);
                cmd.Parameters.AddWithValue("@estado", Cat.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }
    }
}
