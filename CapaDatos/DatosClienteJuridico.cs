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
    public class DatosClienteJuridico
    {
        private static readonly DatosClienteJuridico _instancia = new DatosClienteJuridico();
        public static DatosClienteJuridico Instancia => _instancia;

        // Obtener todos los clientes jurídicos
        public DataTable ObtenerTodosLosClientesJuridicos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    string query = @"
                SELECT CJ.ClienteId, C.Direccion, C.NumeroContacto, CJ.RazonSocial, CJ.NumeroDocumento
                FROM ClienteJuridico CJ
                INNER JOIN Cliente C ON CJ.ClienteId = C.ClienteId";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener clientes jurídicos: " + ex.Message);
            }
            return tabla;
        }
        public DataTable ListarClientesJuridicos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = @"SELECT 
                                c.ClienteId,
                                td.Nombre AS TipoDocumento,
                                cj.NumeroDocumento,
                                cj.RazonSocial,
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
                             INNER JOIN ClienteJuridico cj ON c.ClienteId = cj.ClienteId
                             INNER JOIN TipoDocumento td ON c.TipoDocumentoId = td.TipoDocumentoId
                             INNER JOIN Pais p ON c.PaisId = p.PaisId
                             INNER JOIN Region r ON c.RegionId = r.RegionId";

                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los clientes jurídicos: " + ex.Message);
            }
            return tabla;
        }

        // Insertar un cliente jurídico
        public bool InsertarClienteJuridico(Cliente cliente, Cliente_juridico clienteJuridico)
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

                        // Insertar en la tabla ClienteJuridico
                        string queryClienteJuridico = "INSERT INTO ClienteJuridico (ClienteId, NumeroDocumento, RazonSocial) " +
                                                      "VALUES (@ClienteId, @NumeroDocumento, @RazonSocial)";
                        SqlCommand cmdClienteJuridico = new SqlCommand(queryClienteJuridico, cn, tran);
                        cmdClienteJuridico.Parameters.AddWithValue("@ClienteId", clienteId);
                        cmdClienteJuridico.Parameters.AddWithValue("@NumeroDocumento", clienteJuridico.NumeroDocumento);
                        cmdClienteJuridico.Parameters.AddWithValue("@RazonSocial", clienteJuridico.RazonSocial);

                        cmdClienteJuridico.ExecuteNonQuery();

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
                throw new Exception("Error al insertar cliente jurídico en la base de datos: " + ex.Message);
            }
        }

        // Modificar un cliente jurídico
        public bool ModificarClienteJuridico(Cliente cliente, Cliente_juridico clienteJuridico)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlTransaction transaction = cn.BeginTransaction())
                {
                    try
                    {
                        // Usar DatosClienteBase para modificar cliente base
                        DatosClienteBase.Instancia.ModificarClienteBase(cliente, cn, transaction);

                        // Modificar cliente jurídico
                        string query = @"
                    UPDATE ClienteJuridico
                    SET RazonSocial = @RazonSocial, NumeroDocumento = @NumeroDocumento
                    WHERE ClienteId = @ClienteId";
                        using (SqlCommand cmd = new SqlCommand(query, cn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);
                            cmd.Parameters.AddWithValue("@RazonSocial", clienteJuridico.RazonSocial);
                            cmd.Parameters.AddWithValue("@NumeroDocumento", clienteJuridico.NumeroDocumento);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al modificar cliente jurídico: " + ex.Message);
                    }
                }
            }
        }

        // Eliminar un cliente jurídico
        public bool EliminarClienteJuridico(int clienteId)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlTransaction transaction = cn.BeginTransaction())
                {
                    try
                    {
                        // Eliminar cliente jurídico
                        string query = @"
                    DELETE FROM ClienteJuridico WHERE ClienteId = @ClienteId";
                        using (SqlCommand cmd = new SqlCommand(query, cn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                            cmd.ExecuteNonQuery();
                        }

                        // Usar DatosClienteBase para eliminar cliente base
                        DatosClienteBase.Instancia.EliminarClienteBase(clienteId, cn, transaction);

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al eliminar cliente jurídico: " + ex.Message);
                    }
                }
            }
        }
    }
}
