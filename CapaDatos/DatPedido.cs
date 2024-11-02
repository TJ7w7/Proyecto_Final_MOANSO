using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatPedido
    {
        #region Singleton
        private static readonly DatPedido _instancia = new DatPedido();

        public static DatPedido Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion Singleton

        public bool InsertarPedido(EntPedido pedido)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertaOrdenPedido", cn);
                cmd.Parameters.AddWithValue("@IDPedido", pedido.IDPedido);
                cmd.Parameters.AddWithValue("@RUC", pedido.RUC);
                cmd.Parameters.AddWithValue("@Nombre", pedido.Nombre);
                cmd.Parameters.AddWithValue("@Region", pedido.Region);
                cmd.Parameters.AddWithValue("@Celular", pedido.Celular);
                cmd.Parameters.AddWithValue("@IDProducto", pedido.IDProducto);
                cmd.Parameters.AddWithValue("@Categoria", pedido.Categoria);
                cmd.Parameters.AddWithValue("@Producto", pedido.Producto);
                cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", pedido.Precio);
                cmd.Parameters.AddWithValue("@NumerodeCasa", pedido.NumerodeCasa);
                cmd.Parameters.AddWithValue("@CalleCorea", pedido.CalleCorea);
                cmd.Parameters.AddWithValue("@EstadodelPedido", pedido.EstadodelPedido);
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
            finally { cmd.Connection.Close(); }
            return inserta;
        }
    }


}
