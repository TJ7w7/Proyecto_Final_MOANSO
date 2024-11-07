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
    internal class dtProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly dtProducto _instancia = new dtProducto();
        //privado para evitar la instanciación directa
        public static dtProducto Instancia
        {
            get
            {
                return dtProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<EntProducto> ListarCliente()
        {
            SqlCommand cmd = null;
            List<EntProducto> lista = new List<EntProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); 
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntProducto Pdto = new EntProducto();
                    Pdto.Productoid = Convert.ToInt32(dr["idProducto"]);
                    Pdto.Nombre = dr["Nombre"].ToString();
                    Pdto.Descripcion = dr["Descripcion"].ToString();
                    Pdto.Precio = Convert.ToInt32(dr["Precio"]);
                    Pdto.Stock = Convert.ToInt32(dr["Stock"]);
                    Pdto.Porcentaje = Convert.ToInt32(dr["Procentaje"]);
                    Pdto.IGV = Convert.ToInt32(dr["IGV"]);
                    Pdto.Descontinuado = Convert.ToBoolean(dr["Descontinuado"]);
                    lista.Add(Pdto);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        #endregion singleton
    }
}
