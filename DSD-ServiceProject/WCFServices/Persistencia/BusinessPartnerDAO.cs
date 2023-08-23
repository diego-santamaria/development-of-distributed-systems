using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServiceCliente.Dominio;
using WCFServiceCliente.Commons;

namespace WCFServiceCliente.Persistencia
{
    public class BusinessPartnerDAO
    {
        //private string sConnectionString = @"Data Source=LDTHINKPAD\LDSQLSERVER16;Initial Catalog=DB_DSD_SDN;Integrated Security=SSPI;User ID = sa;Password=root;";
        private string connectionString = Properties.Settings.Default.sConnectionString;

        public BusinessPartner Create(BusinessPartner businessPartner)
        {
            BusinessPartner newBP = null;
            string sql = "INSERT INTO [dbo].[BusinessPartner] ([CardCode],[CardName],[Nombres],[ApellidoPat],[ApellidoMat],[LicTradNum],[TipoDoc],[TipoPersona],[ContctPrsn]" +
                ",[Telephone1],[Telephone2],[Email],[Cellular],[Address],[Notes],[Active]) " +
                "VALUES(@CardCode,@CardName, @Nombres, @ApellidoPat, @ApellidoMat, @LicTradNum, @TipoDoc, @TipoPersona" +
                ", @ContctPrsn, @Telephone1, @Telephone2, @Email, @Cellular, @Address, @Notes, @Active)";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@CardCode", businessPartner.CardCode.Trim()));
                    command.Parameters.Add(new SqlParameter("@CardName", businessPartner.CardName));
                    command.Parameters.Add(new SqlParameter("@Nombres", businessPartner.Nombres));
                    command.Parameters.Add(new SqlParameter("@ApellidoPat", businessPartner.ApellidoPat));
                    command.Parameters.Add(new SqlParameter("@ApellidoMat", businessPartner.ApellidoMat));
                    command.Parameters.Add(new SqlParameter("@LicTradNum", businessPartner.LicTradNum));
                    command.Parameters.Add(new SqlParameter("@TipoDoc", businessPartner.TipoDoc));
                    command.Parameters.Add(new SqlParameter("@TipoPersona", businessPartner.TipoPer));
                    command.Parameters.Add(new SqlParameter("@ContctPrsn", businessPartner.ContctPrsn));
                    command.Parameters.Add(new SqlParameter("@Telephone1", businessPartner.Telephone1));
                    command.Parameters.Add(new SqlParameter("@Telephone2", businessPartner.Telephone2));
                    command.Parameters.Add(new SqlParameter("@Email", businessPartner.Email));
                    command.Parameters.Add(new SqlParameter("@Cellular", businessPartner.Cellular));
                    command.Parameters.Add(new SqlParameter("@Address", businessPartner.Address));
                    command.Parameters.Add(new SqlParameter("@Notes", businessPartner.Notes));
                    command.Parameters.Add(new SqlParameter("@Active", businessPartner.Active));
                    command.ExecuteNonQuery();
                }
            }
            newBP = Get(businessPartner.CardCode);
            return newBP;
        }
        
        public BusinessPartner Get(string cardCode)
        {
            BusinessPartner existingBP = null;
            string sql = "SELECT [CardCode],[CardName],[Nombres],[ApellidoPat],[ApellidoMat],[LicTradNum],[TipoDoc],[TipoPersona],[ContctPrsn]" +
                ",[Telephone1],[Telephone2],[Email],[Cellular],[Address],[Notes],[Active] FROM [dbo].[BusinessPartner] WHERE [CardCode] = @CardCode";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@CardCode", cardCode));
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {                            
                            existingBP = new BusinessPartner()
                            {
                                CardCode = Useful.isText(dataReader["CardCode"]).Trim(),
                                CardName = Useful.isText(dataReader["CardName"]),
                                Nombres = Useful.isText(dataReader["Nombres"]),
                                ApellidoPat = Useful.isText(dataReader["ApellidoPat"]),
                                ApellidoMat = Useful.isText(dataReader["ApellidoMat"]),
                                LicTradNum = Useful.isText(dataReader["LicTradNum"]),
                                TipoDoc = Useful.isText(dataReader["TipoDoc"]),
                                TipoPer = Useful.isText(dataReader["TipoPersona"]),
                                ContctPrsn = Useful.isText(dataReader["ContctPrsn"]),
                                Telephone1 = Useful.isText(dataReader["Telephone1"]),
                                Telephone2 = Useful.isText(dataReader["Telephone2"]),
                                Email = Useful.isText(dataReader["Email"]),
                                Cellular = Useful.isText(dataReader["Cellular"]),
                                Address = Useful.isText(dataReader["Address"]),
                                Notes = Useful.isText(dataReader["Notes"]),
                                Active = Useful.isText(dataReader["Active"])
                            };
                        }
                    }
                }
            }
            return existingBP;
        }

        public BusinessPartner Update(BusinessPartner businessPartner)
        {
            BusinessPartner BPupdated = null;
            string sql = "UPDATE [dbo].[BusinessPartner] SET [CardName] = @CardName,"
                + "[Nombres] = @Nombres,[ApellidoPat] = @ApellidoPat,[ApellidoMat] = @ApellidoMat,[LicTradNum] = @LicTradNum" +
                ",[TipoDoc] = @TipoDoc,[TipoPersona] = @TipoPersona,[ContctPrsn] = @ContctPrsn, [Telephone1] = @Telephone1" +
                ",[Telephone2] = @Telephone2,[Email] = @Email,[Cellular] = @Cellular,[Address] = @Address,[Notes] = @Notes,[Active] = @Active "
                + "WHERE [CardCode] = @CardCode";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@CardCode", businessPartner.CardCode));
                    command.Parameters.Add(new SqlParameter("@CardName", businessPartner.CardName));
                    command.Parameters.Add(new SqlParameter("@Nombres", businessPartner.Nombres));
                    command.Parameters.Add(new SqlParameter("@ApellidoPat", businessPartner.ApellidoPat));
                    command.Parameters.Add(new SqlParameter("@ApellidoMat", businessPartner.ApellidoMat));
                    command.Parameters.Add(new SqlParameter("@LicTradNum", businessPartner.LicTradNum));
                    command.Parameters.Add(new SqlParameter("@TipoDoc", businessPartner.TipoDoc));
                    command.Parameters.Add(new SqlParameter("@TipoPersona", businessPartner.TipoPer));
                    command.Parameters.Add(new SqlParameter("@ContctPrsn", businessPartner.ContctPrsn));
                    command.Parameters.Add(new SqlParameter("@Telephone1", businessPartner.Telephone1));
                    command.Parameters.Add(new SqlParameter("@Telephone2", businessPartner.Telephone2));
                    command.Parameters.Add(new SqlParameter("@Email", businessPartner.Email));
                    command.Parameters.Add(new SqlParameter("@Cellular", businessPartner.Cellular));
                    command.Parameters.Add(new SqlParameter("@Address", businessPartner.Address));
                    command.Parameters.Add(new SqlParameter("@Notes", businessPartner.Notes));
                    command.Parameters.Add(new SqlParameter("@Active", businessPartner.Active));
                    command.ExecuteNonQuery();
                }
            }
            BPupdated = Get(businessPartner.CardCode);
            return BPupdated;
        }

        public void Delete(string cardCode)
        {
            string sql = "DELETE FROM [dbo].[BusinessPartner] WHERE [CardCode] = @CardCode ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@CardCode", cardCode));
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<BusinessPartner> List()
        {
            List<BusinessPartner> businessPartners = new List<BusinessPartner>();
            string sql = "SELECT [CardCode],[CardName],[Nombres],[ApellidoPat],[ApellidoMat],[LicTradNum],[TipoDoc],[TipoPersona],[ContctPrsn]" +
                ",[Telephone1],[Telephone2],[Email],[Cellular],[Address],[Notes],[Active] FROM [dbo].[BusinessPartner] ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            businessPartners.Add(new BusinessPartner()
                            {
                                CardCode = Useful.isText(dataReader["CardCode"]),
                                CardName = Useful.isText(dataReader["CardName"]),
                                Nombres = Useful.isText(dataReader["Nombres"]),
                                ApellidoPat = Useful.isText(dataReader["ApellidoPat"]),
                                ApellidoMat = Useful.isText(dataReader["ApellidoMat"]),
                                LicTradNum = Useful.isText(dataReader["LicTradNum"]),
                                TipoDoc = Useful.isText(dataReader["TipoDoc"]),
                                TipoPer = Useful.isText(dataReader["TipoPersona"]),
                                ContctPrsn = Useful.isText(dataReader["ContctPrsn"]),
                                Telephone1 = Useful.isText(dataReader["Telephone1"]),
                                Telephone2 = Useful.isText(dataReader["Telephone2"]),
                                Email = Useful.isText(dataReader["Email"]),
                                Cellular = Useful.isText(dataReader["Cellular"]),
                                Address = Useful.isText(dataReader["Address"]),
                                Notes = Useful.isText(dataReader["Notes"]),
                                Active = Useful.isText(dataReader["Active"])
                            });
                        }
                    }
                }
            }
            return businessPartners;
        }

        public List<BusinessPartner> ListWithParameters(string cardcode = null, string cardname = null, string docnum = null, string telephone = null)
        {
            List<BusinessPartner> businessPartners = new List<BusinessPartner>();
            string sql = "SELECT [CardCode],[CardName],[Nombres],[ApellidoPat],[ApellidoMat],[LicTradNum],[TipoDoc],[TipoPersona],[ContctPrsn]" +
                ",[Telephone1],[Telephone2],[Email],[Cellular],[Address],[Notes],[Active] FROM [dbo].[BusinessPartner] WHERE " +
                "   ([CardCode] LIKE @cardCode + '%' OR @cardCode IS NULL) AND " +
                "   ([CardName] LIKE '%' + @cardname + '%' OR @cardname IS NULL) AND " +
                "   ([LicTradNum] = @docnum OR @docnum IS NULL) AND " +
                "   ([Cellular] = @telephone OR @telephone IS NULL )   ";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@cardCode", cardcode ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@cardname", cardname ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@docnum", docnum ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@telephone", telephone ?? (object)DBNull.Value);                    

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            businessPartners.Add(new BusinessPartner()
                            {
                                CardCode = Useful.isText(dataReader["CardCode"]).Trim(),
                                CardName = Useful.isText(dataReader["CardName"]),
                                Nombres = Useful.isText(dataReader["Nombres"]),
                                ApellidoPat = Useful.isText(dataReader["ApellidoPat"]),
                                ApellidoMat = Useful.isText(dataReader["ApellidoMat"]),
                                LicTradNum = Useful.isText(dataReader["LicTradNum"]),
                                TipoDoc = Useful.isText(dataReader["TipoDoc"]),
                                TipoPer = Useful.isText(dataReader["TipoPersona"]),
                                ContctPrsn = Useful.isText(dataReader["ContctPrsn"]),
                                Telephone1 = Useful.isText(dataReader["Telephone1"]),
                                Telephone2 = Useful.isText(dataReader["Telephone2"]),
                                Email = Useful.isText(dataReader["Email"]),
                                Cellular = Useful.isText(dataReader["Cellular"]),
                                Address = Useful.isText(dataReader["Address"]),
                                Notes = Useful.isText(dataReader["Notes"]),
                                Active = Useful.isText(dataReader["Active"])
                            });
                        }
                    }
                }
            }
            return businessPartners;
        }
    }
}