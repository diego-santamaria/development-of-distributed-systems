using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WCFServiceCliente.Persistencia
{
    public class SQLCommands
    {
        /*
         public static SqlCommand OpenCommand(String StoredProcedure, List<SqlParameter> sqlParameters, String ConnectionName)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[ConnectionName ?? DefaultConnectionName()];
            if (settings == null) throw new Exception("No connectionstring found");
            SqlCommand cmd = new SqlCommand(StoredProcedure, new SqlConnection(settings.ConnectionString));
            cmd.CommandType = CommandType.StoredProcedure;
            if (null != sqlParameters)
            {
                CheckParameters(sqlParameters);
                cmd.Parameters.AddRange(sqlParameters.ToArray());
            }
            cmd.CommandTimeout = 300; // 5 minutes
            cmd.UpdatedRowSource = UpdateRowSource.None;
            cmd.Connection.Open();
            return cmd;
        }
             */

        /*
          public static SqlCommand OpenQueryCommand(String Query, String ConnectionName)
         {
             ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[ConnectionName ?? DefaultConnectionName()];
             if (settings == null) throw new Exception("No connectionstring found");
             SqlCommand cmd = new SqlCommand(Query, new SqlConnection(settings.ConnectionString));
             cmd.CommandType = CommandType.Text;
             cmd.CommandTimeout = 300; // 5 minutes
             cmd.UpdatedRowSource = UpdateRowSource.None;
             cmd.Connection.Open();
             return cmd;
         }
              */

        public static void CheckParameters(List<SqlParameter> sqlParameters)
        {
            foreach (SqlParameter parm in sqlParameters)
            {
                if (null == parm.Value)
                    parm.Value = DBNull.Value;
            }
        }

        public static void CloseCommand(ref SqlCommand sqlCommand)
        {
            if (null != sqlCommand && sqlCommand.Connection.State == ConnectionState.Open)
                sqlCommand.Connection.Close();
        }
    }
}