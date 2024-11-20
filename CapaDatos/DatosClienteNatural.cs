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
    public class DatosClienteNatural
    {
        // Singleton
        private static readonly DatosClienteNatural _instancia = new DatosClienteNatural();
        public static DatosClienteNatural Instancia => _instancia;

        // Obtener todos los clientes naturales
        public DataTable ObtenerTodosLosClientesNaturales()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = @"
                SELECT CN.ClienteNaturalId, C.ClienteId, C.Direccion, C.NumeroContacto, 
                       CN.Nombres, CN.Apellidos
                FROM ClienteNatural CN
                INNER JOIN Cliente C ON CN.ClienteId = C.ClienteId";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los clientes naturales: " + ex.Message);
            }
            return tabla;
        }
        public DataTable ListarClientesNaturales()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    // Consulta SQL ajustada para ClienteNatural
                    string query = @"
                SELECT 
                    c.ClienteId,
                    td.Nombre AS TipoDocumento,
                    cn.NroDocumento,
                    cn.Nombres,
                    cn.Apellidos,
                    p.Nombre AS Pais,
                    r.Nombre AS Region,
                    c.Direccion,
                    c.NumeroContacto,
                    CASE 
                        WHEN c.Estado = 1 THEN 'Activo' 
                        ELSE 'Inactivo' 
                    END AS Estado
                FROM 
                    Cliente c
                INNER JOIN ClienteNatural cn ON c.ClienteId = cn.ClienteId
                INNER JOIN TipoDocumento td ON c.TipoDocumentoId = td.TipoDocumentoId
                INNER JOIN Pais p ON c.PaisId = p.PaisId
                INNER JOIN Region r ON c.RegionId = r.RegionId";

                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los clientes naturales: " + ex.Message);
            }
            return tabla;
        }


        // Insertar un cliente natural
        public bool InsertarClienteNatural(Cliente cliente, Cliente_natural clienteNatural)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    SqlTransaction tran = cn.BeginTransaction();
                    try
                    {
                        // Insertar en la tabla Cliente
                        string queryCliente = "INSERT INTO Cliente (TipoDocumentoId, PaisId, RegionId, Direccion, NumeroContacto, Estado) " +
                                              "OUTPUT INSERTED.ClienteId VALUES (@TipoDocumentoId, @PaisId, @RegionId, @Direccion, @NumeroContacto, @Estado)";
                        SqlCommand cmdCliente = new SqlCommand(queryCliente, cn, tran);
                        cmdCliente.Parameters.AddWithValue("@TipoDocumentoId", cliente.TipoDocumentoId);
                        cmdCliente.Parameters.AddWithValue("@PaisId", cliente.PaisId);
                        cmdCliente.Parameters.AddWithValue("@RegionId", cliente.RegionId);
                        cmdCliente.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                        cmdCliente.Parameters.AddWithValue("@NumeroContacto", cliente.NumeroContacto);
                        cmdCliente.Parameters.AddWithValue("@Estado", cliente.Estado);

                        int clienteId = (int)cmdCliente.ExecuteScalar(); // Obtén el ID del cliente insertado

                        // Insertar en la tabla ClienteNatural
                        string queryClienteNatural = "INSERT INTO ClienteNatural (ClienteId, NroDocumento, Nombres, Apellidos) " +
                                                      "VALUES (@ClienteId, @NroDocumento, @Nombres, @Apellidos)";
                        SqlCommand cmdClienteNatural = new SqlCommand(queryClienteNatural, cn, tran);
                        cmdClienteNatural.Parameters.AddWithValue("@ClienteId", clienteId);
                        cmdClienteNatural.Parameters.AddWithValue("@NroDocumento", clienteNatural.NroDocumento);
                        cmdClienteNatural.Parameters.AddWithValue("@Nombres", clienteNatural.Nombres);
                        cmdClienteNatural.Parameters.AddWithValue("@Apellidos", clienteNatural.Apellidos);

                        cmdClienteNatural.ExecuteNonQuery();

                        // Confirmar la transacción
                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente natural en la base de datos: " + ex.Message);
            }
        }

        // Modificar un cliente natural
        public bool ModificarClienteNatural(Cliente cliente, Cliente_natural clienteNatural)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlTransaction transaccion = cn.BeginTransaction())
                {
                    try
                    {
                        // Usar DatosClienteBase para modificar cliente base
                        DatosClienteBase.Instancia.ModificarClienteBase(cliente, cn, transaccion);

                        // Modificar cliente natural
                        string clienteNaturalQuery = @"
                    UPDATE ClienteNatural
                    SET NroDocumento = @NroDocumento, Nombres = @Nombres, Apellidos = @Apellidos
                    WHERE ClienteId = @ClienteId";
                        using (SqlCommand cmd = new SqlCommand(clienteNaturalQuery, cn, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);
                            cmd.Parameters.AddWithValue("@NroDocumento", clienteNatural.NroDocumento);
                            cmd.Parameters.AddWithValue("@Nombres", clienteNatural.Nombres);
                            cmd.Parameters.AddWithValue("@Apellidos", clienteNatural.Apellidos);
                            cmd.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        // Eliminar un cliente natural
        public bool EliminarClienteNatural(int clienteId)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlTransaction transaccion = cn.BeginTransaction())
                {
                    try
                    {
                        // Eliminar cliente natural
                        string clienteNaturalQuery = @"
                    DELETE FROM ClienteNatural WHERE ClienteId = @ClienteId";
                        using (SqlCommand cmd = new SqlCommand(clienteNaturalQuery, cn, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                            cmd.ExecuteNonQuery();
                        }

                        // Usar DatosClienteBase para eliminar cliente base
                        DatosClienteBase.Instancia.EliminarClienteBase(clienteId, cn, transaccion);

                        transaccion.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

    }
}
