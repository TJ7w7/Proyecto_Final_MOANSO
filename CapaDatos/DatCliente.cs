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
    public class DatCliente
    {
        private static readonly DatCliente _instancia = new DatCliente();
        public static DatCliente Instancia
        {
            get { return _instancia; }
        }
        #region MetodosClienteJuridico
        public List<EntClienteJuridico> ListarClienteJuridico()
        {
            SqlCommand cmd = null;
            List<EntClienteJuridico> listaClienteJuridico = new List<EntClienteJuridico>();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("ListarClienteJuridico", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntClienteJuridico cli = new EntClienteJuridico();
                        cli.ClienteId = Convert.ToInt32(dr["ClienteId"]);
                        cli.TipoDocumentoId = Convert.ToInt32(dr["TipoDocumentoId"]);
                        cli.TipoDocumento = dr["TipoDocumento"].ToString();
                        cli.NumeroDocumento = dr["NumeroDocumento"].ToString();
                        cli.PaisId = Convert.ToInt32(dr["PaisId"]);
                        cli.Pais = dr["Pais"].ToString();
                        cli.RegionId = Convert.ToInt32(dr["RegionId"]);
                        cli.Region = dr["Region"].ToString();
                        cli.Direccion = dr["Direccion"].ToString();
                        cli.NumeroContacto = dr["NumeroContacto"].ToString();
                        cli.Estado = Convert.ToBoolean(dr["Estado"]);
                        cli.RazonSocial = dr["RazonSocial"].ToString();
                        listaClienteJuridico.Add(cli);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clientes jurídicos", ex);
            }

            return listaClienteJuridico;
        }
        public bool InsertarClienteJuridico(EntCliente cliente, EntClienteJuridico clienteJuridico)
        {
            SqlCommand cmd = null;
            SqlTransaction transaction = null;
            bool inserta = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    transaction = cn.BeginTransaction();

                    cmd = new SqlCommand("InsertarCliente", cn, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tipoDocumentoId", cliente.TipoDocumentoId);
                    cmd.Parameters.AddWithValue("@numeroDocumento", cliente.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@paisId", cliente.PaisId);
                    cmd.Parameters.AddWithValue("@regionId", cliente.RegionId);
                    cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                    cmd.Parameters.AddWithValue("@numeroContacto", cliente.NumeroContacto);
                    cmd.Parameters.AddWithValue("@estado", cliente.Estado);

                    int clienteId = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd = new SqlCommand("InsertarClienteJuridico", cn, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clienteId", clienteId);
                    cmd.Parameters.AddWithValue("@razonSocial", clienteJuridico.RazonSocial);
                    cmd.ExecuteNonQuery();

                    // Confirmar transacción
                    transaction.Commit();
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                // Revertir la transacción en caso de error
                transaction?.Rollback();
                throw ex;
            }
            return inserta;
        }
        public bool EditarClienteJuridico(EntClienteJuridico cliente)
        {
            bool edita = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("EditarClienteJuridico", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@clienteId", cliente.ClienteId);
                        cmd.Parameters.AddWithValue("@tipoDocumentoId", cliente.TipoDocumentoId);
                        cmd.Parameters.AddWithValue("@numeroDocumento", cliente.NumeroDocumento);
                        cmd.Parameters.AddWithValue("@paisId", cliente.PaisId);
                        cmd.Parameters.AddWithValue("@regionId", cliente.RegionId);
                        cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                        cmd.Parameters.AddWithValue("@numeroContacto", cliente.NumeroContacto);
                        cmd.Parameters.AddWithValue("@estado", cliente.Estado);
                        cmd.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);


                        cn.Open();
                        int i = cmd.ExecuteNonQuery();
                        edita = i > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el cliente jurídico.", ex);
            }

            return edita;
        }

        #endregion

        #region MetodosClienteNatural
        public List<EntClienteNatural> listarClienteNaturale()
        {
            SqlCommand cmd = null;
            List<EntClienteNatural> listaClienteNaturale = new List<EntClienteNatural>();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("ListarClientesNaturales", cn); // Procedimiento para obtener solo los clientes naturales
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntClienteNatural cli = new EntClienteNatural();
                        cli.ClienteId = Convert.ToInt32(dr["ClienteId"]);
                        cli.TipoDocumentoId = Convert.ToInt32(dr["TipoDocumentoId"]);
                        cli.NumeroDocumento = dr["NroDocumento"].ToString();
                        cli.PaisId = Convert.ToInt32(dr["PaisId"]);
                        cli.RegionId = Convert.ToInt32(dr["RegionId"]);
                        cli.Direccion = dr["Direccion"].ToString();
                        cli.NumeroContacto = dr["NumeroContacto"].ToString();
                        cli.Estado = Convert.ToBoolean(dr["Estado"]);
                        cli.Nombres = dr["Nombres"].ToString();
                        cli.Apellidos = dr["Apellidos"].ToString();
                        listaClienteNaturale.Add(cli);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clientes naturales", ex);
            }

            return listaClienteNaturale;
        }

        public bool InsertarClienteNatural(EntCliente cliente, EntClienteNatural clienteNatural)
        {
            SqlCommand cmd = null;
            SqlTransaction transaction = null;
            bool inserta = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    transaction = cn.BeginTransaction();

                    cmd = new SqlCommand("InsertarCliente", cn, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tipoDocumentoId", cliente.TipoDocumentoId);
                    cmd.Parameters.AddWithValue("@numeroDocumento", cliente.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@paisId", cliente.PaisId);
                    cmd.Parameters.AddWithValue("@regionId", cliente.RegionId);
                    cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                    cmd.Parameters.AddWithValue("@numeroContacto", cliente.NumeroContacto);
                    cmd.Parameters.AddWithValue("@estado", cliente.Estado);

                    int clienteId = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd = new SqlCommand("InsertarClienteNatural", cn, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clienteId", clienteId);
                    cmd.Parameters.AddWithValue("@nombres", clienteNatural.Nombres);
                    cmd.Parameters.AddWithValue("@apellidos", clienteNatural.Apellidos);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                // Revertir la transacción en caso de error
                transaction?.Rollback();
                throw ex;
            }
            return inserta;
        }
        #endregion


    }
}
