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
    public class DatAsignacionTransporte
    {
        private static readonly DatAsignacionTransporte _instancia = new DatAsignacionTransporte();

        public static DatAsignacionTransporte Instancia
        {
            get { return _instancia; }
        }
        public List<EntAsignacionTransporte> listarAsignacion()
        {

            SqlCommand cmd = null;
            List<EntAsignacionTransporte> lista = new List<EntAsignacionTransporte>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarAsignacionTransporte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntAsignacionTransporte ast = new EntAsignacionTransporte();
                    ast.AsignacionTransporteId = Convert.ToInt32(dr["AsignacionVehiculoId"]);
                    ast.OrdenPedidoId = Convert.ToInt32(dr["OrdenPedidoId"]);
                    ast.ConductorId = Convert.ToInt32(dr["ConductorId"].ToString());
                    ast.VehiculoId = Convert.ToInt32(dr["VehiculoId"].ToString());
                    ast.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(ast);
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
        public int InsertarConductor(EntConductor cond)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("InsertarConductor", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@tipoDocumentoId", cond.TipoDocumentoId);
                    cmd.Parameters.AddWithValue("@numeroDocumento", cond.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@nombre", cond.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cond.Apellido);
                    cmd.Parameters.AddWithValue("@licencia", cond.licencia);

                    // Parámetro de salida para obtener el ID del pedido generado
                    SqlParameter outputId = new SqlParameter("@conductorId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    cmd.ExecuteNonQuery();

                    return (int)outputId.Value; // Retornar el ID generado
                }
            }
        }

        public int InsertarVehiculo(EntVehiculo ve)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("InsertarVehiculo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@tipoVehiculo", ve.TipoVehiculo);
                    cmd.Parameters.AddWithValue("@matricula", ve.Matricula);

                    // Parámetro de salida para obtener el ID del pedido generado
                    SqlParameter outputId = new SqlParameter("@vehiculoId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    cmd.ExecuteNonQuery();

                    return (int)outputId.Value; // Retornar el ID generado
                }
            }
        }

        public Boolean InsertarAsignacion(EntAsignacionTransporte at)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarAsignacionTransporte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ordenPedidoId", at.OrdenPedidoId);
                cmd.Parameters.AddWithValue("@conductorId", at.ConductorId);
                cmd.Parameters.AddWithValue("@vehiculoId", at.VehiculoId);
                cmd.Parameters.AddWithValue("@estado", at.Estado);
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
    }
}
