using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WCFServiceActividad.Dominio;

namespace WCFServiceActividad.Persistencia
{
    public class ActividadDAO
    {
        private string CadenaConexion = @"Data Source=LDTHINKPAD\LDSQLSERVER16;Initial Catalog=DB_DSD_GOV;User ID=sa;Password=root;";

        public Actividad Crear(Actividad actividadACrear)
        {
            Actividad actividadCreada = null;
            string sp = "dbo.sp_mantenimiento_actividad";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sp, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@dAccion", "I");
                    comando.Parameters.AddWithValue("@nActividad", actividadACrear.nActividad);
                    comando.Parameters.AddWithValue("@cOportunidad", actividadACrear.cOportunidad);
                    comando.Parameters.AddWithValue("@cCliente", actividadACrear.cCliente);
                    comando.Parameters.AddWithValue("@dRazonSocial", actividadACrear.dRazonSocial);
                    comando.Parameters.AddWithValue("@dPersonaContacto", actividadACrear.dPersonaContacto);
                    comando.Parameters.AddWithValue("@nTelefono", actividadACrear.nTelefono);
                    comando.Parameters.AddWithValue("@fInicio", actividadACrear.fInicio);
                    comando.Parameters.AddWithValue("@fFin", actividadACrear.fFin);
                    comando.Parameters.AddWithValue("@cTipoActividad", actividadACrear.cTipoActividad);
                    comando.Parameters.AddWithValue("@cNivelPrioridad", actividadACrear.cNivelPrioridad);
                    comando.Parameters.AddWithValue("@cTipoRepeticion", actividadACrear.cTipoRepeticion);
                    comando.Parameters.AddWithValue("@dComentarios", actividadACrear.dComentarios);
                    comando.Parameters.AddWithValue("@sEstado", actividadACrear.sEstado);                    
                    comando.ExecuteNonQuery();
                }
            }
            actividadCreada = Obtener(actividadACrear.nActividad);
            return actividadCreada;
        }

        public Actividad Obtener(string nActividad)
        {
            Actividad actividadEncontrada = null;
            string sql = "select * from actividad where nActividad = @nactividad;";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nactividad", nActividad));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            actividadEncontrada = new Actividad()
                            {
                                nActividad = (string)resultado["nActividad"],
                                cOportunidad = (string)resultado["cOportunidad"],
                                cCliente = (string)resultado["cCliente"],
                                dRazonSocial = (string)resultado["dRazonSocial"],
                                dPersonaContacto = (string)resultado["dPersonaContacto"],
                                nTelefono = (string)resultado["nTelefono"],
                                fInicio = (Nullable<DateTime>)resultado["fInicio"],
                                fFin = (Nullable<DateTime>)resultado["fFin"],
                                cTipoActividad = (string)resultado["cTipoActividad"],
                                cNivelPrioridad = (string)resultado["cNivelPrioridad"],
                                cTipoRepeticion = (string)resultado["cTipoRepeticion"],
                                dComentarios = (string)resultado["dComentarios"],
                                sEstado = (string)resultado["sEstado"],
                                fRegistro = (Nullable<DateTime>)resultado["fRegistro"],
                                fModificacion = (Nullable<DateTime>)resultado["fModificacion"],
                                cUsuario = (string)resultado["cUsuario"],
                            };
                        }
                    }
                }

            }
            return actividadEncontrada;
        }

        public Actividad Modificar(Actividad actividadAModificar)
        {
            Actividad actividadModificada = null;
            string sp = "dbo.sp_mantenimiento_actividad";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sp, conexion))
                {
                    comando.Parameters.AddWithValue("@dAccion", "U");
                    comando.Parameters.AddWithValue("@dRazonSocial", actividadAModificar.dRazonSocial);
                    comando.Parameters.AddWithValue("@dPersonaContacto", actividadAModificar.dPersonaContacto);
                    comando.Parameters.AddWithValue("@nTelefono", actividadAModificar.nTelefono);
                    comando.Parameters.AddWithValue("@fInicio", actividadAModificar.fInicio);
                    comando.Parameters.AddWithValue("@fFin", actividadAModificar.fFin);
                    comando.Parameters.AddWithValue("@cTipoActividad", actividadAModificar.cTipoActividad);
                    comando.Parameters.AddWithValue("@cNivelPrioridad", actividadAModificar.cNivelPrioridad);
                    comando.Parameters.AddWithValue("@cTipoRepeticion", actividadAModificar.cTipoRepeticion);
                    comando.Parameters.AddWithValue("@dComentarios", actividadAModificar.dComentarios);
                    comando.Parameters.AddWithValue("@sEstado", actividadAModificar.sEstado);
                    comando.Parameters.AddWithValue("@nActividad", actividadAModificar.nActividad);
                    comando.ExecuteNonQuery();
                }
            }
            actividadModificada = Obtener(actividadAModificar.nActividad);
            return actividadModificada;
        }

        public void Eliminar(string nActividad)
        {
            string sql = "delete from actividad where nActividad = @nactividad";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nactividad", nActividad));
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Actividad> Listar()
        {
            List<Actividad> actividadesEncontradas = new List<Actividad>();
            Actividad actividadEncontrada = null;
            string sql = "select * from actividad";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            actividadEncontrada = new Actividad()
                            {
                                nActividad = (string)resultado["nActividad"],
                                cOportunidad = (string)resultado["cOportunidad"],
                                cCliente = (string)resultado["cCliente"],
                                dRazonSocial = (string)resultado["dRazonSocial"],
                                dPersonaContacto = (string)resultado["dPersonaContacto"],
                                nTelefono = (string)resultado["nTelefono"],
                                fInicio = (Nullable<DateTime>)resultado["fInicio"],
                                fFin = (Nullable<DateTime>)resultado["fFin"],
                                cTipoActividad = (string)resultado["cTipoActividad"],
                                cNivelPrioridad = (string)resultado["cNivelPrioridad"],
                                cTipoRepeticion = (string)resultado["cTipoRepeticion"],
                                dComentarios = (string)resultado["dComentarios"],
                                sEstado = (string)resultado["sEstado"],
                                fRegistro = (Nullable<DateTime>)resultado["fRegistro"],
                                fModificacion = (Nullable<DateTime>)resultado["fModificacion"],
                                cUsuario = (string)resultado["cUsuario"],
                            };
                            actividadesEncontradas.Add(actividadEncontrada);
                        }
                    }
                }

            }

            return actividadesEncontradas;
        }

        public List<Actividad> ListarActividadesPorUsuarioEstado(string cUsuario, string cOportunidad, string cCliente)
        {
            List<Actividad> actividadesEncontradas = new List<Actividad>();
            Actividad actividadEncontrada = null;
            string sql = "select * from actividad where cUsuario = @cUsuario and cOportunidad = @cOportunidad and cCliente = @cCliente;";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@cUsuario", cUsuario));
                    comando.Parameters.Add(new SqlParameter("@cOportunidad", cOportunidad));
                    comando.Parameters.Add(new SqlParameter("@cCliente", cCliente));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            actividadEncontrada = new Actividad()
                            {
                                nActividad = (string)resultado["nActividad"],
                                cOportunidad = (string)resultado["cOportunidad"],
                                cCliente = (string)resultado["cCliente"],
                                dRazonSocial = (string)resultado["dRazonSocial"],
                                dPersonaContacto = (string)resultado["dPersonaContacto"],
                                nTelefono = (string)resultado["nTelefono"],
                                fInicio = (Nullable<DateTime>)resultado["fInicio"],
                                fFin = (Nullable<DateTime>)resultado["fFin"],
                                cTipoActividad = (string)resultado["cTipoActividad"],
                                cNivelPrioridad = (string)resultado["cNivelPrioridad"],
                                cTipoRepeticion = (string)resultado["cTipoRepeticion"],
                                dComentarios = (string)resultado["dComentarios"],
                                sEstado = (string)resultado["sEstado"],
                                fRegistro = (Nullable<DateTime>)resultado["fRegistro"],
                                fModificacion = (Nullable<DateTime>)resultado["fModificacion"],
                                cUsuario = (string)resultado["cUsuario"],
                            };
                            actividadesEncontradas.Add(actividadEncontrada);
                        }
                    }
                }

            }

            return actividadesEncontradas;
        }

        public Actividad ValidarUsuario(string cUsuario)
        {
            Actividad actividadEncontrada = null;
            string sql = "select * from usuario where cusuario = @cusuario";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@cusuario", cUsuario));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            actividadEncontrada = new Actividad()
                            {
                                sEstado = (string)resultado["sEstado"],
                            };
                        }
                    }
                }

            }
            return actividadEncontrada;
        }
    }
}