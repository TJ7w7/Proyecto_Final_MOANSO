﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatDivisionesAdministrativas
    {
        #region Singleton
        private static readonly DatDivisionesAdministrativas _instancia = new DatDivisionesAdministrativas();
        public static DatDivisionesAdministrativas Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        // Método para obtener las divisiones administrativas
        public List<EntDivisionesAdministrativas> ObtenerDivisionesAdministrativas()
        {
            List<EntDivisionesAdministrativas> lista = new List<EntDivisionesAdministrativas>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = "SELECT DivisionesAdministrativasId, Nombre, CodigodeArea, Estado FROM DivisionesAdministrativas";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            EntDivisionesAdministrativas division = new EntDivisionesAdministrativas
                            {
                                DivisionesAdministrativasId = Convert.ToInt32(dr["DivisionesAdministrativasId"]),
                                Nombre = dr["Nombre"].ToString(),
                                CodigodeArea = Convert.ToInt32(dr["CodigodeArea"]),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            };
                            lista.Add(division);
                        }
                    }
                }
            }
            return lista;
        }

        public bool CambiarEstadoDivision(int id, bool nuevoEstado)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = "UPDATE DivisionesAdministrativas SET Estado = @Estado WHERE DivisionesAdministrativasId = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public List<string> ObtenerNombres()
        {
            List<string> nombres = new List<string>();
            SqlConnection cn = null;
            try
            {
                cn = Conexion.Instancia.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT Nombre FROM DivisionesAdministrativas WHERE Estado = 1", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nombres.Add(dr["Nombre"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los nombres: " + ex.Message);
            }
            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return nombres;
        }

        public int ObtenerCodigoDeArea(string nombre)
        {
            int codigoDeArea = 0;
            SqlConnection cn = null;
            try
            {
                cn = Conexion.Instancia.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT CodigodeArea FROM DivisionesAdministrativas WHERE Nombre = @Nombre AND Estado = 1", cn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    codigoDeArea = Convert.ToInt32(dr["CodigodeArea"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el código de área: " + ex.Message);
            }
            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return codigoDeArea;
        }
    }
}