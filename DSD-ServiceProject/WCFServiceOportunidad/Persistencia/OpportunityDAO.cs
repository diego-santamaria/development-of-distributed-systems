using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServiceOportunidad.Comunes;
using WCFServiceOportunidad.Dominio;

namespace WCFServiceOportunidad.Persistencia
{
    public class OpportunityDAO
    {

        private string connectionString = Properties.Settings.Default.sConnectionString;

        internal List<Oportunidad> ListWithParameters(string codigo, string codcliente, string nombcliente, string personacontact)
        {
            List<Oportunidad> opportList = new List<Oportunidad>();
            string sql = "SELECT [Codigo],[Estado],[CodCliente],[NombreCliente],[PersonaContact],[TelefCliente] " + 
                            ",[EmailCliente],[NroPlaca],[NroSerie],[NroVIN],[NroMotor],[Marca],[Modelo] " +
                            ",[PlacaVigente],[Anotaciones] FROM [dbo].[Opportunity] WHERE " +
                "   ([Codigo] LIKE @codigo + '%' OR @codigo IS NULL) AND " +
                "   ([Codcliente] LIKE @codcliente + '%' OR @codcliente IS NULL) AND " +
                "   ([NombreCliente] LIKE '%' + @nombcliente + '%' OR @nombcliente IS NULL) AND " +
                "   ([PersonaContact] LIKE '%' + @personacontact + '%' OR @personacontact IS NULL) ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@codigo", codigo ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@codcliente", codcliente ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@nombcliente", nombcliente ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@personacontact", personacontact ?? (object)DBNull.Value);

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            opportList.Add(new Oportunidad()
                            {
                                Codigo = Useful.isText(dataReader["Codigo"]).Trim(),
                                Estado = Useful.isText(dataReader["Estado"]),
                                CodCliente = Useful.isText(dataReader["CodCliente"]),
                                NombreCliente = Useful.isText(dataReader["NombreCliente"]),
                                PersonaContact = Useful.isText(dataReader["PersonaContact"]),
                                TelefCliente = Useful.isText(dataReader["TelefCliente"]),
                                EmailCliente = Useful.isText(dataReader["EmailCliente"]),
                                NroPlaca = Useful.isText(dataReader["NroPlaca"]),
                                NroSerie = Useful.isText(dataReader["NroSerie"]),
                                NroVIN = Useful.isText(dataReader["NroVIN"]),
                                NroMotor = Useful.isText(dataReader["NroMotor"]),
                                Marca = Useful.isText(dataReader["Marca"]),
                                Modelo = Useful.isText(dataReader["Modelo"]),
                                PlacaVigente = Useful.isText(dataReader["PlacaVigente"]),
                                Anotaciones = Useful.isText(dataReader["Anotaciones"]),
                            });
                        }
                    }
                }
            }
            return opportList;
        }

        internal List<Oportunidad> List()
        {
            List<Oportunidad> opportList = new List<Oportunidad>();
            string sql = "SELECT [Codigo],[Estado],[CodCliente],[NombreCliente],[PersonaContact],[TelefCliente] " +
                            ",[EmailCliente],[NroPlaca],[NroSerie],[NroVIN],[NroMotor],[Marca],[Modelo] " +
                            ",[PlacaVigente],[Anotaciones] FROM [dbo].[Opportunity] ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            opportList.Add(new Oportunidad()
                            {
                                Codigo = Useful.isText(dataReader["Codigo"]).Trim(),
                                Estado = Useful.isText(dataReader["Estado"]),
                                CodCliente = Useful.isText(dataReader["CodCliente"]),
                                NombreCliente = Useful.isText(dataReader["NombreCliente"]),
                                PersonaContact = Useful.isText(dataReader["PersonaContact"]),
                                TelefCliente = Useful.isText(dataReader["TelefCliente"]),
                                EmailCliente = Useful.isText(dataReader["EmailCliente"]),
                                NroPlaca = Useful.isText(dataReader["NroPlaca"]),
                                NroSerie = Useful.isText(dataReader["NroSerie"]),
                                NroVIN = Useful.isText(dataReader["NroVIN"]),
                                NroMotor = Useful.isText(dataReader["NroMotor"]),
                                Marca = Useful.isText(dataReader["Marca"]),
                                Modelo = Useful.isText(dataReader["Modelo"]),
                                PlacaVigente = Useful.isText(dataReader["PlacaVigente"]),
                                Anotaciones = Useful.isText(dataReader["Anotaciones"]),
                            });
                        }
                    }
                }
            }
            return opportList;
        }

        internal Oportunidad Get(string codigo)
        {
            Oportunidad oportunidad = null;
            string sql = "SELECT [Codigo],[Estado],[CodCliente],[NombreCliente],[PersonaContact],[TelefCliente] " +
                            ",[EmailCliente],[NroPlaca],[NroSerie],[NroVIN],[NroMotor],[Marca],[Modelo] " +
                            ",[PlacaVigente],[Anotaciones] FROM [dbo].[Opportunity] WHERE [Codigo] = @codigo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@codigo", codigo ?? (object)DBNull.Value);

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            oportunidad = new Oportunidad()
                            {
                                Codigo = Useful.isText(dataReader["Codigo"]).Trim(),
                                Estado = Useful.isText(dataReader["Estado"]),
                                CodCliente = Useful.isText(dataReader["CodCliente"]),
                                NombreCliente = Useful.isText(dataReader["NombreCliente"]),
                                PersonaContact = Useful.isText(dataReader["PersonaContact"]),
                                TelefCliente = Useful.isText(dataReader["TelefCliente"]),
                                EmailCliente = Useful.isText(dataReader["EmailCliente"]),
                                NroPlaca = Useful.isText(dataReader["NroPlaca"]),
                                NroSerie = Useful.isText(dataReader["NroSerie"]),
                                NroVIN = Useful.isText(dataReader["NroVIN"]),
                                NroMotor = Useful.isText(dataReader["NroMotor"]),
                                Marca = Useful.isText(dataReader["Marca"]),
                                Modelo = Useful.isText(dataReader["Modelo"]),
                                PlacaVigente = Useful.isText(dataReader["PlacaVigente"]),
                                Anotaciones = Useful.isText(dataReader["Anotaciones"]),
                            };
                        }
                    }
                }
            }
            return oportunidad;
        }

        internal Oportunidad Create(Oportunidad oportunidad)
        {
            Oportunidad obj = null;
            string sql = "INSERT INTO [dbo].[Opportunity] " +
                            "([Codigo],[Estado],[CodCliente],[NombreCliente],[PersonaContact] " +
                            ",[TelefCliente],[EmailCliente],[NroPlaca],[NroSerie],[NroVIN] " +
                            ",[NroMotor],[Marca],[Modelo],[PlacaVigente],[Anotaciones]) VALUES " +
                            "(@Codigo, @Estado, @CodCliente, @NombreCliente, @PersonaContact, @TelefCliente " +
                            ", @EmailCliente, @NroPlaca, @NroSerie, @NroVIN, @NroMotor, @Marca, @Modelo " +
                            ", @PlacaVigente, @Anotaciones)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Codigo", oportunidad.Codigo.Trim()));
                    command.Parameters.Add(new SqlParameter("@Estado", oportunidad.Estado));
                    command.Parameters.Add(new SqlParameter("@CodCliente", oportunidad.CodCliente));
                    command.Parameters.Add(new SqlParameter("@NombreCliente", oportunidad.NombreCliente));
                    command.Parameters.Add(new SqlParameter("@PersonaContact", oportunidad.PersonaContact));
                    command.Parameters.Add(new SqlParameter("@TelefCliente", oportunidad.TelefCliente));
                    command.Parameters.Add(new SqlParameter("@EmailCliente", oportunidad.EmailCliente));
                    command.Parameters.Add(new SqlParameter("@NroPlaca", oportunidad.NroPlaca));
                    command.Parameters.Add(new SqlParameter("@NroSerie", oportunidad.NroSerie));
                    command.Parameters.Add(new SqlParameter("@NroVIN", oportunidad.NroVIN));
                    command.Parameters.Add(new SqlParameter("@NroMotor", oportunidad.NroMotor));
                    command.Parameters.Add(new SqlParameter("@Marca", oportunidad.Marca));
                    command.Parameters.Add(new SqlParameter("@Modelo", oportunidad.Modelo));
                    command.Parameters.Add(new SqlParameter("@PlacaVigente", oportunidad.PlacaVigente));
                    command.Parameters.Add(new SqlParameter("@Anotaciones", oportunidad.Anotaciones));
                    command.ExecuteNonQuery();
                }
            }
            obj = Get(oportunidad.Codigo);
            return obj;
        }

        internal void Delete(string codigo)
        {
            string sql = "DELETE FROM [dbo].[Opportunity] WHERE [Codigo] = @Codigo ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Codigo", codigo));
                    command.ExecuteNonQuery();
                }
            }
        }

        internal Oportunidad Update(Oportunidad oportunidad)
        {
            Oportunidad Oupdated = null;
            string sql = "UPDATE [dbo].[Opportunity] " + 
                         " SET[Estado] = @Estado " + 
                         "    ,[CodCliente] = @CodCliente " + 
                         "    ,[NombreCliente] = @NombreCliente " + 
                         "    ,[PersonaContact] = @PersonaContact " + 
                         "    ,[TelefCliente] = @TelefCliente " + 
                         "    ,[EmailCliente] = @EmailCliente " + 
                         "    ,[NroPlaca] = @NroPlaca " + 
                         "    ,[NroSerie] = @NroSerie " + 
                         "    ,[NroVIN] = @NroVIN " + 
                         "    ,[NroMotor] = @NroMotor " + 
                         "    ,[Marca] = @Marca " + 
                         "    ,[Modelo] = @Modelo " + 
                         "    ,[PlacaVigente] = @PlacaVigente " + 
                         "    ,[Anotaciones] = @Anotaciones " + 
                         "  WHERE[Codigo] = @Codigo";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Codigo", oportunidad.Codigo.Trim()));
                    command.Parameters.Add(new SqlParameter("@Estado", oportunidad.Estado));
                    command.Parameters.Add(new SqlParameter("@CodCliente", oportunidad.CodCliente));
                    command.Parameters.Add(new SqlParameter("@NombreCliente", oportunidad.NombreCliente));
                    command.Parameters.Add(new SqlParameter("@PersonaContact", oportunidad.PersonaContact));
                    command.Parameters.Add(new SqlParameter("@TelefCliente", oportunidad.TelefCliente));
                    command.Parameters.Add(new SqlParameter("@EmailCliente", oportunidad.EmailCliente));
                    command.Parameters.Add(new SqlParameter("@NroPlaca", oportunidad.NroPlaca));
                    command.Parameters.Add(new SqlParameter("@NroSerie", oportunidad.NroSerie));
                    command.Parameters.Add(new SqlParameter("@NroVIN", oportunidad.NroVIN));
                    command.Parameters.Add(new SqlParameter("@NroMotor", oportunidad.NroMotor));
                    command.Parameters.Add(new SqlParameter("@Marca", oportunidad.Marca));
                    command.Parameters.Add(new SqlParameter("@Modelo", oportunidad.Modelo));
                    command.Parameters.Add(new SqlParameter("@PlacaVigente", oportunidad.PlacaVigente));
                    command.Parameters.Add(new SqlParameter("@Anotaciones", oportunidad.Anotaciones));
                    command.ExecuteNonQuery();
                }
            }
            Oupdated = Get(oportunidad.Codigo);
            return Oupdated;
        }
    }
}